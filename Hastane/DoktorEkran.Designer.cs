
namespace Hastane
{
    partial class DoktorEkran
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_gecen_randevu_sayisi = new System.Windows.Forms.Label();
            this.lb_bekleyen_randevu_sayisi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_hasta_kabul = new System.Windows.Forms.Button();
            this.include_completed_randevu = new System.Windows.Forms.Button();
            this.btn_bugun_randevu = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.adagore = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_ilac_sil = new System.Windows.Forms.Button();
            this.btn_recete_yaz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ilac_ekle = new System.Windows.Forms.Button();
            this.tb_teshis = new System.Windows.Forms.TextBox();
            this.btn_kabul_iptal = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(24, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(780, 211);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(866, 666);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 29);
            this.label10.TabIndex = 48;
            this.label10.Text = "ÖZEL X HASTANESİ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_gecen_randevu_sayisi);
            this.groupBox1.Controls.Add(this.lb_bekleyen_randevu_sayisi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_hasta_kabul);
            this.groupBox1.Controls.Add(this.include_completed_randevu);
            this.groupBox1.Controls.Add(this.btn_bugun_randevu);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.adagore);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 349);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Günlük Bekleyen Hasta Listesi";
            // 
            // lb_gecen_randevu_sayisi
            // 
            this.lb_gecen_randevu_sayisi.AutoSize = true;
            this.lb_gecen_randevu_sayisi.BackColor = System.Drawing.SystemColors.Desktop;
            this.lb_gecen_randevu_sayisi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_gecen_randevu_sayisi.ForeColor = System.Drawing.Color.Red;
            this.lb_gecen_randevu_sayisi.Location = new System.Drawing.Point(230, 298);
            this.lb_gecen_randevu_sayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_gecen_randevu_sayisi.Name = "lb_gecen_randevu_sayisi";
            this.lb_gecen_randevu_sayisi.Size = new System.Drawing.Size(0, 19);
            this.lb_gecen_randevu_sayisi.TabIndex = 63;
            // 
            // lb_bekleyen_randevu_sayisi
            // 
            this.lb_bekleyen_randevu_sayisi.AutoSize = true;
            this.lb_bekleyen_randevu_sayisi.BackColor = System.Drawing.SystemColors.Desktop;
            this.lb_bekleyen_randevu_sayisi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_bekleyen_randevu_sayisi.ForeColor = System.Drawing.Color.Yellow;
            this.lb_bekleyen_randevu_sayisi.Location = new System.Drawing.Point(197, 321);
            this.lb_bekleyen_randevu_sayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_bekleyen_randevu_sayisi.Name = "lb_bekleyen_randevu_sayisi";
            this.lb_bekleyen_randevu_sayisi.Size = new System.Drawing.Size(0, 19);
            this.lb_bekleyen_randevu_sayisi.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 320);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 19);
            this.label7.TabIndex = 62;
            this.label7.Text = "Bekleyen randevu sayısı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = "Zamanı geçmiş randevu sayısı:";
            // 
            // btn_hasta_kabul
            // 
            this.btn_hasta_kabul.BackColor = System.Drawing.Color.Yellow;
            this.btn_hasta_kabul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hasta_kabul.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hasta_kabul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_hasta_kabul.Location = new System.Drawing.Point(688, 293);
            this.btn_hasta_kabul.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hasta_kabul.Name = "btn_hasta_kabul";
            this.btn_hasta_kabul.Size = new System.Drawing.Size(116, 42);
            this.btn_hasta_kabul.TabIndex = 52;
            this.btn_hasta_kabul.Text = "Hasta Kabul";
            this.btn_hasta_kabul.UseVisualStyleBackColor = false;
            this.btn_hasta_kabul.Click += new System.EventHandler(this.btn_hasta_kabul_Click);
            // 
            // include_completed_randevu
            // 
            this.include_completed_randevu.BackColor = System.Drawing.SystemColors.Control;
            this.include_completed_randevu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.include_completed_randevu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.include_completed_randevu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.include_completed_randevu.Location = new System.Drawing.Point(608, 33);
            this.include_completed_randevu.Margin = new System.Windows.Forms.Padding(2);
            this.include_completed_randevu.Name = "include_completed_randevu";
            this.include_completed_randevu.Size = new System.Drawing.Size(196, 38);
            this.include_completed_randevu.TabIndex = 60;
            this.include_completed_randevu.Text = "Tamamlananlarıda Göster";
            this.include_completed_randevu.UseVisualStyleBackColor = false;
            this.include_completed_randevu.Click += new System.EventHandler(this.include_completed_randevu_Click);
            // 
            // btn_bugun_randevu
            // 
            this.btn_bugun_randevu.BackColor = System.Drawing.SystemColors.Control;
            this.btn_bugun_randevu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_bugun_randevu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bugun_randevu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bugun_randevu.Location = new System.Drawing.Point(442, 33);
            this.btn_bugun_randevu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bugun_randevu.Name = "btn_bugun_randevu";
            this.btn_bugun_randevu.Size = new System.Drawing.Size(162, 38);
            this.btn_bugun_randevu.TabIndex = 60;
            this.btn_bugun_randevu.Text = "Bugünün Randevuları";
            this.btn_bugun_randevu.UseVisualStyleBackColor = false;
            this.btn_bugun_randevu.Click += new System.EventHandler(this.btn_bugun_randevu_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(24, 38);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 26);
            this.label15.TabIndex = 59;
            this.label15.Text = "Ad:";
            // 
            // adagore
            // 
            this.adagore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adagore.Location = new System.Drawing.Point(69, 38);
            this.adagore.Margin = new System.Windows.Forms.Padding(2);
            this.adagore.Name = "adagore";
            this.adagore.Size = new System.Drawing.Size(126, 27);
            this.adagore.TabIndex = 28;
            this.adagore.TextChanged += new System.EventHandler(this.adagore_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_soyad);
            this.groupBox3.Controls.Add(this.lbl_ad);
            this.groupBox3.Controls.Add(this.lbl_tc);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(843, 39);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(205, 316);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hasta Bilgileri";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyad.ForeColor = System.Drawing.Color.Red;
            this.lbl_soyad.Location = new System.Drawing.Point(73, 276);
            this.lbl_soyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(0, 18);
            this.lbl_soyad.TabIndex = 23;
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.ForeColor = System.Drawing.Color.Red;
            this.lbl_ad.Location = new System.Drawing.Point(46, 253);
            this.lbl_ad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(0, 19);
            this.lbl_ad.TabIndex = 22;
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tc.ForeColor = System.Drawing.Color.Red;
            this.lbl_tc.Location = new System.Drawing.Point(46, 231);
            this.lbl_tc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(0, 19);
            this.lbl_tc.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "TC:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(46, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 19);
            this.label12.TabIndex = 17;
            this.label12.Text = "Hasta Fotoğrafı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.btn_ilac_sil);
            this.groupBox2.Controls.Add(this.btn_recete_yaz);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_ilac_ekle);
            this.groupBox2.Controls.Add(this.tb_teshis);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 232);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teşhiş ve Reçete";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(99, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(247, 137);
            this.listView1.TabIndex = 65;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_ilac_sil
            // 
            this.btn_ilac_sil.BackColor = System.Drawing.Color.Crimson;
            this.btn_ilac_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ilac_sil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ilac_sil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ilac_sil.Location = new System.Drawing.Point(285, 180);
            this.btn_ilac_sil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ilac_sil.Name = "btn_ilac_sil";
            this.btn_ilac_sil.Size = new System.Drawing.Size(61, 37);
            this.btn_ilac_sil.TabIndex = 64;
            this.btn_ilac_sil.Text = "Sil";
            this.btn_ilac_sil.UseVisualStyleBackColor = false;
            this.btn_ilac_sil.Click += new System.EventHandler(this.btn_ilac_sil_Click);
            // 
            // btn_recete_yaz
            // 
            this.btn_recete_yaz.BackColor = System.Drawing.Color.LightGreen;
            this.btn_recete_yaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recete_yaz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_recete_yaz.Location = new System.Drawing.Point(537, 163);
            this.btn_recete_yaz.Margin = new System.Windows.Forms.Padding(2);
            this.btn_recete_yaz.Name = "btn_recete_yaz";
            this.btn_recete_yaz.Size = new System.Drawing.Size(116, 54);
            this.btn_recete_yaz.TabIndex = 63;
            this.btn_recete_yaz.Text = "REÇETE YAZ";
            this.btn_recete_yaz.UseVisualStyleBackColor = false;
            this.btn_recete_yaz.Click += new System.EventHandler(this.btn_recete_yaz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(359, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 62;
            this.label5.Text = "Teşhis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 61;
            this.label4.Text = "Reçete:";
            // 
            // btn_ilac_ekle
            // 
            this.btn_ilac_ekle.BackColor = System.Drawing.Color.Cyan;
            this.btn_ilac_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ilac_ekle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ilac_ekle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ilac_ekle.Location = new System.Drawing.Point(99, 180);
            this.btn_ilac_ekle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ilac_ekle.Name = "btn_ilac_ekle";
            this.btn_ilac_ekle.Size = new System.Drawing.Size(182, 37);
            this.btn_ilac_ekle.TabIndex = 61;
            this.btn_ilac_ekle.Text = "Reçeteye İlaç Ekle";
            this.btn_ilac_ekle.UseVisualStyleBackColor = false;
            this.btn_ilac_ekle.Click += new System.EventHandler(this.btn_ilac_ekle_Click);
            // 
            // tb_teshis
            // 
            this.tb_teshis.Location = new System.Drawing.Point(428, 38);
            this.tb_teshis.Multiline = true;
            this.tb_teshis.Name = "tb_teshis";
            this.tb_teshis.Size = new System.Drawing.Size(225, 101);
            this.tb_teshis.TabIndex = 1;
            // 
            // btn_kabul_iptal
            // 
            this.btn_kabul_iptal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_kabul_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kabul_iptal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kabul_iptal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_kabul_iptal.Location = new System.Drawing.Point(877, 359);
            this.btn_kabul_iptal.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kabul_iptal.Name = "btn_kabul_iptal";
            this.btn_kabul_iptal.Size = new System.Drawing.Size(145, 29);
            this.btn_kabul_iptal.TabIndex = 61;
            this.btn_kabul_iptal.Text = "Hasta Kabulu İptali";
            this.btn_kabul_iptal.UseVisualStyleBackColor = false;
            this.btn_kabul_iptal.Click += new System.EventHandler(this.btn_kabul_iptal_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(893, 9);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 62;
            this.dateTimePicker2.Value = new System.DateTime(2021, 8, 10, 2, 21, 35, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hastane.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(908, 578);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(305, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 26);
            this.label8.TabIndex = 64;
            this.label8.Text = "Sistem Saati :";
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(428, 6);
            this.lbl_saat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(78, 33);
            this.lbl_saat.TabIndex = 65;
            this.lbl_saat.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(712, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 19);
            this.label9.TabIndex = 67;
            this.label9.Text = "Randevu gününü değiştir :";
            // 
            // DoktorEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 704);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.btn_kabul_iptal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox3);
            this.Name = "DoktorEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DoktorEkran";
            this.Load += new System.EventHandler(this.DoktorEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox adagore;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_bugun_randevu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_hasta_kabul;
        private System.Windows.Forms.Button btn_ilac_ekle;
        private System.Windows.Forms.TextBox tb_teshis;
        private System.Windows.Forms.Button btn_kabul_iptal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_recete_yaz;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button include_completed_randevu;
        private System.Windows.Forms.Button btn_ilac_sil;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lb_gecen_randevu_sayisi;
        private System.Windows.Forms.Label lb_bekleyen_randevu_sayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
    }
}