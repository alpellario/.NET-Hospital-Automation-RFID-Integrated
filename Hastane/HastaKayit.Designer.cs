namespace Hastane
{
    partial class HastaKayit
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.hasta_Kayit = new System.Windows.Forms.Button();
            this.iptalButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelDurum = new System.Windows.Forms.Label();
            this.sinyal = new System.Windows.Forms.Button();
            this.comboBaund = new System.Windows.Forms.ComboBox();
            this.baglantiAc = new System.Windows.Forms.Button();
            this.comboPorts = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rfid_No = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbadres = new System.Windows.Forms.TextBox();
            this.tbtel = new System.Windows.Forms.TextBox();
            this.tbbabaadi = new System.Windows.Forms.TextBox();
            this.tbanneadi = new System.Windows.Forms.TextBox();
            this.tbsoyad = new System.Windows.Forms.TextBox();
            this.tbad = new System.Windows.Forms.TextBox();
            this.tbtc = new System.Windows.Forms.TextBox();
            this.cbcinsiyet = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resimekle = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cm_iller = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // hasta_Kayit
            // 
            this.hasta_Kayit.BackColor = System.Drawing.Color.SpringGreen;
            this.hasta_Kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hasta_Kayit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta_Kayit.Location = new System.Drawing.Point(432, 425);
            this.hasta_Kayit.Margin = new System.Windows.Forms.Padding(2);
            this.hasta_Kayit.Name = "hasta_Kayit";
            this.hasta_Kayit.Size = new System.Drawing.Size(146, 47);
            this.hasta_Kayit.TabIndex = 9;
            this.hasta_Kayit.Text = "HASTA KAYDET";
            this.hasta_Kayit.UseVisualStyleBackColor = false;
            this.hasta_Kayit.Click += new System.EventHandler(this.hasta_Kayit_Click);
            // 
            // iptalButton
            // 
            this.iptalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iptalButton.Location = new System.Drawing.Point(588, 425);
            this.iptalButton.Margin = new System.Windows.Forms.Padding(2);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(86, 47);
            this.iptalButton.TabIndex = 10;
            this.iptalButton.UseVisualStyleBackColor = true;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.Location = new System.Drawing.Point(52, 119);
            this.labelDurum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(35, 13);
            this.labelDurum.TabIndex = 2;
            this.labelDurum.Text = "label1";
            // 
            // sinyal
            // 
            this.sinyal.Location = new System.Drawing.Point(22, 113);
            this.sinyal.Margin = new System.Windows.Forms.Padding(2);
            this.sinyal.Name = "sinyal";
            this.sinyal.Size = new System.Drawing.Size(22, 24);
            this.sinyal.TabIndex = 3;
            this.sinyal.UseVisualStyleBackColor = true;
            // 
            // comboBaund
            // 
            this.comboBaund.Enabled = false;
            this.comboBaund.FormattingEnabled = true;
            this.comboBaund.Location = new System.Drawing.Point(22, 50);
            this.comboBaund.Margin = new System.Windows.Forms.Padding(2);
            this.comboBaund.Name = "comboBaund";
            this.comboBaund.Size = new System.Drawing.Size(92, 21);
            this.comboBaund.TabIndex = 1;
            // 
            // baglantiAc
            // 
            this.baglantiAc.Location = new System.Drawing.Point(22, 75);
            this.baglantiAc.Margin = new System.Windows.Forms.Padding(2);
            this.baglantiAc.Name = "baglantiAc";
            this.baglantiAc.Size = new System.Drawing.Size(91, 33);
            this.baglantiAc.TabIndex = 4;
            this.baglantiAc.Text = "button1";
            this.baglantiAc.UseVisualStyleBackColor = true;
            this.baglantiAc.Click += new System.EventHandler(this.baglantiAc_Click);
            // 
            // comboPorts
            // 
            this.comboPorts.FormattingEnabled = true;
            this.comboPorts.Location = new System.Drawing.Point(22, 26);
            this.comboPorts.Margin = new System.Windows.Forms.Padding(2);
            this.comboPorts.Name = "comboPorts";
            this.comboPorts.Size = new System.Drawing.Size(92, 21);
            this.comboPorts.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboPorts);
            this.groupBox1.Controls.Add(this.baglantiAc);
            this.groupBox1.Controls.Add(this.comboBaund);
            this.groupBox1.Controls.Add(this.sinyal);
            this.groupBox1.Controls.Add(this.labelDurum);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(130, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rfid_No
            // 
            this.rfid_No.Enabled = false;
            this.rfid_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rfid_No.Location = new System.Drawing.Point(196, 36);
            this.rfid_No.Margin = new System.Windows.Forms.Padding(2);
            this.rfid_No.Name = "rfid_No";
            this.rfid_No.Size = new System.Drawing.Size(143, 30);
            this.rfid_No.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(237, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "KART ID";
            // 
            // tbadres
            // 
            this.tbadres.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbadres.Location = new System.Drawing.Point(308, 332);
            this.tbadres.Margin = new System.Windows.Forms.Padding(2);
            this.tbadres.Name = "tbadres";
            this.tbadres.Size = new System.Drawing.Size(137, 23);
            this.tbadres.TabIndex = 40;
            // 
            // tbtel
            // 
            this.tbtel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbtel.Location = new System.Drawing.Point(308, 307);
            this.tbtel.Margin = new System.Windows.Forms.Padding(2);
            this.tbtel.MaxLength = 10;
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(83, 23);
            this.tbtel.TabIndex = 39;
            this.tbtel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtel_KeyPress);
            // 
            // tbbabaadi
            // 
            this.tbbabaadi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbbabaadi.Location = new System.Drawing.Point(308, 254);
            this.tbbabaadi.Margin = new System.Windows.Forms.Padding(2);
            this.tbbabaadi.Name = "tbbabaadi";
            this.tbbabaadi.Size = new System.Drawing.Size(137, 23);
            this.tbbabaadi.TabIndex = 38;
            this.tbbabaadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbbabaadi_KeyPress);
            // 
            // tbanneadi
            // 
            this.tbanneadi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbanneadi.Location = new System.Drawing.Point(308, 228);
            this.tbanneadi.Margin = new System.Windows.Forms.Padding(2);
            this.tbanneadi.Name = "tbanneadi";
            this.tbanneadi.Size = new System.Drawing.Size(137, 23);
            this.tbanneadi.TabIndex = 37;
            this.tbanneadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbanneadi_KeyPress);
            // 
            // tbsoyad
            // 
            this.tbsoyad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsoyad.Location = new System.Drawing.Point(308, 176);
            this.tbsoyad.Margin = new System.Windows.Forms.Padding(2);
            this.tbsoyad.Name = "tbsoyad";
            this.tbsoyad.Size = new System.Drawing.Size(137, 23);
            this.tbsoyad.TabIndex = 36;
            this.tbsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsoyad_KeyPress);
            // 
            // tbad
            // 
            this.tbad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbad.Location = new System.Drawing.Point(308, 149);
            this.tbad.Margin = new System.Windows.Forms.Padding(2);
            this.tbad.Name = "tbad";
            this.tbad.Size = new System.Drawing.Size(137, 23);
            this.tbad.TabIndex = 35;
            this.tbad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbad_KeyPress);
            // 
            // tbtc
            // 
            this.tbtc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbtc.Location = new System.Drawing.Point(308, 121);
            this.tbtc.Margin = new System.Windows.Forms.Padding(2);
            this.tbtc.MaxLength = 11;
            this.tbtc.Name = "tbtc";
            this.tbtc.Size = new System.Drawing.Size(137, 23);
            this.tbtc.TabIndex = 34;
            this.tbtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtc_KeyPress);
            // 
            // cbcinsiyet
            // 
            this.cbcinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcinsiyet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbcinsiyet.FormattingEnabled = true;
            this.cbcinsiyet.Location = new System.Drawing.Point(308, 202);
            this.cbcinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cbcinsiyet.Name = "cbcinsiyet";
            this.cbcinsiyet.Size = new System.Drawing.Size(137, 23);
            this.cbcinsiyet.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(218, 229);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 18);
            this.label11.TabIndex = 41;
            this.label11.Text = "ANNE ADI :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(261, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "AD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(238, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "SOYAD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(193, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "TC NUMARASI :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(220, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "BABA ADI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(225, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "CİNSİYET :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(187, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "DOĞUM TARİHİ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(154, 309);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 18);
            this.label8.TabIndex = 47;
            this.label8.Text = "TELEFON NUMARASI :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(239, 332);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 48;
            this.label9.Text = "ADRES :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(200, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 18);
            this.label10.TabIndex = 49;
            this.label10.Text = "İŞLEM TARİHİ :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(308, 94);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 5, 23, 19, 51, 25, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 23);
            this.dateTimePicker1.TabIndex = 52;
            this.dateTimePicker1.Value = new System.DateTime(2018, 5, 24, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(308, 280);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.MaxDate = new System.DateTime(2019, 3, 18, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(137, 23);
            this.dateTimePicker2.TabIndex = 53;
            this.dateTimePicker2.Value = new System.DateTime(2018, 5, 23, 0, 0, 0, 0);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(395, 311);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 15);
            this.label16.TabIndex = 54;
            this.label16.Text = "0 Girmeyiniz";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.resimekle);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(16, 68);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(148, 232);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(117, 186);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 18);
            this.label20.TabIndex = 63;
            this.label20.Text = "(*)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // resimekle
            // 
            this.resimekle.Location = new System.Drawing.Point(37, 180);
            this.resimekle.Margin = new System.Windows.Forms.Padding(2);
            this.resimekle.Name = "resimekle";
            this.resimekle.Size = new System.Drawing.Size(76, 30);
            this.resimekle.TabIndex = 13;
            this.resimekle.Text = "Resim Ekle";
            this.resimekle.UseVisualStyleBackColor = true;
            this.resimekle.Click += new System.EventHandler(this.resimekle_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Hasta Fotoğrafı";
            // 
            // cm_iller
            // 
            this.cm_iller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cm_iller.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cm_iller.FormattingEnabled = true;
            this.cm_iller.Location = new System.Drawing.Point(308, 358);
            this.cm_iller.Margin = new System.Windows.Forms.Padding(2);
            this.cm_iller.Name = "cm_iller";
            this.cm_iller.Size = new System.Drawing.Size(137, 23);
            this.cm_iller.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(201, 359);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 18);
            this.label13.TabIndex = 55;
            this.label13.Text = "DOĞUM YERİ :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cm_iller);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbcinsiyet);
            this.groupBox2.Controls.Add(this.tbtc);
            this.groupBox2.Controls.Add(this.tbad);
            this.groupBox2.Controls.Add(this.tbsoyad);
            this.groupBox2.Controls.Add(this.tbanneadi);
            this.groupBox2.Controls.Add(this.tbbabaadi);
            this.groupBox2.Controls.Add(this.tbtel);
            this.groupBox2.Controls.Add(this.tbadres);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rfid_No);
            this.groupBox2.Location = new System.Drawing.Point(168, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(508, 411);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(475, 309);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 18);
            this.label19.TabIndex = 62;
            this.label19.Text = "(*)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(449, 204);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 18);
            this.label18.TabIndex = 61;
            this.label18.Text = "(*)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(449, 178);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 18);
            this.label17.TabIndex = 60;
            this.label17.Text = "(*)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(449, 151);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 18);
            this.label15.TabIndex = 59;
            this.label15.Text = "(*)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(449, 123);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 18);
            this.label14.TabIndex = 58;
            this.label14.Text = "(*)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hastane.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(0, 342);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // HastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 481);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.iptalButton);
            this.Controls.Add(this.hasta_Kayit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HastaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HastaKayit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HastaKayit_FormClosed);
            this.Load += new System.EventHandler(this.HastaKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button hasta_Kayit;
        private System.Windows.Forms.Button iptalButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.Button sinyal;
        private System.Windows.Forms.ComboBox comboBaund;
        private System.Windows.Forms.Button baglantiAc;
        private System.Windows.Forms.ComboBox comboPorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rfid_No;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbadres;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.TextBox tbbabaadi;
        private System.Windows.Forms.TextBox tbanneadi;
        private System.Windows.Forms.TextBox tbsoyad;
        private System.Windows.Forms.TextBox tbad;
        private System.Windows.Forms.TextBox tbtc;
        private System.Windows.Forms.ComboBox cbcinsiyet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resimekle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cm_iller;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
    }
}