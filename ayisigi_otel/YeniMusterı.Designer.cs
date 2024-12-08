using System.Drawing;
using System.Windows.Forms;

namespace Ayısıgı1
{
    partial class YeniMusterı
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.TxtOdano = new System.Windows.Forms.TextBox();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.MskTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpCıkısTarihi = new System.Windows.Forms.DateTimePicker();
            this.Kaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ComoboxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txtucret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kimlik No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 365);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Oda Id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 484);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giriş Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 556);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 34);
            this.label8.TabIndex = 7;
            this.label8.Text = "Çıkış Tarihi:";
            // 
            // TxtAdi
            // 
            this.TxtAdi.Location = new System.Drawing.Point(291, 55);
            this.TxtAdi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(330, 42);
            this.TxtAdi.TabIndex = 8;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(291, 259);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(330, 42);
            this.TxtMail.TabIndex = 9;
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.Location = new System.Drawing.Point(291, 102);
            this.TxtSoyadi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(330, 42);
            this.TxtSoyadi.TabIndex = 11;
            // 
            // TxtOdano
            // 
            this.TxtOdano.Enabled = false;
            this.TxtOdano.Location = new System.Drawing.Point(291, 377);
            this.TxtOdano.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtOdano.Name = "TxtOdano";
            this.TxtOdano.Size = new System.Drawing.Size(330, 42);
            this.TxtOdano.TabIndex = 12;
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(291, 311);
            this.TxtTc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtTc.MaxLength = 11;
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(330, 42);
            this.TxtTc.TabIndex = 13;
            // 
            // MskTxtTel
            // 
            this.MskTxtTel.Location = new System.Drawing.Point(291, 206);
            this.MskTxtTel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MskTxtTel.Mask = "(999) 000-0000";
            this.MskTxtTel.Name = "MskTxtTel";
            this.MskTxtTel.Size = new System.Drawing.Size(330, 42);
            this.MskTxtTel.TabIndex = 14;
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Location = new System.Drawing.Point(291, 484);
            this.DtpGirisTarihi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(330, 42);
            this.DtpGirisTarihi.TabIndex = 15;
            // 
            // DtpCıkısTarihi
            // 
            this.DtpCıkısTarihi.Location = new System.Drawing.Point(291, 556);
            this.DtpCıkısTarihi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DtpCıkısTarihi.Name = "DtpCıkısTarihi";
            this.DtpCıkısTarihi.Size = new System.Drawing.Size(330, 42);
            this.DtpCıkısTarihi.TabIndex = 16;
            this.DtpCıkısTarihi.ValueChanged += new System.EventHandler(this.DtpCıkısTarihi_ValueChanged);
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(343, 612);
            this.Kaydet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(214, 56);
            this.Kaydet.TabIndex = 17;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ComoboxCinsiyet);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Txtucret);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Kaydet);
            this.groupBox1.Controls.Add(this.DtpCıkısTarihi);
            this.groupBox1.Controls.Add(this.DtpGirisTarihi);
            this.groupBox1.Controls.Add(this.MskTxtTel);
            this.groupBox1.Controls.Add(this.TxtTc);
            this.groupBox1.Controls.Add(this.TxtOdano);
            this.groupBox1.Controls.Add(this.TxtSoyadi);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.TxtAdi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(699, 700);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Müşteri Ekle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(579, 623);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 34);
            this.label11.TabIndex = 22;
            this.label11.Text = "0";
            this.label11.Visible = false;
            // 
            // ComoboxCinsiyet
            // 
            this.ComoboxCinsiyet.FormattingEnabled = true;
            this.ComoboxCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.ComoboxCinsiyet.Location = new System.Drawing.Point(291, 146);
            this.ComoboxCinsiyet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ComoboxCinsiyet.Name = "ComoboxCinsiyet";
            this.ComoboxCinsiyet.Size = new System.Drawing.Size(330, 42);
            this.ComoboxCinsiyet.TabIndex = 21;
            this.ComoboxCinsiyet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 34);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cinsiyet:";
            // 
            // Txtucret
            // 
            this.Txtucret.Location = new System.Drawing.Point(291, 429);
            this.Txtucret.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtucret.Name = "Txtucret";
            this.Txtucret.Size = new System.Drawing.Size(330, 42);
            this.Txtucret.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 429);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 34);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ücret:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(1035, 835);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 75);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ana Sayfaya Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ayisigi_otel.Properties.Resources.full_moon_308007_1280;
            this.pictureBox1.Location = new System.Drawing.Point(-251, 734);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 1280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(745, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(707, 683);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "label12";
            // 
            // YeniMusterı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1526, 1027);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "YeniMusterı";
            this.Text = "YeniMusterıEkle";
            this.Load += new System.EventHandler(this.YeniMusterı_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox TxtAdi;
        private TextBox TxtMail;
        private TextBox TxtSoyadi;
        private TextBox TxtOdano;
        private TextBox TxtTc;
        private MaskedTextBox MskTxtTel;
        private DateTimePicker DtpGirisTarihi;
        private DateTimePicker DtpCıkısTarihi;
        private Button Kaydet;
        private GroupBox groupBox1;
        private TextBox Txtucret;
        private Label label9;
        private ComboBox ComoboxCinsiyet;
        private Label label10;
        private Label label11;
        private Button button1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label12;
    }
}