namespace PubG
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKarakterAdi = new System.Windows.Forms.TextBox();
            this.cbSeviye = new System.Windows.Forms.ComboBox();
            this.lbOyundakiler = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOyunGir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSilahTuru = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSilahlar = new System.Windows.Forms.ListBox();
            this.tbMermiSAyisi = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karakter Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Karakter Seviyesi:";
            // 
            // tbKarakterAdi
            // 
            this.tbKarakterAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKarakterAdi.Location = new System.Drawing.Point(142, 54);
            this.tbKarakterAdi.Name = "tbKarakterAdi";
            this.tbKarakterAdi.Size = new System.Drawing.Size(121, 26);
            this.tbKarakterAdi.TabIndex = 2;
            // 
            // cbSeviye
            // 
            this.cbSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSeviye.FormattingEnabled = true;
            this.cbSeviye.Items.AddRange(new object[] {
            "Er",
            "Çavuş",
            "YüzBaşı",
            "Binbaşı",
            "Albay"});
            this.cbSeviye.Location = new System.Drawing.Point(142, 86);
            this.cbSeviye.Name = "cbSeviye";
            this.cbSeviye.Size = new System.Drawing.Size(121, 28);
            this.cbSeviye.TabIndex = 3;
            // 
            // lbOyundakiler
            // 
            this.lbOyundakiler.FormattingEnabled = true;
            this.lbOyundakiler.Location = new System.Drawing.Point(575, 138);
            this.lbOyundakiler.Name = "lbOyundakiler";
            this.lbOyundakiler.Size = new System.Drawing.Size(183, 95);
            this.lbOyundakiler.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(624, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oyundaki Kullanıcılar";
            // 
            // btnOyunGir
            // 
            this.btnOyunGir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOyunGir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOyunGir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOyunGir.Location = new System.Drawing.Point(329, 118);
            this.btnOyunGir.Name = "btnOyunGir";
            this.btnOyunGir.Size = new System.Drawing.Size(104, 320);
            this.btnOyunGir.TabIndex = 6;
            this.btnOyunGir.Text = "Oyuna Gir";
            this.btnOyunGir.UseVisualStyleBackColor = false;
            this.btnOyunGir.Click += new System.EventHandler(this.btnOyunGir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSeviye);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbKarakterAdi);
            this.groupBox1.Location = new System.Drawing.Point(54, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 157);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Karakter Ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.tbMermiSAyisi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbSilahTuru);
            this.groupBox2.Location = new System.Drawing.Point(54, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 157);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Silah Ekle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(40, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Silah Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mermi Sayısı";
            // 
            // tbSilahTuru
            // 
            this.tbSilahTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSilahTuru.Location = new System.Drawing.Point(142, 54);
            this.tbSilahTuru.Name = "tbSilahTuru";
            this.tbSilahTuru.Size = new System.Drawing.Size(121, 26);
            this.tbSilahTuru.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(624, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Oyundaki Silahlar";
            // 
            // lbSilahlar
            // 
            this.lbSilahlar.FormattingEnabled = true;
            this.lbSilahlar.Location = new System.Drawing.Point(575, 281);
            this.lbSilahlar.Name = "lbSilahlar";
            this.lbSilahlar.Size = new System.Drawing.Size(183, 95);
            this.lbSilahlar.TabIndex = 9;
            // 
            // tbMermiSAyisi
            // 
            this.tbMermiSAyisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMermiSAyisi.Location = new System.Drawing.Point(142, 86);
            this.tbMermiSAyisi.Name = "tbMermiSAyisi";
            this.tbMermiSAyisi.Size = new System.Drawing.Size(121, 26);
            this.tbMermiSAyisi.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.comboBox1.Location = new System.Drawing.Point(142, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(6, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Zoom Özelliği";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PubG.Properties.Resources.pubg_mobile_1_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbSilahlar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOyunGir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbOyundakiler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKarakterAdi;
        private System.Windows.Forms.ComboBox cbSeviye;
        private System.Windows.Forms.ListBox lbOyundakiler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOyunGir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSilahTuru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbSilahlar;
        private System.Windows.Forms.TextBox tbMermiSAyisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

