namespace BusinessManagementApp.UI.Forms
{
    partial class DepodakiUrunDetay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UrunAdı_txt = new System.Windows.Forms.Label();
            this.Meşei_txt = new System.Windows.Forms.Label();
            this.Tedarikci_txt = new System.Windows.Forms.Label();
            this.SatısFiyatı_txt = new System.Windows.Forms.Label();
            this.StokAdedi_txt = new System.Windows.Forms.Label();
            this.close_BTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menşei :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tedarikçi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Satış Fiyatı(TL) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Stok Adedi :";
            // 
            // UrunAdı_txt
            // 
            this.UrunAdı_txt.AutoSize = true;
            this.UrunAdı_txt.Location = new System.Drawing.Point(131, 38);
            this.UrunAdı_txt.Name = "UrunAdı_txt";
            this.UrunAdı_txt.Size = new System.Drawing.Size(86, 20);
            this.UrunAdı_txt.TabIndex = 0;
            this.UrunAdı_txt.Text = "UrunAdı_txt";
            // 
            // Meşei_txt
            // 
            this.Meşei_txt.AutoSize = true;
            this.Meşei_txt.Location = new System.Drawing.Point(131, 100);
            this.Meşei_txt.Name = "Meşei_txt";
            this.Meşei_txt.Size = new System.Drawing.Size(50, 20);
            this.Meşei_txt.TabIndex = 0;
            this.Meşei_txt.Text = "label1";
            this.Meşei_txt.Click += new System.EventHandler(this.label2_Click);
            // 
            // Tedarikci_txt
            // 
            this.Tedarikci_txt.AutoSize = true;
            this.Tedarikci_txt.Location = new System.Drawing.Point(131, 177);
            this.Tedarikci_txt.Name = "Tedarikci_txt";
            this.Tedarikci_txt.Size = new System.Drawing.Size(50, 20);
            this.Tedarikci_txt.TabIndex = 0;
            this.Tedarikci_txt.Text = "label1";
            this.Tedarikci_txt.Click += new System.EventHandler(this.label2_Click);
            // 
            // SatısFiyatı_txt
            // 
            this.SatısFiyatı_txt.AutoSize = true;
            this.SatısFiyatı_txt.Location = new System.Drawing.Point(468, 38);
            this.SatısFiyatı_txt.Name = "SatısFiyatı_txt";
            this.SatısFiyatı_txt.Size = new System.Drawing.Size(79, 20);
            this.SatısFiyatı_txt.TabIndex = 0;
            this.SatısFiyatı_txt.Text = "Satış Fiyatı";
            // 
            // StokAdedi_txt
            // 
            this.StokAdedi_txt.AutoSize = true;
            this.StokAdedi_txt.Location = new System.Drawing.Point(465, 109);
            this.StokAdedi_txt.Name = "StokAdedi_txt";
            this.StokAdedi_txt.Size = new System.Drawing.Size(82, 20);
            this.StokAdedi_txt.TabIndex = 0;
            this.StokAdedi_txt.Text = "Stok Adedi";
            // 
            // close_BTN
            // 
            this.close_BTN.Location = new System.Drawing.Point(294, 177);
            this.close_BTN.Name = "close_BTN";
            this.close_BTN.Size = new System.Drawing.Size(132, 53);
            this.close_BTN.TabIndex = 1;
            this.close_BTN.Text = "Kapat";
            this.close_BTN.UseVisualStyleBackColor = true;
            this.close_BTN.Click += new System.EventHandler(this.close_BTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.close_BTN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StokAdedi_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SatısFiyatı_txt);
            this.groupBox1.Controls.Add(this.Tedarikci_txt);
            this.groupBox1.Controls.Add(this.UrunAdı_txt);
            this.groupBox1.Controls.Add(this.Meşei_txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 240);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // DepodakiUrunDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "DepodakiUrunDetay";
            this.Text = "Ürün Detay";
            this.Load += new System.EventHandler(this.DepodakiUrunDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label UrunAdı_txt;
        private Label Meşei_txt;
        private Label Tedarikci_txt;
        private Label SatısFiyatı_txt;
        private Label StokAdedi_txt;
        private Button close_BTN;
        private GroupBox groupBox1;
    }
}