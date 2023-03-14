namespace BusinessManagementApp.UI.Forms
{
    partial class UrunGuncelle
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Update_btn = new System.Windows.Forms.Button();
            this.UpdateSelectSupplier_txt = new System.Windows.Forms.TextBox();
            this.UpdateProductName_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UnitPriceUpdate_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateOrigin_txt = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Update_btn);
            this.groupBox3.Controls.Add(this.UpdateSelectSupplier_txt);
            this.groupBox3.Controls.Add(this.UpdateProductName_txt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.UnitPriceUpdate_txt);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.UpdateOrigin_txt);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(657, 198);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(278, 140);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(94, 29);
            this.Update_btn.TabIndex = 3;
            this.Update_btn.Text = "Güncelle";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // UpdateSelectSupplier_txt
            // 
            this.UpdateSelectSupplier_txt.Location = new System.Drawing.Point(115, 42);
            this.UpdateSelectSupplier_txt.Name = "UpdateSelectSupplier_txt";
            this.UpdateSelectSupplier_txt.Size = new System.Drawing.Size(140, 27);
            this.UpdateSelectSupplier_txt.TabIndex = 1;
            // 
            // UpdateProductName_txt
            // 
            this.UpdateProductName_txt.Location = new System.Drawing.Point(473, 42);
            this.UpdateProductName_txt.Name = "UpdateProductName_txt";
            this.UpdateProductName_txt.Size = new System.Drawing.Size(140, 27);
            this.UpdateProductName_txt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Menşei";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ürün Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Satış Birim Fiyat(TL)";
            // 
            // UnitPriceUpdate_txt
            // 
            this.UnitPriceUpdate_txt.Location = new System.Drawing.Point(473, 87);
            this.UnitPriceUpdate_txt.Name = "UnitPriceUpdate_txt";
            this.UnitPriceUpdate_txt.Size = new System.Drawing.Size(140, 27);
            this.UnitPriceUpdate_txt.TabIndex = 1;
            this.UnitPriceUpdate_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitPriceUpdate_txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tedarikçi Seç";
            // 
            // UpdateOrigin_txt
            // 
            this.UpdateOrigin_txt.Location = new System.Drawing.Point(118, 90);
            this.UpdateOrigin_txt.Name = "UpdateOrigin_txt";
            this.UpdateOrigin_txt.Size = new System.Drawing.Size(137, 27);
            this.UpdateOrigin_txt.TabIndex = 1;
            // 
            // UrunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 227);
            this.Controls.Add(this.groupBox3);
            this.Name = "UrunGuncelle";
            this.Text = "Ürün Fiyat Güncelle";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox3;
        private Button Update_btn;
        private TextBox UpdateProductName_txt;
        private Label label6;
        private Label label7;
        private Label label5;
        private TextBox UnitPriceUpdate_txt;
        private Label label8;
        private TextBox UpdateOrigin_txt;
        private TextBox UpdateSelectSupplier_txt;
    }
}