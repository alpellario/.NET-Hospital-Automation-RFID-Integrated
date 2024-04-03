using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.OleDb;
using System.IO;

namespace Hastane
{
    public partial class HastaKayit : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
          + Application.StartupPath + "\\veritabani.mdb");
        OleDbCommand komut = new OleDbCommand();

        DataTable kontrol = new DataTable();

        string[] portlar = SerialPort.GetPortNames();
        public HastaKayit()
        {
            InitializeComponent();
            baglantiAc.Text = "Bağlantı Aç";
            baglantiAc.BackColor = Color.Yellow;
            groupBox1.Text = "BAĞLANTI";
            rfid_No.ForeColor = Color.Red;
            groupBox2.Text = "Hasta Bilgileri";
            groupBox2.Enabled = false;
            cbcinsiyet.Items.Add("ERKEK");
            cbcinsiyet.Items.Add("KADIN");
            cbcinsiyet.SelectedIndex = -1;

            iptalButton.Text = "İPTAL";

            iptalButton.BackColor = Color.Red;
            iptalButton.ForeColor = Color.White;
        }

        private void HastaKayit_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            foreach (string port in portlar)
            {
                comboPorts.Items.Add(port);
                comboPorts.SelectedIndex = 0;
            }
            comboBaund.Items.Add("9600");
            comboBaund.SelectedIndex = 0;
            sinyal.BackColor = Color.Red;
            labelDurum.Text = "Bağlantı Kapalı";
            dateTimePicker1.Text = DateTime.Today.ToShortDateString();
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
          + Application.StartupPath + "\\veritabani.mdb");
            cmd = new OleDbCommand();
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM iller";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cm_iller.Items.Add(dr["il"]);
            }
            con.Close();
        }

        private void baglantiAc_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                if (comboPorts.Text == "") return;
                serialPort1.PortName = comboPorts.Text;
                serialPort1.BaudRate = Convert.ToInt16(comboBaund.Text);
                try
                {
                    serialPort1.Open();
                    serialPort1.Write("1");
                    labelDurum.Text = "Bağlantı Açık";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                serialPort1.Write("1");
                labelDurum.Text = "Bağlantı Kuruldu.";
            }
            if (serialPort1.IsOpen == true)
            {
                groupBox2.Enabled = true;
                sinyal.BackColor = Color.Green;
            }
        }

        private void HastaKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("0");
                serialPort1.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort1.ReadExisting();
            rfid_No.Text = data;
            serialPort1.Write("1");

            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            kontrol.Rows.Clear();
            OleDbCommand rfidOku = new OleDbCommand("select *from Hastalar", baglanti);
            OleDbDataReader rfidControl = rfidOku.ExecuteReader();
            kontrol.Load(rfidControl);
            for (int rfc = 0; rfc < kontrol.Rows.Count; rfc++)
            {
                if (rfid_No.Text == kontrol.Rows[rfc][0].ToString())
                {
                    string fullName = kontrol.Rows[rfc][2].ToString() + " " + kontrol.Rows[rfc][3].ToString();
                    MessageBox.Show("Bu kart "+ fullName + " adlı hastaya ait.\nFarklı bir kart deneyiniz!");
                    baglanti.Close();
                    this.Close();
                }
            }
            baglanti.Close();

        }

        private void tbtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);


            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbtel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);


            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void tbsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void tbanneadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
        }

        private void tbbabaadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
        }
        string dosyaYolu;
        string dosyaAdi;
        private void resimekle_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = Application.StartupPath + "\\resimler\\";
                DialogResult sonuc = openFileDialog1.ShowDialog();
                dosyaYolu = openFileDialog1.FileName;
                pictureBox1.ImageLocation = dosyaYolu;

                //dosyaAdi = Path.GetFileName(dosyaYolu);

            }
            catch { }
        }

        protected override CreateParams CreateParams//Form titremesini önler...
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }

        }


        private void hasta_Kayit_Click(object sender, EventArgs e)
        {
            if (rfid_No.Text != "")
            {
                bool tc_varmi = false;
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                kontrol.Rows.Clear();
                OleDbCommand tcoku = new OleDbCommand("select * from Hastalar", baglanti);
                OleDbDataReader tckontrol = tcoku.ExecuteReader();
                kontrol.Load(tckontrol);
                for (int tcs = 0; tcs < kontrol.Rows.Count; tcs++)
                {
                    if (tbtc.Text == kontrol.Rows[tcs][1].ToString())
                    {
                        tc_varmi = true;
                        string fullName = kontrol.Rows[tcs][2].ToString() + " " + kontrol.Rows[tcs][3].ToString();
                        MessageBox.Show("Bu TC Kimlik Numarası " + fullName + " adlı hastaya ait");
                    }
                }
                if (tc_varmi != true)
                {
                    if (pictureBox1.ImageLocation != null)
                    {
                        if (tbtc.Text != "" && tbtel.Text != "")
                        {

                            if (tbad.Text != "" && tbsoyad.Text != "" && cbcinsiyet.SelectedIndex != -1)
                            {
                                string kaynak = dosyaYolu;
                                string hedef = Application.StartupPath + @"\resimler\";
                                string yeniad = Guid.NewGuid() + ".jpg"; //Benzersiz isim verme
                                dosyaAdi = yeniad;
                                File.Copy(kaynak, hedef + yeniad);

                                DataSet ds = new DataSet();
                                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                                komut.Connection = baglanti;
                                komut.CommandText = "insert into Hastalar (rfid_id,islemtarih,tckimlikno,ad,soyad,cinsiyet,babaadi,anneadi,dogumtarih,telefonno,adres,resim,dogumyeri) VALUES (@rfid_id,@islemtarih,@tckimlikno,@ad,@soyad,@cinsiyet,@babaadi,@anneadi,@dogumtarih,@telefonno,@adres,@resim,@dogumyeri)";
                                komut.Parameters.AddWithValue("@rfid_id", rfid_No.Text);
                                komut.Parameters.AddWithValue("@islemtarih", dateTimePicker1.Value.ToShortDateString());
                                komut.Parameters.AddWithValue("@tckimlikno", tbtc.Text);
                                komut.Parameters.AddWithValue("@ad", tbad.Text);
                                komut.Parameters.AddWithValue("@soyad", tbsoyad.Text);
                                komut.Parameters.AddWithValue("@cinsiyet", cbcinsiyet.Text);
                                komut.Parameters.AddWithValue("@babaadi", tbbabaadi.Text);
                                komut.Parameters.AddWithValue("@anneadi", tbanneadi.Text);
                                komut.Parameters.AddWithValue("@dogumtarih", dateTimePicker2.Value.ToShortDateString());
                                komut.Parameters.AddWithValue("@telefonno", tbtel.Text);
                                komut.Parameters.AddWithValue("@adres", tbadres.Text);
                                komut.Parameters.AddWithValue("@resim", dosyaAdi);
                                komut.Parameters.AddWithValue("@dogumyeri", cm_iller.Text);


                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Hasta Kayıtı Yapıldı!");

                                this.Close();
                            }
                            else MessageBox.Show("Ad, soyad ve cinsiyet bölümleri boş bırakılamaz");

                        }
                        else MessageBox.Show("TC Kimlik ve Telefon bilgileri boş bırakılamaz");
                    }
                    else MessageBox.Show("Lütfen bir resim seçiniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen kayıt işlemi için boş bir kart okutunuz.");
            }

        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath + ' ' + dosyaAdi);
        }
    }
}
