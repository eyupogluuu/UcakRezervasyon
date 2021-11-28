
namespace UcusRezervazyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combonereden = new System.Windows.Forms.ComboBox();
            this.combonereye = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedsaat = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textadsoyad = new System.Windows.Forms.TextBox();
            this.maskedTC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTelefon = new System.Windows.Forms.MaskedTextBox();
            this.buttonkaydet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttondegistir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nereden:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nereye:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saat:";
            // 
            // combonereden
            // 
            this.combonereden.FormattingEnabled = true;
            this.combonereden.Items.AddRange(new object[] {
            "Bursa",
            "Ankara",
            "İzmir",
            "İstanbul",
            "Balikesir",
            "Erzurum",
            "Sivas",
            "Antalya",
            "Giresun",
            "Ordu ",
            "Muğla",
            "Diyarbakır"});
            this.combonereden.Location = new System.Drawing.Point(103, 52);
            this.combonereden.Name = "combonereden";
            this.combonereden.Size = new System.Drawing.Size(121, 32);
            this.combonereden.TabIndex = 4;
            // 
            // combonereye
            // 
            this.combonereye.FormattingEnabled = true;
            this.combonereye.Items.AddRange(new object[] {
            "Bursa",
            "Ankara",
            "İzmir",
            "İstanbul",
            "Balikesir",
            "Erzurum",
            "Sivas",
            "Antalya",
            "Giresun",
            "Ordu ",
            "Muğla",
            "Diyarbakır"});
            this.combonereye.Location = new System.Drawing.Point(103, 94);
            this.combonereye.Name = "combonereye";
            this.combonereye.Size = new System.Drawing.Size(121, 32);
            this.combonereye.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 29);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // maskedsaat
            // 
            this.maskedsaat.Location = new System.Drawing.Point(103, 175);
            this.maskedsaat.Mask = "00:00";
            this.maskedsaat.Name = "maskedsaat";
            this.maskedsaat.Size = new System.Drawing.Size(60, 29);
            this.maskedsaat.TabIndex = 7;
            this.maskedsaat.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.buttondegistir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedsaat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.combonereye);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combonereden);
            this.groupBox1.Location = new System.Drawing.Point(42, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 225);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uçuş Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonkaydet);
            this.groupBox2.Controls.Add(this.maskedTelefon);
            this.groupBox2.Controls.Add(this.maskedTC);
            this.groupBox2.Controls.Add(this.textadsoyad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(367, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 225);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yolcu Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ad Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "TCKN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Telefon:";
            // 
            // textadsoyad
            // 
            this.textadsoyad.Location = new System.Drawing.Point(105, 47);
            this.textadsoyad.Name = "textadsoyad";
            this.textadsoyad.Size = new System.Drawing.Size(159, 29);
            this.textadsoyad.TabIndex = 4;
            // 
            // maskedTC
            // 
            this.maskedTC.Location = new System.Drawing.Point(105, 92);
            this.maskedTC.Mask = "00000000000";
            this.maskedTC.Name = "maskedTC";
            this.maskedTC.Size = new System.Drawing.Size(159, 29);
            this.maskedTC.TabIndex = 8;
            this.maskedTC.ValidatingType = typeof(int);
            // 
            // maskedTelefon
            // 
            this.maskedTelefon.Location = new System.Drawing.Point(105, 135);
            this.maskedTelefon.Mask = "(999) 000-0000";
            this.maskedTelefon.Name = "maskedTelefon";
            this.maskedTelefon.Size = new System.Drawing.Size(159, 29);
            this.maskedTelefon.TabIndex = 9;
            // 
            // buttonkaydet
            // 
            this.buttonkaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonkaydet.Location = new System.Drawing.Point(147, 175);
            this.buttonkaydet.Name = "buttonkaydet";
            this.buttonkaydet.Size = new System.Drawing.Size(117, 29);
            this.buttonkaydet.TabIndex = 10;
            this.buttonkaydet.Text = "Kaydet";
            this.buttonkaydet.UseVisualStyleBackColor = true;
            this.buttonkaydet.Click += new System.EventHandler(this.buttonkaydet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(72, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 57);
            this.label8.TabIndex = 0;
            this.label8.Text = "Hoşgeldiniz";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(64, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 87);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(391, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttondegistir
            // 
            this.buttondegistir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttondegistir.Location = new System.Drawing.Point(230, 96);
            this.buttondegistir.Name = "buttondegistir";
            this.buttondegistir.Size = new System.Drawing.Size(50, 30);
            this.buttondegistir.TabIndex = 8;
            this.buttondegistir.Text = "<>";
            this.buttondegistir.UseVisualStyleBackColor = true;
            this.buttondegistir.Click += new System.EventHandler(this.buttondegistir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(82, 338);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(524, 100);
            this.listBox1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(697, 445);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combonereden;
        private System.Windows.Forms.ComboBox combonereye;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox maskedsaat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonkaydet;
        private System.Windows.Forms.MaskedTextBox maskedTelefon;
        private System.Windows.Forms.MaskedTextBox maskedTC;
        private System.Windows.Forms.TextBox textadsoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttondegistir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
    }
}

