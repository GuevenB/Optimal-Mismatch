namespace OptimalMismatch
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
            this.gBox_sonuclar = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_ToplamSure = new System.Windows.Forms.Label();
            this.lbl_AramaSuresi = new System.Windows.Forms.Label();
            this.lbl_preRcSuresi = new System.Windows.Forms.Label();
            this.lbl_preRcText = new System.Windows.Forms.Label();
            this.lbl_ToplamSureText = new System.Windows.Forms.Label();
            this.lbl_AramaSureText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_karsilastirmaText = new System.Windows.Forms.Label();
            this.lbl_eslesmeSayisi = new System.Windows.Forms.Label();
            this.lbl_karsilastirmaSayisi = new System.Windows.Forms.Label();
            this.lbl_eslesmeText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbox_BulunanIndex = new System.Windows.Forms.ListBox();
            this.lbl_bulunanIndex = new System.Windows.Forms.Label();
            this.btn_findAll = new System.Windows.Forms.Button();
            this.lbl_source = new System.Windows.Forms.Label();
            this.lbl_pattern = new System.Windows.Forms.Label();
            this.rtbox_Source = new System.Windows.Forms.RichTextBox();
            this.tbox_Pattern = new System.Windows.Forms.TextBox();
            this.btn_DosyaAc = new System.Windows.Forms.Button();
            this.btn_formSifirlama = new System.Windows.Forms.Button();
            this.gBox_sonuclar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_sonuclar
            // 
            this.gBox_sonuclar.Controls.Add(this.panel3);
            this.gBox_sonuclar.Controls.Add(this.panel2);
            this.gBox_sonuclar.Controls.Add(this.panel1);
            this.gBox_sonuclar.Dock = System.Windows.Forms.DockStyle.Right;
            this.gBox_sonuclar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_sonuclar.Location = new System.Drawing.Point(959, 0);
            this.gBox_sonuclar.Margin = new System.Windows.Forms.Padding(4);
            this.gBox_sonuclar.Name = "gBox_sonuclar";
            this.gBox_sonuclar.Padding = new System.Windows.Forms.Padding(4);
            this.gBox_sonuclar.Size = new System.Drawing.Size(437, 705);
            this.gBox_sonuclar.TabIndex = 27;
            this.gBox_sonuclar.TabStop = false;
            this.gBox_sonuclar.Text = "Sonuçlar";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_ToplamSure);
            this.panel3.Controls.Add(this.lbl_AramaSuresi);
            this.panel3.Controls.Add(this.lbl_preRcSuresi);
            this.panel3.Controls.Add(this.lbl_preRcText);
            this.panel3.Controls.Add(this.lbl_ToplamSureText);
            this.panel3.Controls.Add(this.lbl_AramaSureText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 171);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 169);
            this.panel3.TabIndex = 28;
            // 
            // lbl_ToplamSure
            // 
            this.lbl_ToplamSure.AutoSize = true;
            this.lbl_ToplamSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ToplamSure.Location = new System.Drawing.Point(265, 127);
            this.lbl_ToplamSure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ToplamSure.Name = "lbl_ToplamSure";
            this.lbl_ToplamSure.Size = new System.Drawing.Size(26, 29);
            this.lbl_ToplamSure.TabIndex = 17;
            this.lbl_ToplamSure.Text = "0";
            // 
            // lbl_AramaSuresi
            // 
            this.lbl_AramaSuresi.AutoSize = true;
            this.lbl_AramaSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AramaSuresi.Location = new System.Drawing.Point(265, 70);
            this.lbl_AramaSuresi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AramaSuresi.Name = "lbl_AramaSuresi";
            this.lbl_AramaSuresi.Size = new System.Drawing.Size(26, 29);
            this.lbl_AramaSuresi.TabIndex = 16;
            this.lbl_AramaSuresi.Text = "0";
            // 
            // lbl_preRcSuresi
            // 
            this.lbl_preRcSuresi.AutoSize = true;
            this.lbl_preRcSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_preRcSuresi.Location = new System.Drawing.Point(266, 26);
            this.lbl_preRcSuresi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_preRcSuresi.Name = "lbl_preRcSuresi";
            this.lbl_preRcSuresi.Size = new System.Drawing.Size(26, 29);
            this.lbl_preRcSuresi.TabIndex = 13;
            this.lbl_preRcSuresi.Text = "0";
            // 
            // lbl_preRcText
            // 
            this.lbl_preRcText.AutoSize = true;
            this.lbl_preRcText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preRcText.Location = new System.Drawing.Point(75, 26);
            this.lbl_preRcText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_preRcText.Name = "lbl_preRcText";
            this.lbl_preRcText.Size = new System.Drawing.Size(195, 28);
            this.lbl_preRcText.TabIndex = 13;
            this.lbl_preRcText.Text = "preOM süresi = ";
            // 
            // lbl_ToplamSureText
            // 
            this.lbl_ToplamSureText.AutoSize = true;
            this.lbl_ToplamSureText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToplamSureText.Location = new System.Drawing.Point(75, 127);
            this.lbl_ToplamSureText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ToplamSureText.Name = "lbl_ToplamSureText";
            this.lbl_ToplamSureText.Size = new System.Drawing.Size(185, 28);
            this.lbl_ToplamSureText.TabIndex = 15;
            this.lbl_ToplamSureText.Text = "Toplam Süre = ";
            // 
            // lbl_AramaSureText
            // 
            this.lbl_AramaSureText.AutoSize = true;
            this.lbl_AramaSureText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AramaSureText.Location = new System.Drawing.Point(69, 70);
            this.lbl_AramaSureText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AramaSureText.Name = "lbl_AramaSureText";
            this.lbl_AramaSureText.Size = new System.Drawing.Size(196, 28);
            this.lbl_AramaSureText.TabIndex = 14;
            this.lbl_AramaSureText.Text = "Arama Süresi = ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_karsilastirmaText);
            this.panel2.Controls.Add(this.lbl_eslesmeSayisi);
            this.panel2.Controls.Add(this.lbl_karsilastirmaSayisi);
            this.panel2.Controls.Add(this.lbl_eslesmeText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 128);
            this.panel2.TabIndex = 28;
            // 
            // lbl_karsilastirmaText
            // 
            this.lbl_karsilastirmaText.AutoSize = true;
            this.lbl_karsilastirmaText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_karsilastirmaText.Location = new System.Drawing.Point(4, 31);
            this.lbl_karsilastirmaText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_karsilastirmaText.Name = "lbl_karsilastirmaText";
            this.lbl_karsilastirmaText.Size = new System.Drawing.Size(268, 28);
            this.lbl_karsilastirmaText.TabIndex = 9;
            this.lbl_karsilastirmaText.Text = "Karşılaştırma Sayısı = ";
            // 
            // lbl_eslesmeSayisi
            // 
            this.lbl_eslesmeSayisi.AutoSize = true;
            this.lbl_eslesmeSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_eslesmeSayisi.Location = new System.Drawing.Point(268, 79);
            this.lbl_eslesmeSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_eslesmeSayisi.Name = "lbl_eslesmeSayisi";
            this.lbl_eslesmeSayisi.Size = new System.Drawing.Size(26, 29);
            this.lbl_eslesmeSayisi.TabIndex = 12;
            this.lbl_eslesmeSayisi.Text = "0";
            // 
            // lbl_karsilastirmaSayisi
            // 
            this.lbl_karsilastirmaSayisi.AutoSize = true;
            this.lbl_karsilastirmaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_karsilastirmaSayisi.Location = new System.Drawing.Point(268, 31);
            this.lbl_karsilastirmaSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_karsilastirmaSayisi.Name = "lbl_karsilastirmaSayisi";
            this.lbl_karsilastirmaSayisi.Size = new System.Drawing.Size(26, 29);
            this.lbl_karsilastirmaSayisi.TabIndex = 11;
            this.lbl_karsilastirmaSayisi.Text = "0";
            // 
            // lbl_eslesmeText
            // 
            this.lbl_eslesmeText.AutoSize = true;
            this.lbl_eslesmeText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eslesmeText.Location = new System.Drawing.Point(62, 79);
            this.lbl_eslesmeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_eslesmeText.Name = "lbl_eslesmeText";
            this.lbl_eslesmeText.Size = new System.Drawing.Size(208, 28);
            this.lbl_eslesmeText.TabIndex = 10;
            this.lbl_eslesmeText.Text = "Eşleşme Sayısı = ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbox_BulunanIndex);
            this.panel1.Controls.Add(this.lbl_bulunanIndex);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 363);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 338);
            this.panel1.TabIndex = 13;
            // 
            // lbox_BulunanIndex
            // 
            this.lbox_BulunanIndex.BackColor = System.Drawing.SystemColors.Control;
            this.lbox_BulunanIndex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbox_BulunanIndex.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbox_BulunanIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbox_BulunanIndex.FormattingEnabled = true;
            this.lbox_BulunanIndex.ItemHeight = 29;
            this.lbox_BulunanIndex.Location = new System.Drawing.Point(0, 48);
            this.lbox_BulunanIndex.Margin = new System.Windows.Forms.Padding(4);
            this.lbox_BulunanIndex.Name = "lbox_BulunanIndex";
            this.lbox_BulunanIndex.Size = new System.Drawing.Size(429, 290);
            this.lbox_BulunanIndex.TabIndex = 7;
            this.lbox_BulunanIndex.SelectedIndexChanged += new System.EventHandler(this.lbox_BulunanIndex_SelectedIndexChanged);
            // 
            // lbl_bulunanIndex
            // 
            this.lbl_bulunanIndex.AutoSize = true;
            this.lbl_bulunanIndex.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_bulunanIndex.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bulunanIndex.Location = new System.Drawing.Point(0, 0);
            this.lbl_bulunanIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bulunanIndex.Name = "lbl_bulunanIndex";
            this.lbl_bulunanIndex.Size = new System.Drawing.Size(208, 28);
            this.lbl_bulunanIndex.TabIndex = 6;
            this.lbl_bulunanIndex.Text = "Bulunan Indexler";
            // 
            // btn_findAll
            // 
            this.btn_findAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_findAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_findAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_findAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_findAll.Location = new System.Drawing.Point(627, 559);
            this.btn_findAll.Margin = new System.Windows.Forms.Padding(4);
            this.btn_findAll.Name = "btn_findAll";
            this.btn_findAll.Size = new System.Drawing.Size(211, 54);
            this.btn_findAll.TabIndex = 25;
            this.btn_findAll.Text = "Ara";
            this.btn_findAll.UseVisualStyleBackColor = false;
            this.btn_findAll.Click += new System.EventHandler(this.btn_findAll_Click);
            // 
            // lbl_source
            // 
            this.lbl_source.AutoSize = true;
            this.lbl_source.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_source.Location = new System.Drawing.Point(48, 174);
            this.lbl_source.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_source.Name = "lbl_source";
            this.lbl_source.Size = new System.Drawing.Size(209, 32);
            this.lbl_source.TabIndex = 24;
            this.lbl_source.Text = "Kaynak String";
            // 
            // lbl_pattern
            // 
            this.lbl_pattern.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pattern.Location = new System.Drawing.Point(48, 62);
            this.lbl_pattern.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pattern.Name = "lbl_pattern";
            this.lbl_pattern.Size = new System.Drawing.Size(132, 30);
            this.lbl_pattern.TabIndex = 23;
            this.lbl_pattern.Text = "Aranan String";
            // 
            // rtbox_Source
            // 
            this.rtbox_Source.BackColor = System.Drawing.SystemColors.Control;
            this.rtbox_Source.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbox_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbox_Source.Location = new System.Drawing.Point(53, 207);
            this.rtbox_Source.Margin = new System.Windows.Forms.Padding(4);
            this.rtbox_Source.Name = "rtbox_Source";
            this.rtbox_Source.Size = new System.Drawing.Size(784, 258);
            this.rtbox_Source.TabIndex = 22;
            this.rtbox_Source.Text = "";
            // 
            // tbox_Pattern
            // 
            this.tbox_Pattern.BackColor = System.Drawing.SystemColors.Control;
            this.tbox_Pattern.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_Pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbox_Pattern.Location = new System.Drawing.Point(54, 107);
            this.tbox_Pattern.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_Pattern.MinimumSize = new System.Drawing.Size(0, 25);
            this.tbox_Pattern.Name = "tbox_Pattern";
            this.tbox_Pattern.Size = new System.Drawing.Size(784, 27);
            this.tbox_Pattern.TabIndex = 21;
            // 
            // btn_DosyaAc
            // 
            this.btn_DosyaAc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DosyaAc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DosyaAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DosyaAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DosyaAc.Location = new System.Drawing.Point(377, 559);
            this.btn_DosyaAc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DosyaAc.Name = "btn_DosyaAc";
            this.btn_DosyaAc.Size = new System.Drawing.Size(211, 54);
            this.btn_DosyaAc.TabIndex = 26;
            this.btn_DosyaAc.Text = "Dosya Aç";
            this.btn_DosyaAc.UseVisualStyleBackColor = false;
            this.btn_DosyaAc.Click += new System.EventHandler(this.btn_DosyaAc_Click);
            // 
            // btn_formSifirlama
            // 
            this.btn_formSifirlama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_formSifirlama.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_formSifirlama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_formSifirlama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_formSifirlama.Location = new System.Drawing.Point(53, 559);
            this.btn_formSifirlama.Margin = new System.Windows.Forms.Padding(4);
            this.btn_formSifirlama.Name = "btn_formSifirlama";
            this.btn_formSifirlama.Size = new System.Drawing.Size(89, 54);
            this.btn_formSifirlama.TabIndex = 28;
            this.btn_formSifirlama.Text = "Sıfırla";
            this.btn_formSifirlama.UseVisualStyleBackColor = false;
            this.btn_formSifirlama.Click += new System.EventHandler(this.btn_formSifirlama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1396, 705);
            this.Controls.Add(this.btn_formSifirlama);
            this.Controls.Add(this.gBox_sonuclar);
            this.Controls.Add(this.btn_findAll);
            this.Controls.Add(this.lbl_source);
            this.Controls.Add(this.lbl_pattern);
            this.Controls.Add(this.rtbox_Source);
            this.Controls.Add(this.tbox_Pattern);
            this.Controls.Add(this.btn_DosyaAc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Optimal Mismatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBox_sonuclar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_sonuclar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_ToplamSure;
        private System.Windows.Forms.Label lbl_AramaSuresi;
        private System.Windows.Forms.Label lbl_preRcSuresi;
        private System.Windows.Forms.Label lbl_preRcText;
        private System.Windows.Forms.Label lbl_ToplamSureText;
        private System.Windows.Forms.Label lbl_AramaSureText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_karsilastirmaText;
        private System.Windows.Forms.Label lbl_eslesmeSayisi;
        private System.Windows.Forms.Label lbl_karsilastirmaSayisi;
        private System.Windows.Forms.Label lbl_eslesmeText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbox_BulunanIndex;
        private System.Windows.Forms.Label lbl_bulunanIndex;
        private System.Windows.Forms.Button btn_findAll;
        private System.Windows.Forms.Label lbl_source;
        private System.Windows.Forms.Label lbl_pattern;
        private System.Windows.Forms.RichTextBox rtbox_Source;
        private System.Windows.Forms.TextBox tbox_Pattern;
        private System.Windows.Forms.Button btn_DosyaAc;
        private System.Windows.Forms.Button btn_formSifirlama;
    }
}

