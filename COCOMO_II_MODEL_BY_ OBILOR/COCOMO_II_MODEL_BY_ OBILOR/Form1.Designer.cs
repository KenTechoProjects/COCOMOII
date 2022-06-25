namespace COCOMO_II_MODEL_BY__OBILOR
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCostDriver = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CDEM = new System.Windows.Forms.TextBox();
            this.cmbIndividualCD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CDRatings = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.A = new System.Windows.Forms.ComboBox();
            this.cmbProjectType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labeB = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbConstantProjetcType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbRatingProjectType = new System.Windows.Forms.ComboBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnProjecttypes = new DevExpress.XtraEditors.SimpleButton();
            this.btnProjetcSize = new DevExpress.XtraEditors.SimpleButton();
            this.btnCostDriver = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCostDriver);
            this.groupBox1.Controls.Add(this.cmbCostDriver);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COCOMO II Factors  (1)";
            // 
            // cmbCostDriver
            // 
            this.cmbCostDriver.FormattingEnabled = true;
            this.cmbCostDriver.Items.AddRange(new object[] {
            "RELLY",
            "DATA",
            "RUSE",
            "DOCU",
            "TIME",
            "STOR",
            "PVOL",
            "ACAP",
            "PCAP",
            "PCON",
            "APEX",
            "PLEX",
            "LTEX",
            "TOOL",
            "SITE",
            "SCED",
            "CPLX"});
            this.cmbCostDriver.Location = new System.Drawing.Point(6, 72);
            this.cmbCostDriver.Name = "cmbCostDriver";
            this.cmbCostDriver.Size = new System.Drawing.Size(243, 21);
            this.cmbCostDriver.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cost Driver";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CDEM);
            this.groupBox2.Controls.Add(this.cmbIndividualCD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.CDRatings);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(375, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 167);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Individual Cost Drivers  (2)";
            // 
            // CDEM
            // 
            this.CDEM.Location = new System.Drawing.Point(150, 115);
            this.CDEM.Name = "CDEM";
            this.CDEM.Size = new System.Drawing.Size(100, 20);
            this.CDEM.TabIndex = 3;
            // 
            // cmbIndividualCD
            // 
            this.cmbIndividualCD.FormattingEnabled = true;
            this.cmbIndividualCD.Items.AddRange(new object[] {
            "RELLY",
            "DATA",
            "RUSE",
            "DOCU",
            "TIME",
            "STOR",
            "PVOL",
            "ACAP",
            "PCAP",
            "PCON",
            "APEX",
            "PLEX",
            "LTEX",
            "TOOL",
            "SITE",
            "SCED",
            "CPLX"});
            this.cmbIndividualCD.Location = new System.Drawing.Point(6, 41);
            this.cmbIndividualCD.Name = "cmbIndividualCD";
            this.cmbIndividualCD.Size = new System.Drawing.Size(244, 21);
            this.cmbIndividualCD.TabIndex = 1;
            this.cmbIndividualCD.SelectedValueChanged += new System.EventHandler(this.cmbIndividualCD_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cost Driver";
            // 
            // CDRatings
            // 
            this.CDRatings.FormattingEnabled = true;
            this.CDRatings.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Norminal",
            "High",
            "Very High",
            "Extra High"});
            this.CDRatings.Location = new System.Drawing.Point(5, 114);
            this.CDRatings.Name = "CDRatings";
            this.CDRatings.Size = new System.Drawing.Size(121, 21);
            this.CDRatings.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "EM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rating";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(782, 290);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Project Type (3)";
            // 
            // A
            // 
            this.A.FormattingEnabled = true;
            this.A.Items.AddRange(new object[] {
            "2.94",
            "3.0",
            "3.67"});
            this.A.Location = new System.Drawing.Point(11, 122);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(67, 21);
            this.A.TabIndex = 1;
            // 
            // cmbProjectType
            // 
            this.cmbProjectType.FormattingEnabled = true;
            this.cmbProjectType.Items.AddRange(new object[] {
            "Organic",
            "Semi-Detatched",
            "Embedded"});
            this.cmbProjectType.Location = new System.Drawing.Point(110, 26);
            this.cmbProjectType.Name = "cmbProjectType";
            this.cmbProjectType.Size = new System.Drawing.Size(411, 21);
            this.cmbProjectType.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "A";
            // 
            // labeB
            // 
            this.labeB.AutoSize = true;
            this.labeB.Location = new System.Drawing.Point(115, 106);
            this.labeB.Name = "labeB";
            this.labeB.Size = new System.Drawing.Size(14, 13);
            this.labeB.TabIndex = 0;
            this.labeB.Text = "B";
            // 
            // B
            // 
            this.B.FormattingEnabled = true;
            this.B.Items.AddRange(new object[] {
            "1.05",
            "1.12",
            "1.20"});
            this.B.Location = new System.Drawing.Point(94, 122);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(67, 21);
            this.B.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "C";
            // 
            // C
            // 
            this.C.FormattingEnabled = true;
            this.C.Items.AddRange(new object[] {
            "2.5",
            "2.5",
            "2.5"});
            this.C.Location = new System.Drawing.Point(231, 122);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(67, 21);
            this.C.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "D";
            // 
            // D
            // 
            this.D.FormattingEnabled = true;
            this.D.Items.AddRange(new object[] {
            "0.38",
            "0.35",
            "0.32"});
            this.D.Location = new System.Drawing.Point(334, 122);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(67, 21);
            this.D.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.cmbProjectType);
            this.groupBox4.Controls.Add(this.btnProjecttypes);
            this.groupBox4.Location = new System.Drawing.Point(170, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(593, 64);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "(3A)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Project Type";
            // 
            // cmbConstantProjetcType
            // 
            this.cmbConstantProjetcType.FormattingEnabled = true;
            this.cmbConstantProjetcType.Items.AddRange(new object[] {
            " "});
            this.cmbConstantProjetcType.Location = new System.Drawing.Point(11, 53);
            this.cmbConstantProjetcType.Name = "cmbConstantProjetcType";
            this.cmbConstantProjetcType.Size = new System.Drawing.Size(214, 21);
            this.cmbConstantProjetcType.TabIndex = 1;
            this.cmbConstantProjetcType.SelectedValueChanged += new System.EventHandler(this.cmbConstantProjetcType_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Rating";
            // 
            // cmbRatingProjectType
            // 
            this.cmbRatingProjectType.FormattingEnabled = true;
            this.cmbRatingProjectType.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbRatingProjectType.Location = new System.Drawing.Point(279, 53);
            this.cmbRatingProjectType.Name = "cmbRatingProjectType";
            this.cmbRatingProjectType.Size = new System.Drawing.Size(121, 21);
            this.cmbRatingProjectType.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(304, 110);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(38, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Rating";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::COCOMO_II_MODEL_BY__OBILOR.Properties.Resources.exportmodeldifferences_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(376, 126);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(42, 37);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.btnCostDriverRating_Click);
            // 
            // btnProjecttypes
            // 
            this.btnProjecttypes.ImageOptions.Image = global::COCOMO_II_MODEL_BY__OBILOR.Properties.Resources.exportmodeldifferences_32x32;
            this.btnProjecttypes.Location = new System.Drawing.Point(550, 17);
            this.btnProjecttypes.Name = "btnProjecttypes";
            this.btnProjecttypes.Size = new System.Drawing.Size(42, 37);
            this.btnProjecttypes.TabIndex = 2;
            this.btnProjecttypes.Text = "simpleButton1";
            this.btnProjecttypes.Click += new System.EventHandler(this.btnProjecttypes_Click);
            // 
            // btnProjetcSize
            // 
            this.btnProjetcSize.ImageOptions.Image = global::COCOMO_II_MODEL_BY__OBILOR.Properties.Resources.exportmodeldifferences_32x32;
            this.btnProjetcSize.Location = new System.Drawing.Point(737, 110);
            this.btnProjetcSize.Name = "btnProjetcSize";
            this.btnProjetcSize.Size = new System.Drawing.Size(42, 37);
            this.btnProjetcSize.TabIndex = 2;
            this.btnProjetcSize.Text = "simpleButton1";
            this.btnProjetcSize.Click += new System.EventHandler(this.btnProjetcSize_Click);
            // 
            // btnCostDriver
            // 
            this.btnCostDriver.ImageOptions.Image = global::COCOMO_II_MODEL_BY__OBILOR.Properties.Resources.exportmodeldifferences_32x32;
            this.btnCostDriver.Location = new System.Drawing.Point(212, 126);
            this.btnCostDriver.Name = "btnCostDriver";
            this.btnCostDriver.Size = new System.Drawing.Size(42, 37);
            this.btnCostDriver.TabIndex = 2;
            this.btnCostDriver.Text = "simpleButton1";
            this.btnCostDriver.Click += new System.EventHandler(this.btnCostDriver_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox5.Controls.Add(this.C);
            this.groupBox5.Controls.Add(this.cmbConstantProjetcType);
            this.groupBox5.Controls.Add(this.btnProjetcSize);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.labeB);
            this.groupBox5.Controls.Add(this.A);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cmbRatingProjectType);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.B);
            this.groupBox5.Controls.Add(this.D);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(1, 141);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(781, 149);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Constant Vlaues (3B)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(807, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnCostDriver;
        private System.Windows.Forms.ComboBox cmbCostDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CDEM;
        private System.Windows.Forms.ComboBox cmbIndividualCD;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox CDRatings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnProjetcSize;
        private System.Windows.Forms.ComboBox A;
        private System.Windows.Forms.ComboBox cmbProjectType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox D;
        private System.Windows.Forms.ComboBox C;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox B;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labeB;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.SimpleButton btnProjecttypes;
        private System.Windows.Forms.ComboBox cmbConstantProjetcType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbRatingProjectType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

