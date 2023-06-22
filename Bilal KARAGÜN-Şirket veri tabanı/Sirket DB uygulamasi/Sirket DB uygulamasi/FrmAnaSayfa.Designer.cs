namespace Sirket_DB_uygulamasi
{
    partial class FrmAnaSayfa
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
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btngör = new System.Windows.Forms.Button();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnadmin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadmin.Location = new System.Drawing.Point(217, 86);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(156, 131);
            this.btnadmin.TabIndex = 0;
            this.btnadmin.Text = "Admin Giriş";
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnekle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(606, 86);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(156, 131);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "Personel Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btngör
            // 
            this.btngör.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btngör.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngör.Location = new System.Drawing.Point(606, 309);
            this.btngör.Name = "btngör";
            this.btngör.Size = new System.Drawing.Size(156, 131);
            this.btngör.TabIndex = 2;
            this.btngör.Text = "Personel Görüntüle";
            this.btngör.UseVisualStyleBackColor = false;
            this.btngör.Click += new System.EventHandler(this.btngör_Click);
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDüzenle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDüzenle.Location = new System.Drawing.Point(217, 309);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(156, 131);
            this.btnDüzenle.TabIndex = 3;
            this.btnDüzenle.Text = "Diğer Tablolar";
            this.btnDüzenle.UseVisualStyleBackColor = false;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(992, 562);
            this.Controls.Add(this.btnDüzenle);
            this.Controls.Add(this.btngör);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnadmin);
            this.Name = "FrmAnaSayfa";
            this.Text = "FrmAnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btngör;
        private System.Windows.Forms.Button btnDüzenle;
    }
}