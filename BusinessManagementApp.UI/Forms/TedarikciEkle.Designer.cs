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
            this.SuspendLayout();
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(244, 196);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(115, 44);
            this.Close_btn.TabIndex = 0;
            this.Close_btn.Text = "Kapat";
            this.Close_btn.UseVisualStyleBackColor = true;
            // 
            // TedarikciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 286);
            this.Controls.Add(this.Close_btn);
            this.Name = "TedarikciEkle";
            this.Text = "Tedarikçi Ekle";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Close_btn;
    }
}