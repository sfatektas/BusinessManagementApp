namespace BusinessManagementApp.UI.Forms
{
    partial class MusteriEkle
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
            this.comboBoxAdd_customerTypes = new System.Windows.Forms.ComboBox();
            this.Close_btn = new System.Windows.Forms.Button();
            this.CustomerAdd_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailAdd_txt = new System.Windows.Forms.TextBox();
            this.companyNameAdd_txt = new System.Windows.Forms.TextBox();
            this.TaxNoAdd_txt = new System.Windows.Forms.TextBox();
            this.CominicationNameAdd_txt = new System.Windows.Forms.TextBox();
            this.TelNoAdd_txt = new System.Windows.Forms.TextBox();
            this.TradeRegisterNoAdd_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAdd_customerTypes);
            this.groupBox1.Controls.Add(this.Close_btn);
            this.groupBox1.Controls.Add(this.CustomerAdd_btn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EmailAdd_txt);
            this.groupBox1.Controls.Add(this.companyNameAdd_txt);
            this.groupBox1.Controls.Add(this.TaxNoAdd_txt);
            this.groupBox1.Controls.Add(this.CominicationNameAdd_txt);
            this.groupBox1.Controls.Add(this.TelNoAdd_txt);
            this.groupBox1.Controls.Add(this.TradeRegisterNoAdd_txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 264);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Ekle";
            // 
            // comboBoxAdd_customerTypes
            // 
            this.comboBoxAdd_customerTypes.FormattingEnabled = true;
            this.comboBoxAdd_customerTypes.Location = new System.Drawing.Point(165, 45);
            this.comboBoxAdd_customerTypes.Name = "comboBoxAdd_customerTypes";
            this.comboBoxAdd_customerTypes.Size = new System.Drawing.Size(135, 28);
            this.comboBoxAdd_customerTypes.TabIndex = 3;
            this.comboBoxAdd_customerTypes.SelectionChangeCommitted += new System.EventHandler(this.comboBoxAdd_customerTypes_SelectionChangeCommitted);
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(499, 211);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(108, 35);
            this.Close_btn.TabIndex = 2;
            this.Close_btn.Text = "Vazgeç";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // CustomerAdd_btn
            // 
            this.CustomerAdd_btn.Location = new System.Drawing.Point(357, 211);
            this.CustomerAdd_btn.Name = "CustomerAdd_btn";
            this.CustomerAdd_btn.Size = new System.Drawing.Size(108, 35);
            this.CustomerAdd_btn.TabIndex = 2;
            this.CustomerAdd_btn.Text = "Ekle";
            this.CustomerAdd_btn.UseVisualStyleBackColor = true;
            this.CustomerAdd_btn.Click += new System.EventHandler(this.CustomerAdd_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "TelNo ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "İletişim Kurulacak Kişi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sicil No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "VergiNo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şirket Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Türü";
            // 
            // EmailAdd_txt
            // 
            this.EmailAdd_txt.Location = new System.Drawing.Point(175, 192);
            this.EmailAdd_txt.Name = "EmailAdd_txt";
            this.EmailAdd_txt.Size = new System.Drawing.Size(125, 27);
            this.EmailAdd_txt.TabIndex = 0;
            // 
            // companyNameAdd_txt
            // 
            this.companyNameAdd_txt.Location = new System.Drawing.Point(482, 45);
            this.companyNameAdd_txt.Name = "companyNameAdd_txt";
            this.companyNameAdd_txt.Size = new System.Drawing.Size(125, 27);
            this.companyNameAdd_txt.TabIndex = 0;
            // 
            // TaxNoAdd_txt
            // 
            this.TaxNoAdd_txt.Location = new System.Drawing.Point(481, 89);
            this.TaxNoAdd_txt.Name = "TaxNoAdd_txt";
            this.TaxNoAdd_txt.Size = new System.Drawing.Size(125, 27);
            this.TaxNoAdd_txt.TabIndex = 0;
            // 
            // CominicationNameAdd_txt
            // 
            this.CominicationNameAdd_txt.Location = new System.Drawing.Point(175, 93);
            this.CominicationNameAdd_txt.Name = "CominicationNameAdd_txt";
            this.CominicationNameAdd_txt.Size = new System.Drawing.Size(125, 27);
            this.CominicationNameAdd_txt.TabIndex = 0;
            // 
            // TelNoAdd_txt
            // 
            this.TelNoAdd_txt.Location = new System.Drawing.Point(175, 145);
            this.TelNoAdd_txt.Name = "TelNoAdd_txt";
            this.TelNoAdd_txt.Size = new System.Drawing.Size(125, 27);
            this.TelNoAdd_txt.TabIndex = 0;
            // 
            // TradeRegisterNoAdd_txt
            // 
            this.TradeRegisterNoAdd_txt.Location = new System.Drawing.Point(481, 148);
            this.TradeRegisterNoAdd_txt.Name = "TradeRegisterNoAdd_txt";
            this.TradeRegisterNoAdd_txt.Size = new System.Drawing.Size(125, 27);
            this.TradeRegisterNoAdd_txt.TabIndex = 0;
            // 
            // MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 284);
            this.Controls.Add(this.groupBox1);
            this.Name = "MusteriEkle";
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.MusteriEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBoxAdd_customerTypes;
        private Button CustomerAdd_btn;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private TextBox EmailAdd_txt;
        private TextBox companyNameAdd_txt;
        private TextBox TaxNoAdd_txt;
        private TextBox CominicationNameAdd_txt;
        private TextBox TelNoAdd_txt;
        private TextBox TradeRegisterNoAdd_txt;
        private Button Close_btn;
    }
}