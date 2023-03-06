namespace BusinessManagementApp.UI.Forms
{
    partial class ConfirmForm
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
            this.Yes_btn = new System.Windows.Forms.Button();
            this.No_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emin misiniz ?";
            // 
            // Yes_btn
            // 
            this.Yes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Yes_btn.Location = new System.Drawing.Point(38, 98);
            this.Yes_btn.Name = "Yes_btn";
            this.Yes_btn.Size = new System.Drawing.Size(94, 29);
            this.Yes_btn.TabIndex = 1;
            this.Yes_btn.Text = "Evet";
            this.Yes_btn.UseVisualStyleBackColor = true;
            this.Yes_btn.Click += new System.EventHandler(this.Yes_btn_Click);
            // 
            // No_btn
            // 
            this.No_btn.Location = new System.Drawing.Point(167, 98);
            this.No_btn.Name = "No_btn";
            this.No_btn.Size = new System.Drawing.Size(94, 29);
            this.No_btn.TabIndex = 1;
            this.No_btn.Text = "Hayır";
            this.No_btn.UseVisualStyleBackColor = true;
            this.No_btn.Click += new System.EventHandler(this.No_btn_Click);
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 165);
            this.Controls.Add(this.No_btn);
            this.Controls.Add(this.Yes_btn);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmForm";
            this.Text = "Onayla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Yes_btn;
        private Button No_btn;
    }
}