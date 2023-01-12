
namespace EntityProjeUygulama
{
    partial class FrmAnaForm
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
            this.BtnKtgrIslem = new System.Windows.Forms.Button();
            this.BtnUrunIslem = new System.Windows.Forms.Button();
            this.BtnIstatistik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKtgrIslem
            // 
            this.BtnKtgrIslem.Location = new System.Drawing.Point(12, 12);
            this.BtnKtgrIslem.Name = "BtnKtgrIslem";
            this.BtnKtgrIslem.Size = new System.Drawing.Size(235, 190);
            this.BtnKtgrIslem.TabIndex = 8;
            this.BtnKtgrIslem.Text = "KATEGORİ İŞLEMLERİ";
            this.BtnKtgrIslem.UseVisualStyleBackColor = true;
            this.BtnKtgrIslem.Click += new System.EventHandler(this.BtnKtgrIslem_Click);
            // 
            // BtnUrunIslem
            // 
            this.BtnUrunIslem.Location = new System.Drawing.Point(253, 12);
            this.BtnUrunIslem.Name = "BtnUrunIslem";
            this.BtnUrunIslem.Size = new System.Drawing.Size(235, 190);
            this.BtnUrunIslem.TabIndex = 12;
            this.BtnUrunIslem.Text = "ÜRÜN İŞLEMLERİ";
            this.BtnUrunIslem.UseVisualStyleBackColor = true;
            this.BtnUrunIslem.Click += new System.EventHandler(this.BtnUrunIslem_Click);
            // 
            // BtnIstatistik
            // 
            this.BtnIstatistik.Location = new System.Drawing.Point(494, 12);
            this.BtnIstatistik.Name = "BtnIstatistik";
            this.BtnIstatistik.Size = new System.Drawing.Size(235, 190);
            this.BtnIstatistik.TabIndex = 13;
            this.BtnIstatistik.Text = "İSTATİSTİKLER";
            this.BtnIstatistik.UseVisualStyleBackColor = true;
            this.BtnIstatistik.Click += new System.EventHandler(this.BtnIstatistik_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 211);
            this.Controls.Add(this.BtnIstatistik);
            this.Controls.Add(this.BtnUrunIslem);
            this.Controls.Add(this.BtnKtgrIslem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKtgrIslem;
        private System.Windows.Forms.Button BtnUrunIslem;
        private System.Windows.Forms.Button BtnIstatistik;
    }
}