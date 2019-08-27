namespace PhyrmacyApp_C200
{
    partial class WorkerDashboard
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
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.dtgMedicineList = new System.Windows.Forms.DataGridView();
            this.grpMedicineBuy = new System.Windows.Forms.GroupBox();
            this.lblMedicineBuyName = new System.Windows.Forms.Label();
            this.txtMedicineBuyName = new System.Windows.Forms.TextBox();
            this.nmBuyCount = new System.Windows.Forms.NumericUpDown();
            this.lblMedicineCount = new System.Windows.Forms.Label();
            this.btnMedicineBuy = new System.Windows.Forms.Button();
            this.btnOrderMedicine = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBuyCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(84, 314);
            this.cmbMedicine.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(160, 24);
            this.cmbMedicine.TabIndex = 0;
            this.cmbMedicine.SelectedIndexChanged += new System.EventHandler(this.CmbMedicine_SelectedIndexChanged);
            this.cmbMedicine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbMedicine_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(79, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(317, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "By Tag";
            // 
            // cmbTags
            // 
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(323, 314);
            this.cmbTags.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(160, 24);
            this.cmbTags.TabIndex = 2;
            this.cmbTags.SelectedIndexChanged += new System.EventHandler(this.CmbTags_SelectedIndexChanged);
            this.cmbTags.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbTags_KeyUp);
            // 
            // dtgMedicineList
            // 
            this.dtgMedicineList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedicineList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgMedicineList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicineList.Location = new System.Drawing.Point(4, 560);
            this.dtgMedicineList.Margin = new System.Windows.Forms.Padding(4);
            this.dtgMedicineList.Name = "dtgMedicineList";
            this.dtgMedicineList.Size = new System.Drawing.Size(1929, 199);
            this.dtgMedicineList.TabIndex = 4;
            this.dtgMedicineList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMedicineList_CellContentClick);
            this.dtgMedicineList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgMedicineList_RowHeaderMouseDoubleClick);
            // 
            // grpMedicineBuy
            // 
            this.grpMedicineBuy.Location = new System.Drawing.Point(1341, 110);
            this.grpMedicineBuy.Margin = new System.Windows.Forms.Padding(4);
            this.grpMedicineBuy.Name = "grpMedicineBuy";
            this.grpMedicineBuy.Padding = new System.Windows.Forms.Padding(4);
            this.grpMedicineBuy.Size = new System.Drawing.Size(440, 230);
            this.grpMedicineBuy.TabIndex = 5;
            this.grpMedicineBuy.TabStop = false;
            this.grpMedicineBuy.Text = "Medicine Buy";
            this.grpMedicineBuy.Visible = false;
            // 
            // lblMedicineBuyName
            // 
            this.lblMedicineBuyName.AutoSize = true;
            this.lblMedicineBuyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineBuyName.ForeColor = System.Drawing.Color.Maroon;
            this.lblMedicineBuyName.Location = new System.Drawing.Point(1005, 76);
            this.lblMedicineBuyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicineBuyName.Name = "lblMedicineBuyName";
            this.lblMedicineBuyName.Size = new System.Drawing.Size(91, 25);
            this.lblMedicineBuyName.TabIndex = 6;
            this.lblMedicineBuyName.Text = "Medicine";
            this.lblMedicineBuyName.Visible = false;
            // 
            // txtMedicineBuyName
            // 
            this.txtMedicineBuyName.Enabled = false;
            this.txtMedicineBuyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineBuyName.Location = new System.Drawing.Point(1011, 128);
            this.txtMedicineBuyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicineBuyName.Name = "txtMedicineBuyName";
            this.txtMedicineBuyName.Size = new System.Drawing.Size(203, 30);
            this.txtMedicineBuyName.TabIndex = 7;
            this.txtMedicineBuyName.Visible = false;
            // 
            // nmBuyCount
            // 
            this.nmBuyCount.Location = new System.Drawing.Point(1011, 222);
            this.nmBuyCount.Margin = new System.Windows.Forms.Padding(4);
            this.nmBuyCount.Name = "nmBuyCount";
            this.nmBuyCount.Size = new System.Drawing.Size(160, 22);
            this.nmBuyCount.TabIndex = 8;
            this.nmBuyCount.Visible = false;
            this.nmBuyCount.ValueChanged += new System.EventHandler(this.NmBuyCount_ValueChanged);
            this.nmBuyCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NmBuyCount_KeyDown);
            this.nmBuyCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NmBuyCount_KeyPress);
            // 
            // lblMedicineCount
            // 
            this.lblMedicineCount.AutoSize = true;
            this.lblMedicineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblMedicineCount.Location = new System.Drawing.Point(1005, 186);
            this.lblMedicineCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicineCount.Name = "lblMedicineCount";
            this.lblMedicineCount.Size = new System.Drawing.Size(65, 25);
            this.lblMedicineCount.TabIndex = 9;
            this.lblMedicineCount.Text = "Count";
            this.lblMedicineCount.Visible = false;
            // 
            // btnMedicineBuy
            // 
            this.btnMedicineBuy.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMedicineBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineBuy.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnMedicineBuy.Location = new System.Drawing.Point(1011, 262);
            this.btnMedicineBuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedicineBuy.Name = "btnMedicineBuy";
            this.btnMedicineBuy.Size = new System.Drawing.Size(119, 44);
            this.btnMedicineBuy.TabIndex = 10;
            this.btnMedicineBuy.Text = "Sell";
            this.btnMedicineBuy.UseVisualStyleBackColor = false;
            this.btnMedicineBuy.Visible = false;
            this.btnMedicineBuy.Click += new System.EventHandler(this.BtnMedicineBuy_Click);
            // 
            // btnOrderMedicine
            // 
            this.btnOrderMedicine.BackColor = System.Drawing.Color.DarkCyan;
            this.btnOrderMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMedicine.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnOrderMedicine.Location = new System.Drawing.Point(1341, 347);
            this.btnOrderMedicine.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderMedicine.Name = "btnOrderMedicine";
            this.btnOrderMedicine.Size = new System.Drawing.Size(119, 44);
            this.btnOrderMedicine.TabIndex = 11;
            this.btnOrderMedicine.Text = "Order";
            this.btnOrderMedicine.UseVisualStyleBackColor = false;
            this.btnOrderMedicine.Visible = false;
            this.btnOrderMedicine.Click += new System.EventHandler(this.BtnOrderMedicine_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(84, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 65);
            this.button2.TabIndex = 25;
            this.button2.Text = "Excell Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // WorkerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 756);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOrderMedicine);
            this.Controls.Add(this.btnMedicineBuy);
            this.Controls.Add(this.lblMedicineCount);
            this.Controls.Add(this.nmBuyCount);
            this.Controls.Add(this.txtMedicineBuyName);
            this.Controls.Add(this.lblMedicineBuyName);
            this.Controls.Add(this.grpMedicineBuy);
            this.Controls.Add(this.dtgMedicineList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMedicine);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkerDashboard";
            this.Text = "WorkerDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBuyCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.DataGridView dtgMedicineList;
        private System.Windows.Forms.GroupBox grpMedicineBuy;
        private System.Windows.Forms.Label lblMedicineBuyName;
        private System.Windows.Forms.TextBox txtMedicineBuyName;
        private System.Windows.Forms.NumericUpDown nmBuyCount;
        private System.Windows.Forms.Label lblMedicineCount;
        private System.Windows.Forms.Button btnMedicineBuy;
        private System.Windows.Forms.Button btnOrderMedicine;
        private System.Windows.Forms.Button button2;
    }
}