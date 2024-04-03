namespace Hastane
{
    partial class Randevu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevu));
            this.hastaKayit = new System.Windows.Forms.Button();
            this.hastaOku = new System.Windows.Forms.Button();
            this.duzenleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbbrans = new System.Windows.Forms.ComboBox();
            this.cbdrad = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rfid_No = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.randevusaat = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboPorts = new System.Windows.Forms.ComboBox();
            this.baglantiAc = new System.Windows.Forms.Button();
            this.comboBaund = new System.Windows.Forms.ComboBox();
            this.sinyal = new System.Windows.Forms.Button();
            this.labelDurum = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.randevugoster = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.randevuver = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.randevusilButton = new System.Windows.Forms.Button();
            this.portkontrol = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.randevular = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // hastaKayit
            // 
            this.hastaKayit.BackColor = System.Drawing.Color.Chartreuse;
            this.hastaKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hastaKayit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaKayit.Location = new System.Drawing.Point(182, 10);
            this.hastaKayit.Margin = new System.Windows.Forms.Padding(2);
            this.hastaKayit.Name = "hastaKayit";
            this.hastaKayit.Size = new System.Drawing.Size(123, 51);
            this.hastaKayit.TabIndex = 0;
            this.hastaKayit.Text = "HASTA KAYDI";
            this.hastaKayit.UseVisualStyleBackColor = false;
            this.hastaKayit.Click += new System.EventHandler(this.hastaKayit_Click);
            // 
            // hastaOku
            // 
            this.hastaOku.BackColor = System.Drawing.Color.Yellow;
            this.hastaOku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hastaOku.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaOku.Location = new System.Drawing.Point(310, 10);
            this.hastaOku.Margin = new System.Windows.Forms.Padding(2);
            this.hastaOku.Name = "hastaOku";
            this.hastaOku.Size = new System.Drawing.Size(123, 51);
            this.hastaOku.TabIndex = 1;
            this.hastaOku.Text = "HASTA OKU";
            this.hastaOku.UseVisualStyleBackColor = false;
            this.hastaOku.Click += new System.EventHandler(this.hastaOku_Click);
            // 
            // duzenleButton
            // 
            this.duzenleButton.BackColor = System.Drawing.Color.Cornsilk;
            this.duzenleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duzenleButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duzenleButton.Location = new System.Drawing.Point(437, 10);
            this.duzenleButton.Margin = new System.Windows.Forms.Padding(2);
            this.duzenleButton.Name = "duzenleButton";
            this.duzenleButton.Size = new System.Drawing.Size(123, 51);
            this.duzenleButton.TabIndex = 2;
            this.duzenleButton.Text = "HASTA DÜZENLE";
            this.duzenleButton.UseVisualStyleBackColor = false;
            this.duzenleButton.Click += new System.EventHandler(this.duzenleButton_Click);
            // 
            // silButton
            // 
            this.silButton.BackColor = System.Drawing.Color.Red;
            this.silButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silButton.Location = new System.Drawing.Point(565, 10);
            this.silButton.Margin = new System.Windows.Forms.Padding(2);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(123, 51);
            this.silButton.TabIndex = 3;
            this.silButton.Text = "HASTA SİL";
            this.silButton.UseVisualStyleBackColor = false;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1280, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "POLİKİNLİK EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1148, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "DOKTOR KAYIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cornsilk;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(991, 58);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "DOKTOR LİSTE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbbrans
            // 
            this.cbbrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbbrans.FormattingEnabled = true;
            this.cbbrans.Location = new System.Drawing.Point(18, 41);
            this.cbbrans.Margin = new System.Windows.Forms.Padding(2);
            this.cbbrans.Name = "cbbrans";
            this.cbbrans.Size = new System.Drawing.Size(165, 26);
            this.cbbrans.TabIndex = 8;
            this.cbbrans.SelectedIndexChanged += new System.EventHandler(this.cbbrans_SelectedIndexChanged);
            // 
            // cbdrad
            // 
            this.cbdrad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbdrad.FormattingEnabled = true;
            this.cbdrad.Location = new System.Drawing.Point(18, 93);
            this.cbdrad.Margin = new System.Windows.Forms.Padding(2);
            this.cbdrad.Name = "cbdrad";
            this.cbdrad.Size = new System.Drawing.Size(165, 26);
            this.cbdrad.TabIndex = 9;
            this.cbdrad.SelectedIndexChanged += new System.EventHandler(this.cbdrad_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(968, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(156, 200);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Polikinlikler";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 18);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(138, 176);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.rfid_No);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(9, 229);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(145, 311);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hasta Bilgileri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(56, 284);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(29, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 18);
            this.label8.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(29, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 18);
            this.label7.TabIndex = 21;
            // 
            // rfid_No
            // 
            this.rfid_No.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rfid_No.Location = new System.Drawing.Point(7, 43);
            this.rfid_No.Margin = new System.Windows.Forms.Padding(2);
            this.rfid_No.Name = "rfid_No";
            this.rfid_No.ReadOnly = true;
            this.rfid_No.Size = new System.Drawing.Size(134, 27);
            this.rfid_No.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "TC:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 77);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(29, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Hasta Fotoğrafı";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.randevusaat);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(167, 320);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(1136, 210);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu Saatleri";
            // 
            // randevusaat
            // 
            this.randevusaat.Location = new System.Drawing.Point(4, 23);
            this.randevusaat.Margin = new System.Windows.Forms.Padding(2);
            this.randevusaat.Name = "randevusaat";
            this.randevusaat.Padding = new System.Windows.Forms.Padding(2);
            this.randevusaat.Size = new System.Drawing.Size(1117, 183);
            this.randevusaat.TabIndex = 9;
            this.randevusaat.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboPorts);
            this.groupBox1.Controls.Add(this.baglantiAc);
            this.groupBox1.Controls.Add(this.comboBaund);
            this.groupBox1.Controls.Add(this.sinyal);
            this.groupBox1.Controls.Add(this.labelDurum);
            this.groupBox1.Location = new System.Drawing.Point(9, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(145, 156);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Portlar";
            // 
            // comboPorts
            // 
            this.comboPorts.FormattingEnabled = true;
            this.comboPorts.Location = new System.Drawing.Point(21, 26);
            this.comboPorts.Margin = new System.Windows.Forms.Padding(2);
            this.comboPorts.Name = "comboPorts";
            this.comboPorts.Size = new System.Drawing.Size(92, 21);
            this.comboPorts.TabIndex = 0;
            // 
            // baglantiAc
            // 
            this.baglantiAc.Location = new System.Drawing.Point(21, 75);
            this.baglantiAc.Margin = new System.Windows.Forms.Padding(2);
            this.baglantiAc.Name = "baglantiAc";
            this.baglantiAc.Size = new System.Drawing.Size(91, 33);
            this.baglantiAc.TabIndex = 4;
            this.baglantiAc.Text = "button1";
            this.baglantiAc.UseVisualStyleBackColor = true;
            this.baglantiAc.Click += new System.EventHandler(this.baglantiAc_Click);
            // 
            // comboBaund
            // 
            this.comboBaund.Enabled = false;
            this.comboBaund.FormattingEnabled = true;
            this.comboBaund.Location = new System.Drawing.Point(21, 50);
            this.comboBaund.Margin = new System.Windows.Forms.Padding(2);
            this.comboBaund.Name = "comboBaund";
            this.comboBaund.Size = new System.Drawing.Size(92, 21);
            this.comboBaund.TabIndex = 1;
            // 
            // sinyal
            // 
            this.sinyal.Location = new System.Drawing.Point(21, 113);
            this.sinyal.Margin = new System.Windows.Forms.Padding(2);
            this.sinyal.Name = "sinyal";
            this.sinyal.Size = new System.Drawing.Size(22, 24);
            this.sinyal.TabIndex = 3;
            this.sinyal.UseVisualStyleBackColor = true;
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.Location = new System.Drawing.Point(50, 119);
            this.labelDurum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(35, 13);
            this.labelDurum.TabIndex = 2;
            this.labelDurum.Text = "label1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dateTimePicker1);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.cbbrans);
            this.groupBox6.Controls.Add(this.cbdrad);
            this.groupBox6.Controls.Add(this.randevugoster);
            this.groupBox6.Location = new System.Drawing.Point(171, 69);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(207, 237);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Polikinlikler";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 148);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 23);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "RANDEVU GÜNÜ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "DOKRORLAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "POLİKİNLİK";
            // 
            // randevugoster
            // 
            this.randevugoster.BackColor = System.Drawing.Color.Orange;
            this.randevugoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randevugoster.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevugoster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.randevugoster.Location = new System.Drawing.Point(19, 179);
            this.randevugoster.Margin = new System.Windows.Forms.Padding(2);
            this.randevugoster.Name = "randevugoster";
            this.randevugoster.Size = new System.Drawing.Size(162, 48);
            this.randevugoster.TabIndex = 19;
            this.randevugoster.Text = "Randevu Saatlerini Göster";
            this.randevugoster.UseVisualStyleBackColor = false;
            this.randevugoster.Click += new System.EventHandler(this.randevugoster_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 187);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(203, 163);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 18;
            this.dateTimePicker2.Visible = false;
            // 
            // randevuver
            // 
            this.randevuver.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.randevuver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.randevuver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randevuver.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevuver.Location = new System.Drawing.Point(396, 246);
            this.randevuver.Margin = new System.Windows.Forms.Padding(2);
            this.randevuver.Name = "randevuver";
            this.randevuver.Size = new System.Drawing.Size(112, 60);
            this.randevuver.TabIndex = 20;
            this.randevuver.Text = "Randevu Ver";
            this.randevuver.UseVisualStyleBackColor = false;
            this.randevuver.Click += new System.EventHandler(this.randevuver_Click);
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(278, 364);
            this.ad.Margin = new System.Windows.Forms.Padding(2);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(76, 20);
            this.ad.TabIndex = 21;
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(278, 387);
            this.soyad.Margin = new System.Windows.Forms.Padding(2);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(76, 20);
            this.soyad.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(278, 411);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(278, 436);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 20);
            this.textBox5.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(358, 396);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(-60, 552);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 266);
            this.dataGridView1.TabIndex = 26;
            // 
            // randevusilButton
            // 
            this.randevusilButton.BackColor = System.Drawing.Color.Red;
            this.randevusilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randevusilButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevusilButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.randevusilButton.Location = new System.Drawing.Point(1286, 621);
            this.randevusilButton.Margin = new System.Windows.Forms.Padding(2);
            this.randevusilButton.Name = "randevusilButton";
            this.randevusilButton.Size = new System.Drawing.Size(137, 64);
            this.randevusilButton.TabIndex = 27;
            this.randevusilButton.Text = "Seçili Randevuyu Sil";
            this.randevusilButton.UseVisualStyleBackColor = false;
            this.randevusilButton.Click += new System.EventHandler(this.randevusilButton_Click);
            // 
            // portkontrol
            // 
            this.portkontrol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.portkontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portkontrol.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portkontrol.Location = new System.Drawing.Point(30, 14);
            this.portkontrol.Margin = new System.Windows.Forms.Padding(2);
            this.portkontrol.Name = "portkontrol";
            this.portkontrol.Size = new System.Drawing.Size(105, 46);
            this.portkontrol.TabIndex = 28;
            this.portkontrol.Text = "PORT DİNLE";
            this.portkontrol.UseVisualStyleBackColor = false;
            this.portkontrol.Click += new System.EventHandler(this.portkontrol_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView3);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(1133, 106);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(285, 200);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(5, 17);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(273, 177);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cornsilk;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(991, 14);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 41);
            this.button4.TabIndex = 32;
            this.button4.Text = "HASTA LİSTESİ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // randevular
            // 
            this.randevular.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.randevular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randevular.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevular.ForeColor = System.Drawing.SystemColors.MenuText;
            this.randevular.Location = new System.Drawing.Point(1286, 552);
            this.randevular.Margin = new System.Windows.Forms.Padding(2);
            this.randevular.Name = "randevular";
            this.randevular.Size = new System.Drawing.Size(137, 64);
            this.randevular.TabIndex = 33;
            this.randevular.Text = "Randevular";
            this.randevular.UseVisualStyleBackColor = false;
            this.randevular.Click += new System.EventHandler(this.randevular_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(673, 244);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 29);
            this.label10.TabIndex = 47;
            this.label10.Text = "ÖZEL X HASTANESİ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(674, 287);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 29);
            this.button5.TabIndex = 38;
            this.button5.Text = "Otomasyonu Yenile";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hastane.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(621, 34);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(301, 239);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 834);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.randevular);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.portkontrol);
            this.Controls.Add(this.randevusilButton);
            this.Controls.Add(this.randevuver);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.duzenleButton);
            this.Controls.Add(this.hastaOku);
            this.Controls.Add(this.hastaKayit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Randevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID Hastane Otomasyonu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hastaKayit;
        private System.Windows.Forms.Button hastaOku;
        private System.Windows.Forms.Button duzenleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbbrans;
        private System.Windows.Forms.ComboBox cbdrad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboPorts;
        private System.Windows.Forms.Button baglantiAc;
        private System.Windows.Forms.ComboBox comboBaund;
        private System.Windows.Forms.Button sinyal;
        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rfid_No;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button randevugoster;
        private System.Windows.Forms.GroupBox randevusaat;
        private System.Windows.Forms.Button randevuver;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button randevusilButton;
        private System.Windows.Forms.Button portkontrol;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button randevular;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
    }
}

