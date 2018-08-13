namespace WaitlistInspector
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbRenalNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPtNames = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbSpecs = new System.Windows.Forms.TextBox();
            this.tbOther = new System.Windows.Forms.TextBox();
            this.tbFurther = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btLogDiff = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbUktNo = new System.Windows.Forms.Label();
            this.rb32gc322 = new System.Windows.Forms.RadioButton();
            this.rbLocalhost = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRenalNum
            // 
            this.tbRenalNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRenalNum.Location = new System.Drawing.Point(16, 25);
            this.tbRenalNum.Name = "tbRenalNum";
            this.tbRenalNum.Size = new System.Drawing.Size(72, 27);
            this.tbRenalNum.TabIndex = 0;
            this.tbRenalNum.Click += new System.EventHandler(this.tbRenalNum_Click);
            this.tbRenalNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRenalNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Renal Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(833, 243);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(240, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Name";
            // 
            // lbPtNames
            // 
            this.lbPtNames.AutoSize = true;
            this.lbPtNames.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPtNames.Location = new System.Drawing.Point(239, 31);
            this.lbPtNames.Name = "lbPtNames";
            this.lbPtNames.Size = new System.Drawing.Size(0, 23);
            this.lbPtNames.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Coral;
            this.lbStatus.Location = new System.Drawing.Point(631, 32);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(16, 14);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "...";
            // 
            // tbSpecs
            // 
            this.tbSpecs.Enabled = false;
            this.tbSpecs.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpecs.Location = new System.Drawing.Point(67, 15);
            this.tbSpecs.Name = "tbSpecs";
            this.tbSpecs.Size = new System.Drawing.Size(636, 26);
            this.tbSpecs.TabIndex = 4;
            // 
            // tbOther
            // 
            this.tbOther.Enabled = false;
            this.tbOther.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOther.Location = new System.Drawing.Point(67, 44);
            this.tbOther.Name = "tbOther";
            this.tbOther.Size = new System.Drawing.Size(636, 26);
            this.tbOther.TabIndex = 4;
            // 
            // tbFurther
            // 
            this.tbFurther.Enabled = false;
            this.tbFurther.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFurther.Location = new System.Drawing.Point(67, 73);
            this.tbFurther.Name = "tbFurther";
            this.tbFurther.Size = new System.Drawing.Size(636, 26);
            this.tbFurther.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "specs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "other";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "further";
            // 
            // btLogDiff
            // 
            this.btLogDiff.Location = new System.Drawing.Point(739, 15);
            this.btLogDiff.Name = "btLogDiff";
            this.btLogDiff.Size = new System.Drawing.Size(70, 32);
            this.btLogDiff.TabIndex = 5;
            this.btLogDiff.Text = "Log Diff";
            this.btLogDiff.UseVisualStyleBackColor = true;
            this.btLogDiff.Click += new System.EventHandler(this.btLogDiff_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(133, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "UKT No";
            // 
            // lbUktNo
            // 
            this.lbUktNo.AutoSize = true;
            this.lbUktNo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUktNo.Location = new System.Drawing.Point(132, 29);
            this.lbUktNo.Name = "lbUktNo";
            this.lbUktNo.Size = new System.Drawing.Size(0, 23);
            this.lbUktNo.TabIndex = 1;
            // 
            // rb32gc322
            // 
            this.rb32gc322.AutoSize = true;
            this.rb32gc322.Location = new System.Drawing.Point(746, 68);
            this.rb32gc322.Name = "rb32gc322";
            this.rb32gc322.Size = new System.Drawing.Size(70, 17);
            this.rb32gc322.TabIndex = 6;
            this.rb32gc322.Text = "32GC322";
            this.rb32gc322.UseVisualStyleBackColor = true;
            this.rb32gc322.CheckedChanged += new System.EventHandler(this.rb32gc322_CheckedChanged);
            // 
            // rbLocalhost
            // 
            this.rbLocalhost.AutoSize = true;
            this.rbLocalhost.Checked = true;
            this.rbLocalhost.Location = new System.Drawing.Point(746, 86);
            this.rbLocalhost.Name = "rbLocalhost";
            this.rbLocalhost.Size = new System.Drawing.Size(62, 17);
            this.rbLocalhost.TabIndex = 7;
            this.rbLocalhost.TabStop = true;
            this.rbLocalhost.Text = "This PC";
            this.rbLocalhost.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbRenalNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbPtNames);
            this.panel1.Controls.Add(this.lbUktNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 59);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 243);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbSpecs);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.rbLocalhost);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.rb32gc322);
            this.panel3.Controls.Add(this.tbOther);
            this.panel3.Controls.Add(this.btLogDiff);
            this.panel3.Controls.Add(this.tbFurther);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 113);
            this.panel3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 415);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waitlist Inspector";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbRenalNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPtNames;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox tbSpecs;
        private System.Windows.Forms.TextBox tbOther;
        private System.Windows.Forms.TextBox tbFurther;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btLogDiff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbUktNo;
        private System.Windows.Forms.RadioButton rb32gc322;
        private System.Windows.Forms.RadioButton rbLocalhost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

