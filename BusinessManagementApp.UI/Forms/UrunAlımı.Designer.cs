namespace BusinessManagementApp.UI.Forms
{
    partial class UrunAlımı
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
            this.MoneyTypeCombobox = new System.Windows.Forms.ComboBox();
            this.SelectProductCombobox = new System.Windows.Forms.ComboBox();
            this.AddNewProduct_btn = new System.Windows.Forms.Button();
            this.AddProductOrder_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.TotalPrice_txt = new System.Windows.Forms.TextBox();
            this.UnitPrice_txt = new System.Windows.Forms.TextBox();
            this.SupplierName_txt = new System.Windows.Forms.TextBox();
            this.MoneyValues_txt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Amount_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductName_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MoneyTypeCombobox);
            this.groupBox1.Controls.Add(this.SelectProductCombobox);
            this.groupBox1.Controls.Add(this.AddNewProduct_btn);
            this.groupBox1.Controls.Add(this.AddProductOrder_btn);
            this.groupBox1.Controls.Add(this.return_btn);
            this.groupBox1.Controls.Add(this.TotalPrice_txt);
            this.groupBox1.Controls.Add(this.UnitPrice_txt);
            this.groupBox1.Controls.Add(this.SupplierName_txt);
            this.groupBox1.Controls.Add(this.MoneyValues_txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Amount_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ProductName_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 419);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Alım İşlemi";
            // 
            // MoneyTypeCombobox
            // 
            this.MoneyTypeCombobox.FormattingEnabled = true;
            this.MoneyTypeCombobox.Location = new System.Drawing.Point(696, 141);
            this.MoneyTypeCombobox.Name = "MoneyTypeCombobox";
            this.MoneyTypeCombobox.Size = new System.Drawing.Size(140, 28);
            this.MoneyTypeCombobox.TabIndex = 4;
            this.MoneyTypeCombobox.SelectionChangeCommitted += new System.EventHandler(this.MoneyTypeCombobox_SelectionChangeCommitted);
            // 
            // SelectProductCombobox
            // 
            this.SelectProductCombobox.FormattingEnabled = true;
            this.SelectProductCombobox.Location = new System.Drawing.Point(153, 47);
            this.SelectProductCombobox.Name = "SelectProductCombobox";
            this.SelectProductCombobox.Size = new System.Drawing.Size(176, 28);
            this.SelectProductCombobox.TabIndex = 4;
            this.SelectProductCombobox.SelectionChangeCommitted += new System.EventHandler(this.SelectProductCombobox_SelectionChangeCommitted);
            // 
            // AddNewProduct_btn
            // 
            this.AddNewProduct_btn.Location = new System.Drawing.Point(356, 41);
            this.AddNewProduct_btn.Name = "AddNewProduct_btn";
            this.AddNewProduct_btn.Size = new System.Drawing.Size(127, 38);
            this.AddNewProduct_btn.TabIndex = 3;
            this.AddNewProduct_btn.Text = "Yeni Ürün Ekle";
            this.AddNewProduct_btn.UseVisualStyleBackColor = true;
            this.AddNewProduct_btn.Click += new System.EventHandler(this.AddNewProduct_btn_Click);
            // 
            // AddProductOrder_btn
            // 
            this.AddProductOrder_btn.Location = new System.Drawing.Point(237, 355);
            this.AddProductOrder_btn.Name = "AddProductOrder_btn";
            this.AddProductOrder_btn.Size = new System.Drawing.Size(146, 47);
            this.AddProductOrder_btn.TabIndex = 3;
            this.AddProductOrder_btn.Text = "Alımı Tamamla";
            this.AddProductOrder_btn.UseVisualStyleBackColor = true;
            this.AddProductOrder_btn.Click += new System.EventHandler(this.AddProductOrder_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(491, 355);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(108, 47);
            this.return_btn.TabIndex = 3;
            this.return_btn.Text = "Geri Dön";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // TotalPrice_txt
            // 
            this.TotalPrice_txt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPrice_txt.Location = new System.Drawing.Point(561, 221);
            this.TotalPrice_txt.Multiline = true;
            this.TotalPrice_txt.Name = "TotalPrice_txt";
            this.TotalPrice_txt.Size = new System.Drawing.Size(221, 61);
            this.TotalPrice_txt.TabIndex = 1;
            // 
            // UnitPrice_txt
            // 
            this.UnitPrice_txt.Location = new System.Drawing.Point(696, 89);
            this.UnitPrice_txt.Name = "UnitPrice_txt";
            this.UnitPrice_txt.Size = new System.Drawing.Size(140, 27);
            this.UnitPrice_txt.TabIndex = 1;
            this.UnitPrice_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnitPrice_txt_KeyDown);
            this.UnitPrice_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitPrice_txt_KeyPress);
            // 
            // SupplierName_txt
            // 
            this.SupplierName_txt.Location = new System.Drawing.Point(153, 110);
            this.SupplierName_txt.Name = "SupplierName_txt";
            this.SupplierName_txt.Size = new System.Drawing.Size(140, 27);
            this.SupplierName_txt.TabIndex = 1;
            // 
            // MoneyValues_txt
            // 
            this.MoneyValues_txt.AutoSize = true;
            this.MoneyValues_txt.Location = new System.Drawing.Point(723, 179);
            this.MoneyValues_txt.Name = "MoneyValues_txt";
            this.MoneyValues_txt.Size = new System.Drawing.Size(86, 20);
            this.MoneyValues_txt.TabIndex = 0;
            this.MoneyValues_txt.Text = "Para Degeri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(321, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "Toplam Fiyat(TL)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Para Birimi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(395, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ürün düzenle bölümünden satış fiyatını düzenleyebilirsiniz.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(648, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Not : Varsayılan olarak ürünün satış fiyatı , birim alış fiyatının %25 karlı fiya" +
    "tı olarak belirlenmiştir. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Birim Fiyatı";
            // 
            // Amount_txt
            // 
            this.Amount_txt.Location = new System.Drawing.Point(158, 175);
            this.Amount_txt.Name = "Amount_txt";
            this.Amount_txt.Size = new System.Drawing.Size(140, 27);
            this.Amount_txt.TabIndex = 1;
            this.Amount_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Amount_txt_KeyDown);
            this.Amount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount_txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tedarikçi Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Miktar(Adet)";
            // 
            // ProductName_txt
            // 
            this.ProductName_txt.Location = new System.Drawing.Point(696, 37);
            this.ProductName_txt.Name = "ProductName_txt";
            this.ProductName_txt.Size = new System.Drawing.Size(140, 27);
            this.ProductName_txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıtlı Ürün Seç";
            // 
            // UrunAlımı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 443);
            this.Controls.Add(this.groupBox1);
            this.Name = "UrunAlımı";
            this.Text = "Ürün Alımı";
            this.Load += new System.EventHandler(this.UrunAlımı_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button return_btn;
        private TextBox UnitPrice_txt;
        private TextBox SupplierName_txt;
        private Label label4;
        private Label label2;
        private TextBox ProductName_txt;
        private Label label3;
        private Label label1;
        private Button AddProductOrder_btn;
        private Button AddNewProduct_btn;
        private TextBox TotalPrice_txt;
        private Label MoneyValues_txt;
        private Label label8;
        private Label label5;
        private TextBox Amount_txt;
        private Label label7;
        private Label label10;
        private Label label9;
        private ComboBox MoneyTypeCombobox;
        private ComboBox SelectProductCombobox;
    }
}