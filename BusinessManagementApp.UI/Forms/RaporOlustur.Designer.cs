namespace BusinessManagementApp.UI.Forms
{
    partial class RaporOlustur
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
            this.ReportType_cbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerange_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createReport_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.productFind_btn = new System.Windows.Forms.Button();
            this.ProductFind_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productSelect_cbx = new System.Windows.Forms.ComboBox();
            this.SelectedProduct_txt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.customerSelect_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.productGroupBox.SuspendLayout();
            this.CustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportType_cbx
            // 
            this.ReportType_cbx.FormattingEnabled = true;
            this.ReportType_cbx.Location = new System.Drawing.Point(134, 58);
            this.ReportType_cbx.Name = "ReportType_cbx";
            this.ReportType_cbx.Size = new System.Drawing.Size(182, 28);
            this.ReportType_cbx.TabIndex = 0;
            this.ReportType_cbx.SelectionChangeCommitted += new System.EventHandler(this.ReportType_cbx_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rapor Türü ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zaman Aralığı";
            // 
            // timerange_cbx
            // 
            this.timerange_cbx.FormattingEnabled = true;
            this.timerange_cbx.Location = new System.Drawing.Point(432, 348);
            this.timerange_cbx.Name = "timerange_cbx";
            this.timerange_cbx.Size = new System.Drawing.Size(151, 28);
            this.timerange_cbx.TabIndex = 0;
            this.timerange_cbx.SelectionChangeCommitted += new System.EventHandler(this.timerange_cbx_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ReportType_cbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 149);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rapor Türü Seç";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(567, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Genel Rapor: İlgili zaman aralığında alınan , satılan ürünleri ve ciro verilerini" +
    " raporlar.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(588, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ürün Bazlı : İlgili zaman aralığında seçilen ürüne ait alım ,satım ve ciro verile" +
    "rini raporlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(575, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Müşteri Bazlı : İlgili zaman aralığında seçilen müşteriye ait ürün alım verilerin" +
    "i raporlar";
            // 
            // createReport_btn
            // 
            this.createReport_btn.Location = new System.Drawing.Point(325, 401);
            this.createReport_btn.Name = "createReport_btn";
            this.createReport_btn.Size = new System.Drawing.Size(119, 42);
            this.createReport_btn.TabIndex = 4;
            this.createReport_btn.Text = "Rapor Oluştur";
            this.createReport_btn.UseVisualStyleBackColor = true;
            this.createReport_btn.Click += new System.EventHandler(this.createReport_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(533, 401);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(119, 42);
            this.return_btn.TabIndex = 4;
            this.return_btn.Text = "Geri Dön";
            this.return_btn.UseVisualStyleBackColor = true;
            // 
            // productGroupBox
            // 
            this.productGroupBox.Controls.Add(this.productFind_btn);
            this.productGroupBox.Controls.Add(this.ProductFind_txt);
            this.productGroupBox.Controls.Add(this.label7);
            this.productGroupBox.Controls.Add(this.label3);
            this.productGroupBox.Controls.Add(this.productSelect_cbx);
            this.productGroupBox.Controls.Add(this.SelectedProduct_txt);
            this.productGroupBox.Controls.Add(this.label8);
            this.productGroupBox.Location = new System.Drawing.Point(12, 167);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Size = new System.Drawing.Size(475, 149);
            this.productGroupBox.TabIndex = 5;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Ürün Seç";
            // 
            // productFind_btn
            // 
            this.productFind_btn.Location = new System.Drawing.Point(347, 68);
            this.productFind_btn.Name = "productFind_btn";
            this.productFind_btn.Size = new System.Drawing.Size(94, 29);
            this.productFind_btn.TabIndex = 2;
            this.productFind_btn.Text = "Bul";
            this.productFind_btn.UseVisualStyleBackColor = true;
            // 
            // ProductFind_txt
            // 
            this.ProductFind_txt.Location = new System.Drawing.Point(332, 25);
            this.ProductFind_txt.Name = "ProductFind_txt";
            this.ProductFind_txt.Size = new System.Drawing.Size(125, 27);
            this.ProductFind_txt.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Seç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün ID";
            // 
            // productSelect_cbx
            // 
            this.productSelect_cbx.FormattingEnabled = true;
            this.productSelect_cbx.Location = new System.Drawing.Point(90, 29);
            this.productSelect_cbx.Name = "productSelect_cbx";
            this.productSelect_cbx.Size = new System.Drawing.Size(127, 28);
            this.productSelect_cbx.TabIndex = 0;
            this.productSelect_cbx.SelectionChangeCommitted += new System.EventHandler(this.productSelect_cbx_SelectionChangeCommitted);
            // 
            // SelectedProduct_txt
            // 
            this.SelectedProduct_txt.AutoSize = true;
            this.SelectedProduct_txt.Location = new System.Drawing.Point(173, 101);
            this.SelectedProduct_txt.Name = "SelectedProduct_txt";
            this.SelectedProduct_txt.Size = new System.Drawing.Size(21, 20);
            this.SelectedProduct_txt.TabIndex = 1;
            this.SelectedProduct_txt.Text = "....";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Seçilen Ürün Adı:";
            // 
            // CustomerGroupBox
            // 
            this.CustomerGroupBox.Controls.Add(this.button3);
            this.CustomerGroupBox.Controls.Add(this.textBox2);
            this.CustomerGroupBox.Controls.Add(this.label9);
            this.CustomerGroupBox.Controls.Add(this.label12);
            this.CustomerGroupBox.Controls.Add(this.label10);
            this.CustomerGroupBox.Controls.Add(this.label11);
            this.CustomerGroupBox.Controls.Add(this.customerSelect_cbx);
            this.CustomerGroupBox.Location = new System.Drawing.Point(493, 167);
            this.CustomerGroupBox.Name = "CustomerGroupBox";
            this.CustomerGroupBox.Size = new System.Drawing.Size(475, 149);
            this.CustomerGroupBox.TabIndex = 5;
            this.CustomerGroupBox.TabStop = false;
            this.CustomerGroupBox.Text = "Müşteri Seç";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Bul";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(332, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Seçilen Müşteri Adı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Seç";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "....";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(240, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Müşteri ID";
            // 
            // customerSelect_cbx
            // 
            this.customerSelect_cbx.FormattingEnabled = true;
            this.customerSelect_cbx.Location = new System.Drawing.Point(90, 29);
            this.customerSelect_cbx.Name = "customerSelect_cbx";
            this.customerSelect_cbx.Size = new System.Drawing.Size(127, 28);
            this.customerSelect_cbx.TabIndex = 0;
            this.customerSelect_cbx.SelectionChangeCommitted += new System.EventHandler(this.customerSelect_cbx_SelectionChangeCommitted);
            // 
            // RaporOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 470);
            this.Controls.Add(this.CustomerGroupBox);
            this.Controls.Add(this.productGroupBox);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.createReport_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timerange_cbx);
            this.Name = "RaporOlustur";
            this.Text = "Rapor Oluştur";
            this.Load += new System.EventHandler(this.RaporOlustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            this.CustomerGroupBox.ResumeLayout(false);
            this.CustomerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ReportType_cbx;
        private Label label1;
        private Label label2;
        private ComboBox timerange_cbx;
        private GroupBox groupBox1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button createReport_btn;
        private Button return_btn;
        private GroupBox productGroupBox;
        private Button productFind_btn;
        private TextBox ProductFind_txt;
        private Label label7;
        private Label label3;
        private ComboBox productSelect_cbx;
        private Label SelectedProduct_txt;
        private Label label8;
        private GroupBox CustomerGroupBox;
        private Button button3;
        private TextBox textBox2;
        private Label label9;
        private Label label12;
        private Label label10;
        private Label label11;
        private ComboBox customerSelect_cbx;
    }
}