using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WaitlistInspector
{
    public partial class Form1 : Form
    {
        string db = Properties.Settings.Default.waitlistdb;      
        string waitlistConStr;
        string renaldbfConStr;                           
        string renal = @"C:\renal";        

        public Form1()
        {
            InitializeComponent();
            waitlistConStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={db}";            
        }


        private void tbRenalNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            int renalNum;

            if (e.KeyChar == (char)13)
            {
                lbStatus.Text = "";
                lbUktNo.Text = "";
                lbPtNames.Text = "";
                tbSpecs.Text = "";
                tbFurther.Text = "";
                tbOther.Text = "";

                if (int.TryParse(tbRenalNum.Text, out renalNum) && renalNum > 0 && renalNum <=9999)
                {                    
                    antibodySpecTrail(renalNum);
                    populateRlistSpecs(renalNum);
                }
                else
                {
                    MessageBox.Show($"\"{tbRenalNum.Text}\" - invalid renal number.");                    
                }
                tbRenalNum.SelectAll();
            }
        }
        
        //read waitlist.accdb
        private void antibodySpecTrail(int renalNumber)
        {

            lbStatus.Text = "Working...";

            OleDbConnection con = new OleDbConnection(waitlistConStr);
            DataTable dt = new DataTable();
            //Waitlist + Patient are jointed in _view_WaitlistPatients query -> sort of a 'View' for Access SQL
            //
            //string queryStr = @"SELECT                                       
            //                        p.[Last] + ', ' + p.[First] AS [names]
            //                        , w.[UKT_NO] AS [uktno]
            //                        , w.[time_of_file_production] AS [date]
            //                        , w.[Calc_reaction_freq] AS [cRF]
            //                        , w.[defined_unacceptables] AS [specs]
            //                        , w.[other_unacceptables] AS [other]
            //                    FROM Patients AS p
            //                    LEFT JOIN Waitlist AS w 
            //                    ON p.[UKTSNO] = CSTR(w.[UKT_NO])
            //                    WHERE p.[number]=CSTR(@renal_number)
            //                    ORDER BY w.[time_of_file_production] DESC;";

            string queryStr = @"SELECT [Last] + ', ' + [First] AS [names]
                                    , [UKT_NO] AS [uktno]
                                    , [time_of_file_production] AS [date]
                                    , [Calc_reaction_freq] AS [cRF]
                                    , [defined_unacceptables] AS [specs]
                                    , [other_unacceptables] AS [other]
                                FROM
                                    _view_WaitlistPatients
                                WHERE [number]=CSTR(@renal_number)
                                ORDER BY [time_of_file_production] DESC;";

            OleDbCommand cmd = new OleDbCommand(queryStr);
            cmd.Parameters.AddWithValue("@renal_number", renalNumber);
            cmd.Connection = con;
            using (con)
            {
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
            }

            if (dt.Rows.Count > 0)
            {
                lbPtNames.Text = dt.Rows[0]["names"].ToString();
            }
            else
            {
                lbPtNames.Text = "NOT FOUND";
            }
            if (dt.Rows.Count > 1)
            {
                lbStatus.Text = "";
                lbUktNo.Text = dt.Rows[0]["uktno"].ToString();

                dt.Columns.Remove("names");
                dt.Columns.Remove("uktno");

                foreach (DataRow row in dt.Rows)
                {
                    row["specs"] = string.Join(",", sortedAbSpecs(row["specs"].ToString()));
                }

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["date"].Width = 80;
                dataGridView1.Columns["cRF"].Width = 40;
                dataGridView1.Columns["specs"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["specs"].MinimumWidth = 350;
                dataGridView1.Columns["other"].MinimumWidth = 40;
            }
            else
            {
                dataGridView1.DataSource = null;
                lbStatus.Text = "No previous waitlist info recorded ...";
            }
        }

/// <summary>
/// sort antibody specs in numerical and locus order
/// </summary>
/// <param name="abSpecs"></param>
/// <returns></returns>
        private string[] sortedAbSpecs(string abSpecs)
        {
            abSpecs = abSpecs.ToUpper();
            Dictionary<string, List<object>> specDict = new Dictionary<string, List<object>>();
            Regex re = new Regex(@"([A-z]+)(\d+)");
            MatchCollection matches = re.Matches(abSpecs);

            foreach (Match match in matches)
            {
                string antigen = match.Groups[0].ToString();
                string locus = match.Groups[1].ToString();
                int number = int.Parse(match.Groups[2].ToString());
                Dictionary<string, int> locusOrder = new Dictionary<string, int>() {
                    { "A", 0 }, { "B", 1 }, {"BW", 2 }, {"CW", 3},{"DR", 4 }, {"DQ",5 }, {"DQB", 6 }, {"DP", 7}, {"DPB", 8}};

                specDict.Add(antigen, new List<object>() { locusOrder[locus], number });
            }

            var result = specDict.OrderBy(x => x.Value[1]).OrderBy(x => x.Value[0]).Select(x => x.Key.Replace("W", "w"));

            return result.ToArray();

        }

        private void btLogDiff_Click(object sender, EventArgs e)
        {
            int recordCount;

            if (MessageBox.Show("Log the discrepancy?", "Discrepancy", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (checkDiscrepancyExist(out recordCount) == true)
                {                    
                    if (MessageBox.Show($"{recordCount} previous unarchived records.", 
                        "Previously logged", MessageBoxButtons.YesNo) == DialogResult.Yes)                    
                        logDiscrepancy();                    
                }
                else
                {
                    logDiscrepancy();
                }
            }
        }

        //read from c:\renal\rlist.dbf
        private void populateRlistSpecs(int renalNumber)
        {            
            renaldbfConStr = $"Provider=VFPOLEDB;Data Source={renal};Exclusive=Yes;Collating Sequence=machine";
            OleDbConnection con = new OleDbConnection(renaldbfConStr);
            string queryStr = $@"SELECT                                 
                                  ABSPEC AS specs
                                , HLA_ACCEPT AS further
                                , HLA_OTHER AS other
                                FROM
                                  RLIST
                                WHERE
                                  VAL(NUMBER)={renalNumber}";

            //IMPORTANT FOR FUTURE REFERENCE: 
            //  - Use VFPOLEDB provider to read dbf file with memo fields
            //  - This provider does NOT like []
            //  - 'Key words' like NUMBER, DATE are accepted without []

            OleDbCommand cmd = new OleDbCommand(queryStr);
            //cmd.Parameters.AddWithValue("@renal_number", renalNumber); //==> DOESN'T WORK
            try
            {
                cmd.Connection = con;
                using (con)
                {
                    con.Open();
                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {

                        if (dr.Read())
                        {
                            tbSpecs.Text = dr["specs"].ToString();
                            tbOther.Text = dr["other"].ToString();
                            tbFurther.Text = dr["further"].ToString();
                        }

                    }
                }
            }
            catch
            {
                tbSpecs.Text = "Failed to connect to VFP DB provider, no specs displayed.";
            }
            
        }

        private void rb32gc322_CheckedChanged(object sender, EventArgs e)
        {
            if (rb32gc322.Checked == true)
                renal = Properties.Settings.Default.renaldbf;
            else
                renal = @"C:\renal";
        }

        //write to waitlist.accdb
        private void logDiscrepancy()
        {
            OleDbConnection con = new OleDbConnection(waitlistConStr);
            string insertQuery = @"INSERT INTO 
                                     DISCREPANCY
                                       (UKT_NO
                                       ,RENAL_NO
                                       ,AUDIT_DATE
                                       ,ANTIBODY_SPECS
                                       ,OTHER_SPECS
                                       ,FURTHER_SPECS
                                       ,ARCHIVED)
                                   VALUES(@ukt_no 
                                         ,@renal_no
                                         ,@audit_date
                                         ,@specs
                                         ,@other
                                         ,@further
                                         ,'N'
                                         )";

            OleDbCommand cmd = new OleDbCommand(insertQuery);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@ukt_no", int.Parse(lbUktNo.Text));
            cmd.Parameters.AddWithValue("@renal_no", int.Parse(tbRenalNum.Text));
            cmd.Parameters.AddWithValue("@audit_date", DateTime.Now.ToLongDateString());
            cmd.Parameters.AddWithValue("@specs", tbSpecs.Text);
            cmd.Parameters.AddWithValue("@other", tbOther.Text);
            cmd.Parameters.AddWithValue("@further", tbFurther.Text);
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private bool checkDiscrepancyExist(out int Count)
        {
            DataTable dt = new DataTable();
            OleDbConnection con = new OleDbConnection(waitlistConStr);
            string selectQuery = $@"SELECT * 
                                    FROM Discrepancy 
                                    WHERE 
                                        (RENAL_NO = {int.Parse(tbRenalNum.Text)})
                                        AND ARCHIVED = 'N'
                                    ";            
            using (con)
            {
                OleDbDataAdapter da = new OleDbDataAdapter(selectQuery, con);                
                da.Fill(dt);
            }

            //Count = dt.Rows.Count;

            if ((Count = dt.Rows.Count) > 0)                                          
                return true;            
            else            
                return false;            
        }

        private void tbRenalNum_Click(object sender, EventArgs e)
        {
            tbRenalNum.SelectAll();
        }

        //wrapping long specs strings in tooltip text
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int wrapLen = 84;
            if ((e.RowIndex >= 0) && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellText = cell.Value.ToString();
                if (cellText.Length >= wrapLen)
                {
                    cell.ToolTipText = "";

                    int n = cellText.Length / wrapLen;
                    for (int i = 0; i <= n; i++)
                    {
                        int wStart = wrapLen * i;
                        int wEnd = wrapLen * (i + 1);

                        if (wEnd >= cellText.Length)
                            wEnd = cellText.Length;

                        cell.ToolTipText += cellText.Substring(wStart, wEnd - wStart) + "\n";

                    }
                }
            }
        }
       

    }
}
