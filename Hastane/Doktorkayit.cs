using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Hastane
{
    public partial class Doktorkayit : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
         + Application.StartupPath + "\\veritabani.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbCommand komut2 = new OleDbCommand();
        OleDbCommand komut3 = new OleDbCommand();
        OleDbCommand komut4 = new OleDbCommand();
        OleDbCommand komut5 = new OleDbCommand();
        OleDbCommand komut6 = new OleDbCommand();
        public Doktorkayit()
        {

            InitializeComponent();
        }
        public static string dr_id = "";
        public static string dr_pw = "";
        public static bool kayit_basarili = false;
        private void doktorKaydet_Click(object sender, EventArgs e)
        {
            bool tc_varmi = false;
            DataTable kontrol = new DataTable();
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            kontrol.Rows.Clear();
            OleDbCommand tcoku = new OleDbCommand("SELECT * FROM doktorlar", baglanti);
            OleDbDataReader tcKontrol = tcoku.ExecuteReader();
            kontrol.Load(tcKontrol);
            for (int i = 0; i < kontrol.Rows.Count; i++)
            {
                if (tbdrtc.Text == kontrol.Rows[i][0].ToString())
                {
                    tc_varmi = true;
                    MessageBox.Show("Bu TC Kimlik numarası başka bir doktora ait");
                }
            }
            if (tc_varmi == false)
            {
                if (pictureBox1.ImageLocation != null)
                {
                    if (tbdrtc.Text != "" && tbdrtel.Text != "")
                    {
                        if (cbdrbrans.Text != "")
                        {

                            if (tbdrad.Text != "" && tbdrsoyad.Text != "" && cbdrcinsiyet.SelectedIndex != -1)
                            {
                                if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "")
                                {
                                    if (numericUpDown2.Value.ToString() != "" && Convert.ToInt32(numericUpDown2.Value.ToString()) > 5)
                                    {
                                        doktorCreateAccount dCA = new doktorCreateAccount();
                                        dCA.ShowDialog();
                                        if (kayit_basarili == true)
                                        {
                                            string kaynak = dosyaYolu;
                                            string hedef = Application.StartupPath + @"\resimler\";
                                            string yeniad = Guid.NewGuid() + ".jpg"; //Benzersiz isim verme
                                            dosyaAdi = yeniad;
                                            File.Copy(kaynak, hedef + yeniad);

                                            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                                            komut.Connection = baglanti;
                                            komut.CommandText = "insert into doktorlar (doktortc,doktorad,doktorsoyad,doktorcinsiyet,doktorbrans,doktordogum,doktortelefon,doktorkayit,doktorresim,dr_id) VALUES (@doktortc,@doktorad,@doktorsoyad,@doktorcinsiyet,@doktorbrans,@doktordogum,@doktortelefon,@doktorkayit,@doktorresim,@dr_id)";
                                            komut.Parameters.AddWithValue("@doktortc", tbdrtc.Text);
                                            komut.Parameters.AddWithValue("@doktorad", tbdrad.Text);
                                            komut.Parameters.AddWithValue("@doktorsoyad", tbdrsoyad.Text);
                                            komut.Parameters.AddWithValue("@doktorcinsiyet", cbdrcinsiyet.Text);
                                            komut.Parameters.AddWithValue("@doktorbrans", cbdrbrans.Text);
                                            komut.Parameters.AddWithValue("@doktordogum", dateTimePicker1.Value.ToShortDateString());
                                            komut.Parameters.AddWithValue("@doktortelefon", tbdrtel.Text);
                                            komut.Parameters.AddWithValue("@doktorkayit", dateTimePicker2.Value.ToShortDateString());
                                            komut.Parameters.AddWithValue("@doktorresim", dosyaAdi);
                                            komut.Parameters.AddWithValue("@dr_id", cbdrbrans.SelectedValue.ToString());
                                            komut.ExecuteNonQuery();

                                            komut.CommandText = "SELECT @@IDENTITY";
                                            int return_dr_id = Convert.ToInt32(komut.ExecuteScalar().ToString());

                                            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                                            komut2.Connection = baglanti;
                                            komut2.CommandText = "insert into drsaat (drad,saatbas,saatson,aralik,basdk,sondk,drtc,drbolum) VALUES (@drad,@saatbas,@saatson,@aralik,@basdk,@sondk,@drtc,@drbolum) ";
                                            komut2.Parameters.AddWithValue("@drad", tbdrad.Text + " " + tbdrsoyad.Text);
                                            komut2.Parameters.AddWithValue("@saatbas", comboBox1.Text);
                                            komut2.Parameters.AddWithValue("@saatson", comboBox3.Text);
                                            komut2.Parameters.AddWithValue("@aralik", numericUpDown2.Value.ToString());

                                            komut2.Parameters.AddWithValue("@basdk", comboBox2.Text);
                                            komut2.Parameters.AddWithValue("@sondk", comboBox4.Text);

                                            komut2.Parameters.AddWithValue("@drtc", tbdrtc.Text);
                                            komut2.Parameters.AddWithValue("@drbolum", cbdrbrans.Text);
                                            komut2.ExecuteNonQuery();

                                            komut3.Connection = baglanti;
                                            komut3.CommandText = "insert into doktor_login(doktor_id,doktor_kullanici_adi,doktor_sifre) VALUES (@doktor_id,@doktor_kullanici_adi,@doktor_sifre)";
                                            komut3.Parameters.AddWithValue("@doktor_id", return_dr_id);
                                            komut3.Parameters.AddWithValue("@doktor_kullanici_adi", dr_id);
                                            komut3.Parameters.AddWithValue("@doktor_sifre", dr_pw);
                                            komut3.ExecuteNonQuery();


                                            baglanti.Close();

                                            MessageBox.Show("Doktor Kayıtı Yapıldı!");
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Kayıt oluşturulmadı.");
                                        }


                                    }
                                    else MessageBox.Show("Çalışma saatleri arasındaki aralık 5 dakikadan küçük olamaz");

                                }
                                else MessageBox.Show("Doktora ait çalışma saatleri seçimi boş bırakılamaz");

                            }
                            else MessageBox.Show("Ad, soyad ve cinsiyet bölümleri boş bırakılamaz");
                        }
                        else MessageBox.Show("Branşı Seçiniz");
                    }
                    else MessageBox.Show("TC Kimlik ve Telefon bilgileri boş bırakılamaz");
                }
                else MessageBox.Show("Lütfen bir resim seçiniz");
            }

        }

        private void Doktorkayit_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;




            dateTimePicker2.Text = DateTime.Today.ToShortDateString();
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();

            DataTable dt = new DataTable();

            OleDbDataAdapter da = new OleDbDataAdapter("select * from branslar ", baglanti);
            da.Fill(dt);
            cbdrbrans.DisplayMember = "brans";
            cbdrbrans.ValueMember = "kimlik";
            cbdrbrans.DataSource = dt;
            for (int saat = 9; saat < 19; saat++)
            {
                if (saat != 12 && saat != 13)
                {
                    comboBox1.Items.Add(saat);


                }
                else { }
            }
            comboBox1.SelectedIndex = 0;
            comboBox3.SelectedIndex = 3;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            for (int dk = 0; dk < 60; dk++)
            {
                if (dk >= 10)
                {
                    comboBox2.Items.Add(dk);
                    comboBox2.SelectedIndex = 0;
                }
                else
                {
                    if (dk == 0) comboBox2.Items.Add("00");
                    if (dk == 1) comboBox2.Items.Add("01");
                    if (dk == 2) comboBox2.Items.Add("02");
                    if (dk == 3) comboBox2.Items.Add("03");
                    if (dk == 4) comboBox2.Items.Add("04");
                    if (dk == 5) comboBox2.Items.Add("05");
                    if (dk == 6) comboBox2.Items.Add("06");
                    if (dk == 7) comboBox2.Items.Add("07");
                    if (dk == 8) comboBox2.Items.Add("08");
                    if (dk == 9) comboBox2.Items.Add("09");


                }
                comboBox3.Items.Clear();
                for (int a = int.Parse(comboBox1.Text); a < 19; a++)
                {
                    a++;
                    if (a != 12 && a != 13)
                    {
                        comboBox3.Items.Add(a);


                    }
                    else { }
                }

            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            for (int dk = 0; dk < 60; dk++)
            {
                if (dk >= 10)
                {
                    comboBox4.Items.Add(dk);
                    comboBox4.SelectedIndex = 0;
                }
                else
                {
                    if (dk == 0) comboBox4.Items.Add("00");
                    if (dk == 1) comboBox4.Items.Add("01");
                    if (dk == 2) comboBox4.Items.Add("02");
                    if (dk == 3) comboBox4.Items.Add("03");
                    if (dk == 4) comboBox4.Items.Add("04");
                    if (dk == 5) comboBox4.Items.Add("05");
                    if (dk == 6) comboBox4.Items.Add("06");
                    if (dk == 7) comboBox4.Items.Add("07");
                    if (dk == 8) comboBox4.Items.Add("08");
                    if (dk == 9) comboBox4.Items.Add("09");



                }

            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {





        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbdrtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);


            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbdrad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
        }

        private void tbdrsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
        }

        private void tbdrtel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);


            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
            }
            catch { }
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
