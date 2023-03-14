namespace BusinessManagementApp.UI.Forms
{
    partial class UrunSat
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
            this.SelectCustomerCombobox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FindProduct_txt = new System.Windows.Forms.TextBox();
            this.SelectProductCombobox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Find_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateProductUnitPrice_btn = new System.Windows.Forms.Button();
            this.AddNewCustomer_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.PreOrder_btn = new System.Windows.Forms.Button();
            this.ComplateOrder_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.TotalPrice_txt = new System.Windows.Forms.TextBox();
            this.UnitPrice_txt = new System.Windows.Forms.TextBox();
            this.Amount_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UnitTotalPrice_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KdvPrice_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductName_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectCustomerCombobox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.UpdateProductUnitPrice_btn);
            this.groupBox1.Controls.Add(this.AddNewCustomer_btn);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.PreOrder_btn);
            this.groupBox1.Controls.Add(this.ComplateOrder_btn);
            this.groupBox1.Controls.Add(this.return_btn);
            this.groupBox1.Controls.Add(this.TotalPrice_txt);
            this.groupBox1.Controls.Add(this.UnitPrice_txt);
            this.groupBox1.Controls.Add(this.Amount_txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AmountLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.UnitTotalPrice_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.KdvPrice_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ProductName_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 563);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Satım İşlemi";
            // 
            // SelectCustomerCombobox
            // 
            this.SelectCustomerCombobox.DropDownHeight = 150;
            this.SelectCustomerCombobox.FormattingEnabled = true;
            this.SelectCustomerCombobox.IntegralHeight = false;
            this.SelectCustomerCombobox.Location = new System.Drawing.Point(124, 172);
            this.SelectCustomerCombobox.Name = "SelectCustomerCombobox";
            this.SelectCustomerCombobox.Size = new System.Drawing.Size(173, 28);
            this.SelectCustomerCombobox.TabIndex = 5;
            this.SelectCustomerCombobox.SelectionChangeCommitted += new System.EventHandler(this.SelectCustomerCombobox_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FindProduct_txt);
            this.groupBox2.Controls.Add(this.SelectProductCombobox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Find_btn);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(27, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 125);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seç";
            // 
            // FindProduct_txt
            // 
            this.FindProduct_txt.Location = new System.Drawing.Point(467, 29);
            this.FindProduct_txt.Name = "FindProduct_txt";
            this.FindProduct_txt.Size = new System.Drawing.Size(140, 27);
            this.FindProduct_txt.TabIndex = 6;
            this.FindProduct_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FindProduct_txt_KeyPress);
            // 
            // SelectProductCombobox
            // 
            this.SelectProductCombobox.FormattingEnabled = true;
            this.SelectProductCombobox.Location = new System.Drawing.Point(101, 26);
            this.SelectProductCombobox.Name = "SelectProductCombobox";
            this.SelectProductCombobox.Size = new System.Drawing.Size(140, 28);
            this.SelectProductCombobox.TabIndex = 5;
            this.SelectProductCombobox.SelectionChangeCommitted += new System.EventHandler(this.SelectProductCombobox_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Not : QR ile de okutabilirsiniz.";
            // 
            // Find_btn
            // 
            this.Find_btn.Location = new System.Drawing.Point(627, 27);
            this.Find_btn.Name = "Find_btn";
            this.Find_btn.Size = new System.Drawing.Size(91, 29);
            this.Find_btn.TabIndex = 3;
            this.Find_btn.Text = "Bul";
            this.Find_btn.UseVisualStyleBackColor = true;
            this.Find_btn.Click += new System.EventHandler(this.Find_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ürün ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Seç";
            // 
            // UpdateProductUnitPrice_btn
            // 
            this.UpdateProductUnitPrice_btn.Location = new System.Drawing.Point(616, 182);
            this.UpdateProductUnitPrice_btn.Name = "UpdateProductUnitPrice_btn";
            this.UpdateProductUnitPrice_btn.Size = new System.Drawing.Size(147, 29);
            this.UpdateProductUnitPrice_btn.TabIndex = 3;
            this.UpdateProductUnitPrice_btn.Text = "Ürün Fiyat Güncelle";
            this.UpdateProductUnitPrice_btn.UseVisualStyleBackColor = true;
            this.UpdateProductUnitPrice_btn.Click += new System.EventHandler(this.UpdateProductUnitPrice_btn_Click);
            // 
            // AddNewCustomer_btn
            // 
            this.AddNewCustomer_btn.Location = new System.Drawing.Point(318, 171);
            this.AddNewCustomer_btn.Name = "AddNewCustomer_btn";
            this.AddNewCustomer_btn.Size = new System.Drawing.Size(138, 29);
            this.AddNewCustomer_btn.TabIndex = 3;
            this.AddNewCustomer_btn.Text = "Yeni Müşteri Ekle";
            this.AddNewCustomer_btn.UseVisualStyleBackColor = true;
            this.AddNewCustomer_btn.Click += new System.EventHandler(this.AddNewCustomer_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Müşteri Seç";
            // 
            // PreOrder_btn
            // 
            this.PreOrder_btn.Location = new System.Drawing.Point(365, 484);
            this.PreOrder_btn.Name = "PreOrder_btn";
            this.PreOrder_btn.Size = new System.Drawing.Size(146, 55);
            this.PreOrder_btn.TabIndex = 3;
            this.PreOrder_btn.Text = "Ön Sipariş Yap";
            this.PreOrder_btn.UseVisualStyleBackColor = true;
            this.PreOrder_btn.Click += new System.EventHandler(this.PreOrder_btn_Click);
            // 
            // ComplateOrder_btn
            // 
            this.ComplateOrder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComplateOrder_btn.Location = new System.Drawing.Point(179, 484);
            this.ComplateOrder_btn.Name = "ComplateOrder_btn";
            this.ComplateOrder_btn.Size = new System.Drawing.Size(151, 55);
            this.ComplateOrder_btn.TabIndex = 3;
            this.ComplateOrder_btn.Text = "Satışı Tamamla";
            this.ComplateOrder_btn.UseVisualStyleBackColor = true;
            this.ComplateOrder_btn.Click += new System.EventHandler(this.ComplateOrder_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(550, 484);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(128, 55);
            this.return_btn.TabIndex = 3;
            this.return_btn.Text = "Geri Dön";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // TotalPrice_txt
            // 
            this.TotalPrice_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPrice_txt.Location = new System.Drawing.Point(469, 401);
            this.TotalPrice_txt.Multiline = true;
            this.TotalPrice_txt.Name = "TotalPrice_txt";
            this.TotalPrice_txt.Size = new System.Drawing.Size(160, 49);
            this.TotalPrice_txt.TabIndex = 1;
            // 
            // UnitPrice_txt
            // 
            this.UnitPrice_txt.Enabled = false;
            this.UnitPrice_txt.Location = new System.Drawing.Point(638, 227);
            this.UnitPrice_txt.Name = "UnitPrice_txt";
            this.UnitPrice_txt.Size = new System.Drawing.Size(125, 27);
            this.UnitPrice_txt.TabIndex = 1;
            // 
            // Amount_txt
            // 
            this.Amount_txt.Location = new System.Drawing.Point(124, 295);
            this.Amount_txt.Name = "Amount_txt";
            this.Amount_txt.Size = new System.Drawing.Size(141, 27);
            this.Amount_txt.TabIndex = 1;
            this.Amount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount_txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(246, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "Toplam Fiyat(TL)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ürün Adeti";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(149, 347);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(0, 20);
            this.AmountLabel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Birim Fiyatı (TL)";
            // 
            // UnitTotalPrice_txt
            // 
            this.UnitTotalPrice_txt.Enabled = false;
            this.UnitTotalPrice_txt.Location = new System.Drawing.Point(638, 285);
            this.UnitTotalPrice_txt.Name = "UnitTotalPrice_txt";
            this.UnitTotalPrice_txt.Size = new System.Drawing.Size(125, 27);
            this.UnitTotalPrice_txt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kdv Tutarı(%18)";
            // 
            // KdvPrice_txt
            // 
            this.KdvPrice_txt.Enabled = false;
            this.KdvPrice_txt.Location = new System.Drawing.Point(638, 347);
            this.KdvPrice_txt.Name = "KdvPrice_txt";
            this.KdvPrice_txt.Size = new System.Drawing.Size(125, 27);
            this.KdvPrice_txt.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Birim Toplam Tutar(TL)";
            // 
            // ProductName_txt
            // 
            this.ProductName_txt.Enabled = false;
            this.ProductName_txt.Location = new System.Drawing.Point(124, 231);
            this.ProductName_txt.Name = "ProductName_txt";
            this.ProductName_txt.Size = new System.Drawing.Size(140, 27);
            this.ProductName_txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı";
            // 
            // UrunSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 599);
            this.Controls.Add(this.groupBox1);
            this.Name = "UrunSat";
            this.Text = "Urun Sat";
            this.Load += new System.EventHandler(this.UrunSat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button ComplateOrder_btn;
        private Button return_btn;
        private TextBox TotalPrice_txt;
        private TextBox UnitPrice_txt;
        private Label label8;
        private Label label4;
        private TextBox KdvPrice_txt;
        private Label label7;
        private TextBox ProductName_txt;
        private Label label3;
        private GroupBox groupBox2;
        private Label label9;
        private Button PreOrder_btn;
        private TextBox Amount_txt;
        private Label label2;
        private ComboBox SelectCustomerCombobox;
        private TextBox FindProduct_txt;
        private ComboBox SelectProductCombobox;
        private Button Find_btn;
        private Label label11;
        private Label label1;
        private Button AddNewCustomer_btn;
        private Label label10;
        private TextBox UnitTotalPrice_txt;
        private Label label5;
        private Button UpdateProductUnitPrice_btn;
        private Label AmountLabel;
        private Label label6;
    }
}