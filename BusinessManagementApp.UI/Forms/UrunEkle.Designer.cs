namespace BusinessManagementApp.UI.Forms
{
    partial class UrunEkle
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
            this.SupplierSellect_combobox = new System.Windows.Forms.ComboBox();
            this.AddNewSupplier_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.AddProduct_btn = new System.Windows.Forms.Button();
            this.AddUnitPrice = new System.Windows.Forms.TextBox();
            this.AddOrigin_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddProductName_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SupplierSellect_combobox);
            this.groupBox1.Controls.Add(this.AddNewSupplier_btn);
            this.groupBox1.Controls.Add(this.Cancel_btn);
            this.groupBox1.Controls.Add(this.AddProduct_btn);
            this.groupBox1.Controls.Add(this.AddUnitPrice);
            this.groupBox1.Controls.Add(this.AddOrigin_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddProductName_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // SupplierSellect_combobox
            // 
            this.SupplierSellect_combobox.FormattingEnabled = true;
            this.SupplierSellect_combobox.Location = new System.Drawing.Point(107, 44);
            this.SupplierSellect_combobox.Name = "SupplierSellect_combobox";
            this.SupplierSellect_combobox.Size = new System.Drawing.Size(151, 28);
            this.SupplierSellect_combobox.TabIndex = 3;
            // 
            // AddNewSupplier_btn
            // 
            this.AddNewSupplier_btn.Location = new System.Drawing.Point(273, 44);
            this.AddNewSupplier_btn.Name = "AddNewSupplier_btn";
            this.AddNewSupplier_btn.Size = new System.Drawing.Size(149, 29);
            this.AddNewSupplier_btn.TabIndex = 3;
            this.AddNewSupplier_btn.Text = "Yeni Tedarikçi Ekle";
            this.AddNewSupplier_btn.UseVisualStyleBackColor = true;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(328, 135);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(94, 29);
            this.Cancel_btn.TabIndex = 3;
            this.Cancel_btn.Text = "İptal";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // AddProduct_btn
            // 
            this.AddProduct_btn.Location = new System.Drawing.Point(192, 135);
            this.AddProduct_btn.Name = "AddProduct_btn";
            this.AddProduct_btn.Size = new System.Drawing.Size(94, 29);
            this.AddProduct_btn.TabIndex = 3;
            this.AddProduct_btn.Text = "Ekle";
            this.AddProduct_btn.UseVisualStyleBackColor = true;
            this.AddProduct_btn.Click += new System.EventHandler(this.AddProduct_btn_Click);
            // 
            // AddUnitPrice
            // 
            this.AddUnitPrice.Location = new System.Drawing.Point(531, 92);
            this.AddUnitPrice.Name = "AddUnitPrice";
            this.AddUnitPrice.Size = new System.Drawing.Size(125, 27);
            this.AddUnitPrice.TabIndex = 1;
            this.AddUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddUnitPrice_KeyPress);
            // 
            // AddOrigin_txt
            // 
            this.AddOrigin_txt.Location = new System.Drawing.Point(113, 88);
            this.AddOrigin_txt.Name = "AddOrigin_txt";
            this.AddOrigin_txt.Size = new System.Drawing.Size(125, 27);
            this.AddOrigin_txt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Satış Birim Fiyat(TL)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menşei";
            // 
            // AddProductName_txt
            // 
            this.AddProductName_txt.Location = new System.Drawing.Point(531, 44);
            this.AddProductName_txt.Name = "AddProductName_txt";
            this.AddProductName_txt.Size = new System.Drawing.Size(125, 27);
            this.AddProductName_txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tedarikçi Seç";
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 216);
            this.Controls.Add(this.groupBox1);
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox SupplierSellect_combobox;
        private Button AddNewSupplier_btn;
        private Button AddProduct_btn;
        private TextBox AddUnitPrice;
        private TextBox AddOrigin_txt;
        private Label label4;
        private Label label2;
        private TextBox AddProductName_txt;
        private Label label3;
        private Label label1;
        private Button Cancel_btn;
    }
}