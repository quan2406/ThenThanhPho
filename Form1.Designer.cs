namespace TenThanhPho_TH2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbCountry = new System.Windows.Forms.GroupBox();
            this.rbMy = new System.Windows.Forms.RadioButton();
            this.rbPhap = new System.Windows.Forms.RadioButton();
            this.rbTQ = new System.Windows.Forms.RadioButton();
            this.rbNB = new System.Windows.Forms.RadioButton();
            this.rdVN = new System.Windows.Forms.RadioButton();
            this.grbCity = new System.Windows.Forms.GroupBox();
            this.rbWashington = new System.Windows.Forms.RadioButton();
            this.rbParis = new System.Windows.Forms.RadioButton();
            this.rbBK = new System.Windows.Forms.RadioButton();
            this.rbToKyo = new System.Windows.Forms.RadioButton();
            this.rbHN = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.grbCountry.SuspendLayout();
            this.grbCity.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCountry
            // 
            this.grbCountry.Controls.Add(this.rbMy);
            this.grbCountry.Controls.Add(this.rbPhap);
            this.grbCountry.Controls.Add(this.rbTQ);
            this.grbCountry.Controls.Add(this.rbNB);
            this.grbCountry.Controls.Add(this.rdVN);
            this.grbCountry.Location = new System.Drawing.Point(130, 61);
            this.grbCountry.Name = "grbCountry";
            this.grbCountry.Size = new System.Drawing.Size(250, 387);
            this.grbCountry.TabIndex = 0;
            this.grbCountry.TabStop = false;
            this.grbCountry.Text = "Country";
            // 
            // rbMy
            // 
            this.rbMy.AutoSize = true;
            this.rbMy.Location = new System.Drawing.Point(57, 357);
            this.rbMy.Name = "rbMy";
            this.rbMy.Size = new System.Drawing.Size(50, 24);
            this.rbMy.TabIndex = 4;
            this.rbMy.TabStop = true;
            this.rbMy.Text = "My";
            this.rbMy.UseVisualStyleBackColor = true;
            this.rbMy.CheckedChanged += new System.EventHandler(this.rbMy_CheckedChanged);
            // 
            // rbPhap
            // 
            this.rbPhap.AutoSize = true;
            this.rbPhap.Location = new System.Drawing.Point(57, 284);
            this.rbPhap.Name = "rbPhap";
            this.rbPhap.Size = new System.Drawing.Size(63, 24);
            this.rbPhap.TabIndex = 3;
            this.rbPhap.TabStop = true;
            this.rbPhap.Text = "Phap";
            this.rbPhap.UseVisualStyleBackColor = true;
            this.rbPhap.CheckedChanged += new System.EventHandler(this.rbPhap_CheckedChanged);
            // 
            // rbTQ
            // 
            this.rbTQ.AutoSize = true;
            this.rbTQ.Location = new System.Drawing.Point(57, 207);
            this.rbTQ.Name = "rbTQ";
            this.rbTQ.Size = new System.Drawing.Size(106, 24);
            this.rbTQ.TabIndex = 2;
            this.rbTQ.TabStop = true;
            this.rbTQ.Text = "Trung Quoc";
            this.rbTQ.UseVisualStyleBackColor = true;
            this.rbTQ.CheckedChanged += new System.EventHandler(this.rbTQ_CheckedChanged);
            // 
            // rbNB
            // 
            this.rbNB.AutoSize = true;
            this.rbNB.Location = new System.Drawing.Point(57, 127);
            this.rbNB.Name = "rbNB";
            this.rbNB.Size = new System.Drawing.Size(91, 24);
            this.rbNB.TabIndex = 1;
            this.rbNB.TabStop = true;
            this.rbNB.Text = "Nhat Ban";
            this.rbNB.UseVisualStyleBackColor = true;
            this.rbNB.CheckedChanged += new System.EventHandler(this.rbNB_CheckedChanged);
            // 
            // rdVN
            // 
            this.rdVN.AutoSize = true;
            this.rdVN.Location = new System.Drawing.Point(57, 47);
            this.rdVN.Name = "rdVN";
            this.rdVN.Size = new System.Drawing.Size(92, 24);
            this.rdVN.TabIndex = 0;
            this.rdVN.TabStop = true;
            this.rdVN.Text = "Viet Nam";
            this.rdVN.UseVisualStyleBackColor = true;
            this.rdVN.CheckedChanged += new System.EventHandler(this.rdVN_CheckedChanged);
            // 
            // grbCity
            // 
            this.grbCity.Controls.Add(this.rbWashington);
            this.grbCity.Controls.Add(this.rbParis);
            this.grbCity.Controls.Add(this.rbBK);
            this.grbCity.Controls.Add(this.rbToKyo);
            this.grbCity.Controls.Add(this.rbHN);
            this.grbCity.Location = new System.Drawing.Point(488, 61);
            this.grbCity.Name = "grbCity";
            this.grbCity.Size = new System.Drawing.Size(250, 387);
            this.grbCity.TabIndex = 1;
            this.grbCity.TabStop = false;
            this.grbCity.Text = "City";
            // 
            // rbWashington
            // 
            this.rbWashington.AutoSize = true;
            this.rbWashington.Location = new System.Drawing.Point(67, 357);
            this.rbWashington.Name = "rbWashington";
            this.rbWashington.Size = new System.Drawing.Size(108, 24);
            this.rbWashington.TabIndex = 5;
            this.rbWashington.TabStop = true;
            this.rbWashington.Text = "Washington";
            this.rbWashington.UseVisualStyleBackColor = true;
            this.rbWashington.CheckedChanged += new System.EventHandler(this.rbWashington_CheckedChanged);
            // 
            // rbParis
            // 
            this.rbParis.AutoSize = true;
            this.rbParis.Location = new System.Drawing.Point(67, 284);
            this.rbParis.Name = "rbParis";
            this.rbParis.Size = new System.Drawing.Size(60, 24);
            this.rbParis.TabIndex = 4;
            this.rbParis.TabStop = true;
            this.rbParis.Text = "Paris";
            this.rbParis.UseVisualStyleBackColor = true;
            this.rbParis.CheckedChanged += new System.EventHandler(this.rbParis_CheckedChanged);
            // 
            // rbBK
            // 
            this.rbBK.AutoSize = true;
            this.rbBK.Location = new System.Drawing.Point(67, 207);
            this.rbBK.Name = "rbBK";
            this.rbBK.Size = new System.Drawing.Size(87, 24);
            this.rbBK.TabIndex = 3;
            this.rbBK.TabStop = true;
            this.rbBK.Text = "Bac Kinh";
            this.rbBK.UseVisualStyleBackColor = true;
            this.rbBK.CheckedChanged += new System.EventHandler(this.rbBK_CheckedChanged);
            // 
            // rbToKyo
            // 
            this.rbToKyo.AutoSize = true;
            this.rbToKyo.Location = new System.Drawing.Point(67, 127);
            this.rbToKyo.Name = "rbToKyo";
            this.rbToKyo.Size = new System.Drawing.Size(69, 24);
            this.rbToKyo.TabIndex = 2;
            this.rbToKyo.TabStop = true;
            this.rbToKyo.Text = "Tokyo";
            this.rbToKyo.UseVisualStyleBackColor = true;
            this.rbToKyo.CheckedChanged += new System.EventHandler(this.rbToKyo_CheckedChanged);
            // 
            // rbHN
            // 
            this.rbHN.AutoSize = true;
            this.rbHN.Location = new System.Drawing.Point(67, 47);
            this.rbHN.Name = "rbHN";
            this.rbHN.Size = new System.Drawing.Size(77, 24);
            this.rbHN.TabIndex = 1;
            this.rbHN.TabStop = true;
            this.rbHN.Text = "Ha Noi";
            this.rbHN.UseVisualStyleBackColor = true;
            this.rbHN.CheckedChanged += new System.EventHandler(this.rbHN_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(623, 482);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(93, 500);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 20);
            this.lb.TabIndex = 3;
            this.lb.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 549);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbCity);
            this.Controls.Add(this.grbCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbCountry.ResumeLayout(false);
            this.grbCountry.PerformLayout();
            this.grbCity.ResumeLayout(false);
            this.grbCity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grbCountry;
        private RadioButton rbMy;
        private RadioButton rbPhap;
        private RadioButton rbTQ;
        private RadioButton rbNB;
        private RadioButton rdVN;
        private GroupBox grbCity;
        private RadioButton rbWashington;
        private RadioButton rbParis;
        private RadioButton rbBK;
        private RadioButton rbToKyo;
        private RadioButton rbHN;
        private Button btnExit;
        private Label lb;
    }
}