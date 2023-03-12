namespace BusinessManagementApp.UI.Forms
{
    partial class DepodakiUrunler
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
            this.TurnBack_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SellProduct_btn = new System.Windows.Forms.Button();
            this.Find_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.find_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stoktaki Ürünler";
            // 
            // TurnBack_btn
            // 
            this.TurnBack_btn.Location = new System.Drawing.Point(313, 358);
            this.TurnBack_btn.Name = "TurnBack_btn";
            this.TurnBack_btn.Size = new System.Drawing.Size(119, 43);
            this.TurnBack_btn.TabIndex = 5;
            this.TurnBack_btn.Text = "Geri Dön";
            this.TurnBack_btn.UseVisualStyleBackColor = true;
            this.TurnBack_btn.Click += new System.EventHandler(this.TurnBack_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(449, 187);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // SellProduct_btn
            // 
            this.SellProduct_btn.Location = new System.Drawing.Point(79, 358);
            this.SellProduct_btn.Name = "SellProduct_btn";
            this.SellProduct_btn.Size = new System.Drawing.Size(119, 43);
            this.SellProduct_btn.TabIndex = 6;
            this.SellProduct_btn.Text = "Ürün Sat";
            this.SellProduct_btn.UseVisualStyleBackColor = true;
            this.SellProduct_btn.Click += new System.EventHandler(this.SellProduct_btn_Click);
            // 
            // Find_txtbox
            // 
            this.Find_txtbox.Location = new System.Drawing.Point(181, 59);
            this.Find_txtbox.Name = "Find_txtbox";
            this.Find_txtbox.Size = new System.Drawing.Size(125, 27);
            this.Find_txtbox.TabIndex = 8;
            this.Find_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Find_txtbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ürün ID";
            // 
            // find_btn
            // 
            this.find_btn.Location = new System.Drawing.Point(331, 57);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(78, 31);
            this.find_btn.TabIndex = 6;
            this.find_btn.Text = "Bul";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "NOT: Ürünün detaylarını görmek ilgili satıra için çift tıklayınız.";
            // 
            // DepodakiUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Find_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TurnBack_btn);
            this.Controls.Add(this.SellProduct_btn);
            this.Controls.Add(this.find_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepodakiUrunler";
            this.Text = "Güncel Stok";
            this.Load += new System.EventHandler(this.DepodakiUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button TurnBack_btn;
        private DataGridView dataGridView1;
        private Button SellProduct_btn;
        private TextBox Find_txtbox;
        private Label label2;
        private Button find_btn;
        private Label label3;
    }
}