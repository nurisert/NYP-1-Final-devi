namespace VideoKutuphanesi
{
    partial class Form1
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
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lstVideolar = new System.Windows.Forms.ListBox();
            this.lblReplik = new System.Windows.Forms.Label();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtYeniAnahtar = new System.Windows.Forms.TextBox();
            this.txtYeniLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYeniBaslik = new System.Windows.Forms.TextBox();
            this.btnRastgele = new System.Windows.Forms.Button();
            this.lblAdet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.SystemColors.Window;
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArama.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(12, 47);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(195, 21);
            this.txtArama.TabIndex = 0;
            // 
            // lstVideolar
            // 
            this.lstVideolar.BackColor = System.Drawing.SystemColors.Window;
            this.lstVideolar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstVideolar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstVideolar.FormattingEnabled = true;
            this.lstVideolar.ItemHeight = 21;
            this.lstVideolar.Location = new System.Drawing.Point(12, 80);
            this.lstVideolar.Name = "lstVideolar";
            this.lstVideolar.Size = new System.Drawing.Size(340, 168);
            this.lstVideolar.TabIndex = 1;
            // 
            // lblReplik
            // 
            this.lblReplik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReplik.AutoSize = true;
            this.lblReplik.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReplik.Location = new System.Drawing.Point(12, 359);
            this.lblReplik.Name = "lblReplik";
            this.lblReplik.Size = new System.Drawing.Size(0, 21);
            this.lblReplik.TabIndex = 2;
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(369, -3);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1016, 647);
            this.webView.TabIndex = 3;
            this.webView.ZoomFactor = 1D;
            // 
            // btnKopyala
            // 
            this.btnKopyala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKopyala.Location = new System.Drawing.Point(585, 661);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(622, 82);
            this.btnKopyala.TabIndex = 4;
            this.btnKopyala.Text = "Linki Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.txtYeniAnahtar);
            this.groupBox1.Controls.Add(this.txtYeniLink);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtYeniBaslik);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 218);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Video Ekle";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(112, 164);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(91, 28);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(209, 164);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(104, 28);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Listeye Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(6, 164);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 28);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Seçileni Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtYeniAnahtar
            // 
            this.txtYeniAnahtar.Location = new System.Drawing.Point(186, 116);
            this.txtYeniAnahtar.Name = "txtYeniAnahtar";
            this.txtYeniAnahtar.Size = new System.Drawing.Size(136, 28);
            this.txtYeniAnahtar.TabIndex = 9;
            // 
            // txtYeniLink
            // 
            this.txtYeniLink.Location = new System.Drawing.Point(186, 77);
            this.txtYeniLink.Name = "txtYeniLink";
            this.txtYeniLink.Size = new System.Drawing.Size(136, 28);
            this.txtYeniLink.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Etiketler (Virgülle ayırın)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "YouTube Linki:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(93, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlık:";
            // 
            // txtYeniBaslik
            // 
            this.txtYeniBaslik.Location = new System.Drawing.Point(186, 38);
            this.txtYeniBaslik.Name = "txtYeniBaslik";
            this.txtYeniBaslik.Size = new System.Drawing.Size(136, 28);
            this.txtYeniBaslik.TabIndex = 0;
            this.txtYeniBaslik.TextChanged += new System.EventHandler(this.txtYeniBaslik_TextChanged);
            // 
            // btnRastgele
            // 
            this.btnRastgele.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRastgele.Location = new System.Drawing.Point(213, 40);
            this.btnRastgele.Name = "btnRastgele";
            this.btnRastgele.Size = new System.Drawing.Size(139, 34);
            this.btnRastgele.TabIndex = 7;
            this.btnRastgele.Text = "Şansımı Dene 🎲";
            this.btnRastgele.UseVisualStyleBackColor = true;
            this.btnRastgele.Click += new System.EventHandler(this.btnRastgele_Click);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.Location = new System.Drawing.Point(20, 259);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(79, 21);
            this.lblAdet.TabIndex = 8;
            this.lblAdet.Text = "Toplam: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1377, 755);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.btnRastgele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.lblReplik);
            this.Controls.Add(this.lstVideolar);
            this.Controls.Add(this.txtArama);
            this.Name = "Form1";
            this.Text = "Video Arşivi";
            this.Click += new System.EventHandler(this.btnGuncelle_Click);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ListBox lstVideolar;
        private System.Windows.Forms.Label lblReplik;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYeniBaslik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtYeniAnahtar;
        private System.Windows.Forms.TextBox txtYeniLink;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnRastgele;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

