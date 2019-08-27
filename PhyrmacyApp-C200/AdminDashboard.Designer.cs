namespace PhyrmacyApp_C200
{
    partial class AdminDashboard
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
            this.label2 = new System.Windows.Forms.Label();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.rcDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkWithReceipt = new System.Windows.Forms.CheckBox();
            this.dtProductionDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndlineDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tagGroups = new System.Windows.Forms.GroupBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.dtgView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmedicinename = new System.Windows.Forms.TextBox();
            this.cmbFirms = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(16, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // nmPrice
            // 
            this.nmPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmPrice.Location = new System.Drawing.Point(23, 175);
            this.nmPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(197, 22);
            this.nmPrice.TabIndex = 3;
            // 
            // rcDescription
            // 
            this.rcDescription.Location = new System.Drawing.Point(23, 303);
            this.rcDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rcDescription.Name = "rcDescription";
            this.rcDescription.Size = new System.Drawing.Size(268, 117);
            this.rcDescription.TabIndex = 4;
            this.rcDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(21, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // chkWithReceipt
            // 
            this.chkWithReceipt.AutoSize = true;
            this.chkWithReceipt.Location = new System.Drawing.Point(27, 447);
            this.chkWithReceipt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkWithReceipt.Name = "chkWithReceipt";
            this.chkWithReceipt.Size = new System.Drawing.Size(110, 21);
            this.chkWithReceipt.TabIndex = 6;
            this.chkWithReceipt.Text = "With Receipt";
            this.chkWithReceipt.UseVisualStyleBackColor = true;
            // 
            // dtProductionDate
            // 
            this.dtProductionDate.Location = new System.Drawing.Point(356, 219);
            this.dtProductionDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtProductionDate.Name = "dtProductionDate";
            this.dtProductionDate.Size = new System.Drawing.Size(265, 22);
            this.dtProductionDate.TabIndex = 7;
            this.dtProductionDate.Value = new System.DateTime(2019, 8, 13, 0, 0, 0, 0);
            // 
            // dtEndlineDate
            // 
            this.dtEndlineDate.Location = new System.Drawing.Point(689, 220);
            this.dtEndlineDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtEndlineDate.Name = "dtEndlineDate";
            this.dtEndlineDate.Size = new System.Drawing.Size(265, 22);
            this.dtEndlineDate.TabIndex = 8;
            this.dtEndlineDate.Value = new System.DateTime(2019, 8, 13, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(351, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Production Date";
            // 
            // tagGroups
            // 
            this.tagGroups.Location = new System.Drawing.Point(1001, 175);
            this.tagGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tagGroups.Name = "tagGroups";
            this.tagGroups.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tagGroups.Size = new System.Drawing.Size(445, 198);
            this.tagGroups.TabIndex = 18;
            this.tagGroups.TabStop = false;
            this.tagGroups.Text = "groupBox1";
            this.tagGroups.Enter += new System.EventHandler(this.TagGroups_Enter);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(384, 352);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(197, 30);
            this.txtBarcode.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(379, 300);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Barcode";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(16, 519);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 70);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add Medicine";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Red;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblError.Location = new System.Drawing.Point(617, 469);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(85, 25);
            this.lblError.TabIndex = 22;
            this.lblError.Text = "Barcode";
            this.lblError.Visible = false;
            // 
            // dtgView
            // 
            this.dtgView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgView.Location = new System.Drawing.Point(16, 640);
            this.dtgView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgView.Name = "dtgView";
            this.dtgView.Size = new System.Drawing.Size(1431, 185);
            this.dtgView.TabIndex = 23;
            this.dtgView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine";
            // 
            // txtmedicinename
            // 
            this.txtmedicinename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedicinename.Location = new System.Drawing.Point(21, 63);
            this.txtmedicinename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmedicinename.Name = "txtmedicinename";
            this.txtmedicinename.Size = new System.Drawing.Size(197, 30);
            this.txtmedicinename.TabIndex = 1;
            // 
            // cmbFirms
            // 
            this.cmbFirms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFirms.FormattingEnabled = true;
            this.cmbFirms.Location = new System.Drawing.Point(356, 63);
            this.cmbFirms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFirms.Name = "cmbFirms";
            this.cmbFirms.Size = new System.Drawing.Size(228, 33);
            this.cmbFirms.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(351, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Firms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(617, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Count";
            // 
            // nmCount
            // 
            this.nmCount.Location = new System.Drawing.Point(623, 73);
            this.nmCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(163, 22);
            this.nmCount.TabIndex = 15;
            // 
            // cmbTags
            // 
            this.cmbTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(963, 65);
            this.cmbTags.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(228, 33);
            this.cmbTags.TabIndex = 16;
            this.cmbTags.SelectedIndexChanged += new System.EventHandler(this.CmbTags_SelectedIndexChanged);
            this.cmbTags.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbTags_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(957, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tags";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 839);
            this.Controls.Add(this.dtgView);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tagGroups);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.nmCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbFirms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtEndlineDate);
            this.Controls.Add(this.dtProductionDate);
            this.Controls.Add(this.chkWithReceipt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rcDescription);
            this.Controls.Add(this.nmPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmedicinename);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminDashboard";
            this.Text = "Description";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.RichTextBox rcDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkWithReceipt;
        private System.Windows.Forms.DateTimePicker dtProductionDate;
        private System.Windows.Forms.DateTimePicker dtEndlineDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox tagGroups;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dtgView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmedicinename;
        private System.Windows.Forms.ComboBox cmbFirms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmCount;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.Label label8;
    }
}