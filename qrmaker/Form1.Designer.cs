namespace qrmaker
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOlustur = new System.Windows.Forms.Button();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(866, 181);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnOlustur.TabIndex = 0;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(691, 99);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(357, 22);
            this.txtMetin.TabIndex = 1;
            // 
            // picQR
            // 
            this.picQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picQR.Location = new System.Drawing.Point(66, 61);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(568, 428);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQR.TabIndex = 2;
            this.picQR.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(866, 226);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 597);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.btnOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Button btnKaydet;
    }
}

