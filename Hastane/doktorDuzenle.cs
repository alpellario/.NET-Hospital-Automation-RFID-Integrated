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
    public partial class doktorDuzenle : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
         + Application.StartupPath + "\\veritabani.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbCommand komut2 = new OleDbCommand();
        OleDbCommand komut3 = new OleDbCommand();
        OleDbCommand komut4 = new OleDbCommand();
        OleDbCommand komut5 = new OleDbCommand();
        OleDbCommand komut6 = new OleDbCommand();
        public doktorDuzenle()
        {
            InitializeComponent();
        }
        string oldPicture;
        string imagePath;
        private void doktorDuzenle_Load(object sender, EventArgs e)
        {
            string doktorBrans = "";
            string doktorTc = DoktorListe.tc;

            doldurBransHours();

            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            DataTable tableDoctors = new DataTable();
            OleDbCommand findId = new OleDbCommand("select * from doktorlar WHERE doktortc = @doktortc", baglanti);
            findId.Parameters.AddWithValue("@doktortc", doktorTc);
            OleDbDataReader dr = findId.ExecuteReader();
            while (dr.Read())
            {
                tbdrtc.Text = dr["doktortc"].ToString();
                tbdrad.Text = dr["doktorad"].ToString();
                tbdrsoyad.Text = dr["doktorsoyad"].ToString();
                cbdrcinsiyet.Text = dr["doktorcinsiyet"].ToString();
                doktorBrans = dr["doktorbrans"].ToString();
                dateTimePicker1.Text = dr["doktordogum"].ToString();
                tbdrtel.Text = dr["doktortelefon"].ToString();
                tbdrad.Text = dr["doktorad"].ToString();
                dateTimePicker2.Text = dr["doktorkayit"].ToString();
                imagePath = Application.StartupPath + "\\resimler\\" + dr["doktorresim"].ToString();
                oldPicture = dr["doktorresim"].ToString();
                pictureBox1.Load(imagePath);

            }

            cbdrbrans.SelectedIndex = cbdrbrans.FindStringExact(doktorBrans);

            findId = new OleDbCommand("select * from drsaat WHERE drtc = @drtc", baglanti);
            findId.Parameters.AddWithValue("@drtc", doktorTc);
            dr = findId.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Text = dr["saatbas"].ToString();
                comboBox2.Text = dr["basdk"].ToString();
                comboBox3.Text = dr["saatson"].ToString();
                comboBox4.Text = dr["sondk"].ToString();
                numericUpDown2.Value = Convert.ToDecimal(dr["aralik"].ToString());
            }
            baglanti.Close();

        }

        void doldurBransHours()
        {
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
            baglanti.Close();
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
                for (int a = int.Parse(comboBox1.Text) + 1; a < 19; a++)
                {

                    if (a != 12 && a != 13)
                    {
                        comboBox3.Items.Add(a);


                    }
                    else { }
                }

            }
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

        private void doktorKaydet_Click(object sender, EventArgs e)
        {
            try
            {



                if (pictureBox1.ImageLocation != null)
                {
                    if (tbdrtc.Text != "" && tbdrtel.Text != "")
                    {
                        if (cbdrbrans.Text != "")
                        {

                            if (tbdrad.Text != "" && tbdrsoyad.Text != "" && cbdrcinsiyet.SelectedIndex != -1)
                            {
                                if (imagePath != pictureBox1.ImageLocation) //fotograf değiştirildi ise
                                {
                                    string kaynak = dosyaYolu;
                                    string hedef = Application.StartupPath + @"\resimler\";
                                    string yeniad = Guid.NewGuid() + ".jpg"; //Benzersiz isim verme
                                    dosyaAdi = yeniad;
                                    File.Copy(kaynak, hedef + yeniad);
                                }
                                else {
                                    dosyaAdi = oldPicture;
                                }
                                

                                DataSet ds = new DataSet();
                                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                                komut.Connection = baglanti;
                                komut.CommandText = "UPDATE doktorlar SET doktortc=@doktortc,doktorad=@doktorad,doktorsoyad=@doktorsoyad,doktorcinsiyet=@doktorcinsiyet,doktorbrans=@doktorbrans,doktortelefon=@doktortelefon,doktordogum=@doktordogum,doktorkayit=@doktorkayit,doktorresim=@doktorresim,dr_id=@dr_id WHERE doktortc=@drkimlik";
                                komut.Parameters.AddWithValue("@doktortc", tbdrtc.Text);
                                komut.Parameters.AddWithValue("@doktorad", tbdrad.Text);
                                komut.Parameters.AddWithValue("@doktorsoyad", tbdrsoyad.Text);
                                komut.Parameters.AddWithValue("@doktorcinsiyet", cbdrcinsiyet.Text);
                                komut.Parameters.AddWithValue("@doktorbrans", cbdrbrans.Text);
                                komut.Parameters.AddWithValue("@doktortelefon", tbdrtel.Text);
                                komut.Parameters.AddWithValue("@doktordogum", dateTimePicker1.Value.ToShortDateString());
                                komut.Parameters.AddWithValue("@doktorkayit", dateTimePicker2.Value.ToShortDateString());
                                komut.Parameters.AddWithValue("@doktorresim", dosyaAdi);
                                komut.Parameters.AddWithValue("@dr_id", cbdrbrans.SelectedValue.ToString());
                                komut.Parameters.AddWithValue("@drkimlik", DoktorListe.tc);


                                komut.ExecuteNonQuery();

                                DataSet dss = new DataSet();
                                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                                komut2.Connection = baglanti;
                                komut2.CommandText = "UPDATE drsaat SET drad=@drad, saatbas=@saatbas, saatson=@saatson, aralik=@aralik, basdk=@basdk, sondk=@sondk, drtc=@drtc, drbolum=@drbolum WHERE drtc=@doktorTc";
                                komut2.Parameters.AddWithValue("@drad", tbdrad.Text + " " + tbdrsoyad.Text);
                                komut2.Parameters.AddWithValue("@saatbas", comboBox1.Text);
                                komut2.Parameters.AddWithValue("@saatson", comboBox3.Text);
                                komut2.Parameters.AddWithValue("@aralik", numericUpDown2.Value.ToString());

                                komut2.Parameters.AddWithValue("@basdk", comboBox2.Text);
                                komut2.Parameters.AddWithValue("@sondk", comboBox4.Text);

                                komut2.Parameters.AddWithValue("@drtc", tbdrtc.Text);
                                komut2.Parameters.AddWithValue("@drbolum", cbdrbrans.Text);
                                komut2.Parameters.AddWithValue("doktorTc", DoktorListe.tc);
                                komut2.ExecuteNonQuery();




                                baglanti.Close();




                                MessageBox.Show("Doktor Güncellendi!");
                                this.Close();
                            }
                            else MessageBox.Show("Ad, soyad ve cinsiyet bölümleri boş bırakılamaz");

                        }
                        else MessageBox.Show("Branşı Seçiniz");
                    }
                    else MessageBox.Show("TC Kimlik ve Telefon bilgileri boş bırakılamaz");
                }
                else MessageBox.Show("Lütfen bir resim seçiniz");


            }


            catch (System.Data.OleDb.OleDbException)
            {

                MessageBox.Show("Bu doktor daha önce kaydedilmiş.");
                baglanti.Close();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
