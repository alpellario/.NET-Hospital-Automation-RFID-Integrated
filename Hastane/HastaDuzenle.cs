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
namespace Hastane
{
    public partial class HastaDuzenle : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
          + Application.StartupPath + "\\veritabani.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbCommand komut2 = new OleDbCommand();

        string[] portlar = SerialPort.GetPortNames();

        DataTable kontrol = new DataTable();
        public HastaDuzenle()
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
            //hasta_Kayit.Text = "Hasta Kaydet";
            //iptalButton.Text = "İPTAL";
            //hasta_Kayit.BackColor = Color.LightGreen;
            //iptalButton.BackColor = Color.Red;
            //iptalButton.ForeColor = Color.White;
        }

        private void HastaDuzenle_Load(object sender, EventArgs e)
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

        private void HastaDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("0");
                serialPort1.Close();
            }
        }
        string eskitc;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            bool varmi = false;
            string data = serialPort1.ReadExisting();
            rfid_No.Text = data;
            serialPort1.Write("1");



            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
          + Application.StartupPath + "\\veritabani.mdb");
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();

            DataTable dt = new DataTable();
            OleDbCommand rfid = new OleDbCommand("select * from Hastalar WHERE rfid_id=@rfid_id", baglanti);
            rfid.Parameters.AddWithValue("@rfid_id", rfid_No.Text);
            OleDbDataReader rfidControl = rfid.ExecuteReader();
            dt.Load(rfidControl);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                tbtc.Text = dr["tckimlikno"].ToString();
                tbad.Text = dr["ad"].ToString();
                tbsoyad.Text = dr["soyad"].ToString();
                cbcinsiyet.Text = dr["cinsiyet"].ToString();
                tbbabaadi.Text = dr["babaadi"].ToString();
                tbanneadi.Text = dr["anneadi"].ToString();
                dateTimePicker2.Text = dr["dogumtarih"].ToString();
                tbtel.Text = dr["telefonno"].ToString();
                tbadres.Text = dr["adres"].ToString();
                cm_iller.Text = dr["dogumyeri"].ToString();
                textBox1.Text = dr["resim"].ToString();
                pictureBox1.Load(Application.StartupPath + "\\resimler\\" + textBox1.Text);
                eskitc = tbtc.Text;

            }else
            {
                MessageBox.Show("Kart Kayıtlı Değil! Hasta Kaydı Yapınız!");
                baglanti.Close();
                this.Close();
            }

            baglanti.Close();

        }

        private void resimekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\resimler\\";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
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

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            if (rfid_No.Text != "")
            {

            }
            bool tc_varmi = false;

            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
          + Application.StartupPath + "\\veritabani.mdb");

            if (baglanti.State == ConnectionState.Closed) baglanti.Open();

            OleDbCommand tcoku = new OleDbCommand("select *from Hastalar", baglanti);
            OleDbDataReader tckontrol = tcoku.ExecuteReader();
            DataTable kontrol = new DataTable();
            kontrol.Load(tckontrol);
            for (int tcs = 0; tcs < kontrol.Rows.Count; tcs++)
            {
                if (tbtc.Text == kontrol.Rows[tcs][1].ToString())
                {
                    if (kontrol.Rows[tcs][0].ToString() != rfid_No.Text)
                    {
                        
                        tc_varmi = true;
                    }
                    
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
                            DataSet ds = new DataSet();
                            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                            komut.Connection = baglanti;
                            komut.CommandText = "UPDATE Hastalar SET tckimlikno=@tckimlikno,ad=@ad,soyad=@soyad,cinsiyet=@cinsiyet,babaadi=@babaadi,anneadi=@anneadi,dogumtarih=@dogumtarih,telefonno=@telefonno,adres=@adres,resim=@resim,dogumyeri=@dogumyeri WHERE rfid_id=@rfid_id";
                            komut.Parameters.AddWithValue("@tckimlikno", tbtc.Text);
                            komut.Parameters.AddWithValue("@ad", tbad.Text);
                            komut.Parameters.AddWithValue("@soyad", tbsoyad.Text);
                            komut.Parameters.AddWithValue("@cinsiyet", cbcinsiyet.Text);
                            komut.Parameters.AddWithValue("@babaadi", tbbabaadi.Text);
                            komut.Parameters.AddWithValue("@anneadi", tbanneadi.Text);
                            komut.Parameters.AddWithValue("@dogumtarih", dateTimePicker2.Value.ToShortDateString());
                            komut.Parameters.AddWithValue("@telefonno", tbtel.Text);
                            komut.Parameters.AddWithValue("@adres", tbadres.Text);
                            komut.Parameters.AddWithValue("@resim", textBox1.Text);
                            komut.Parameters.AddWithValue("@dogumyeri", cm_iller.Text);
                            komut.Parameters.AddWithValue("@rfid_id", rfid_No.Text);
                            komut.ExecuteNonQuery();

                            DataSet ds2 = new DataSet();
                            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                            komut2.Connection = baglanti;
                            komut2.CommandText = "UPDATE randevular SET tc=@tc,ad=@ad,soyad=@soyad,cinsiyet=@cinsiyet WHERE tc=@tceski";
                            komut2.Parameters.AddWithValue("@tckimlikno", tbtc.Text);
                            komut2.Parameters.AddWithValue("@ad", tbad.Text);
                            komut2.Parameters.AddWithValue("@soyad", tbsoyad.Text);
                            komut2.Parameters.AddWithValue("@cinsiyet", cbcinsiyet.Text);

                            komut2.Parameters.AddWithValue("@tceski", eskitc);
                            komut2.ExecuteNonQuery();


                            baglanti.Close();
                            MessageBox.Show("Hasta Güncellendi!");


                            this.Close();
                        }
                        else MessageBox.Show("Ad, soyad ve cinsiyet bölümleri boş bırakılamaz");

                    }
                    else MessageBox.Show("TC Kimlik ve Telefon bilgileri boş bırakılamaz");
                }
                else MessageBox.Show("Lütfen bir resim seçiniz");
            }
            else MessageBox.Show("Bu TC Kimlik Numarası başka bir hastaya ait.");


        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
