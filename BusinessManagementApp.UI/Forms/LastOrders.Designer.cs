namespace BusinessManagementApp.UI.Forms
{
    partial class LastOrders
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
            this.label2 = new System.Windows.Forms.Label();
            this.return_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Not: Detayını görmek istediğiniz sipariş kayıtına çift tıklayınız.  ";
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(517, 374);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(132, 42);
            this.return_btn.TabIndex = 6;
            this.return_btn.Text = "Geri Dön";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(413, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Son 10 Satış İşlemi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(976, 244);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // LastOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LastOrders";
            this.Text = "Son Satış İşlemleri ";
            this.Load += new System.EventHandler(this.LastOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button return_btn;
        private Label label1;
        private DataGridView dataGridView1;
    }
}