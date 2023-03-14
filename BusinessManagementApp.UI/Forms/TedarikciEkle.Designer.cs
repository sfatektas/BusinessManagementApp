namespace BusinessManagementApp.UI.Forms
{
    partial class TedarikciEkle
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
            this.Close_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SupplierAdd_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Email_txtbox = new System.Windows.Forms.TextBox();
            this.LogisticCompany_txtbox = new System.Windows.Forms.TextBox();
            this.ContactPerson_txtbox = new System.Windows.Forms.TextBox();
            this.TelNo_txtbox = new System.Windows.Forms.TextBox();
            this.companyName_txtbox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(326, 279);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(115, 44);
            this.Close_btn.TabIndex = 0;
            this.Close_btn.Text = "Kapat";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SupplierAdd_btn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Email_txtbox);
            this.groupBox2.Controls.Add(this.LogisticCompany_txtbox);
            this.groupBox2.Controls.Add(this.ContactPerson_txtbox);
            this.groupBox2.Controls.Add(this.TelNo_txtbox);
            this.groupBox2.Controls.Add(this.companyName_txtbox);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tedarikçi Ekle";
            // 
            // SupplierAdd_btn
            // 
            this.SupplierAdd_btn.Location = new System.Drawing.Point(547, 173);
            this.SupplierAdd_btn.Name = "SupplierAdd_btn";
            this.SupplierAdd_btn.Size = new System.Drawing.Size(115, 33);
            this.SupplierAdd_btn.TabIndex = 2;
            this.SupplierAdd_btn.Text = "Ekle";
            this.SupplierAdd_btn.UseVisualStyleBackColor = true;
            this.SupplierAdd_btn.Click += new System.EventHandler(this.SupplierAdd_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lojistik Şirketi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefon Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "İletişim Kurulacak Kişi  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şirket Bilgisi:";
            // 
            // Email_txtbox
            // 
            this.Email_txtbox.Location = new System.Drawing.Point(547, 106);
            this.Email_txtbox.Name = "Email_txtbox";
            this.Email_txtbox.Size = new System.Drawing.Size(190, 27);
            this.Email_txtbox.TabIndex = 0;
            // 
            // LogisticCompany_txtbox
            // 
            this.LogisticCompany_txtbox.Location = new System.Drawing.Point(199, 162);
            this.LogisticCompany_txtbox.Name = "LogisticCompany_txtbox";
            this.LogisticCompany_txtbox.Size = new System.Drawing.Size(169, 27);
            this.LogisticCompany_txtbox.TabIndex = 0;
            // 
            // ContactPerson_txtbox
            // 
            this.ContactPerson_txtbox.Location = new System.Drawing.Point(199, 103);
            this.ContactPerson_txtbox.Name = "ContactPerson_txtbox";
            this.ContactPerson_txtbox.Size = new System.Drawing.Size(169, 27);
            this.ContactPerson_txtbox.TabIndex = 0;
            // 
            // TelNo_txtbox
            // 
            this.TelNo_txtbox.Location = new System.Drawing.Point(547, 46);
            this.TelNo_txtbox.Name = "TelNo_txtbox";
            this.TelNo_txtbox.Size = new System.Drawing.Size(190, 27);
            this.TelNo_txtbox.TabIndex = 0;
            // 
            // companyName_txtbox
            // 
            this.companyName_txtbox.Location = new System.Drawing.Point(199, 46);
            this.companyName_txtbox.Name = "companyName_txtbox";
            this.companyName_txtbox.Size = new System.Drawing.Size(169, 27);
            this.companyName_txtbox.TabIndex = 0;
            // 
            // TedarikciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Close_btn);
            this.Name = "TedarikciEkle";
            this.Text = "Tedarikçi Ekle";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Close_btn;
        private GroupBox groupBox2;
        private Button SupplierAdd_btn;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Email_txtbox;
        private TextBox LogisticCompany_txtbox;
        private TextBox ContactPerson_txtbox;
        private TextBox TelNo_txtbox;
        private TextBox companyName_txtbox;
    }
}