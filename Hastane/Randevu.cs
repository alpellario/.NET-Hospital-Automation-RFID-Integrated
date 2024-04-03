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
    public partial class Randevu : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
         + Application.StartupPath + "\\veritabani.mdb");

        string[] portlar = SerialPort.GetPortNames();
        public Randevu()
        {
            InitializeComponent();
            baglantiAc.Text = "Bağlantı Aç";
            baglantiAc.BackColor = Color.Yellow;
            groupBox1.Text = "BAĞLANTI";
            rfid_No.ForeColor = Color.Red;

            hastaKayit.Text = "Hasta Kaydı Oluştur";


            hastaOku.Text = "Hasta Oku";


            duzenleButton.Text = "Kart Bilgileri düzenle";


            silButton.Text = "Hasta Kaydı Sil";


            button1.Text = "Polikiniklik ekle";


        }

        private void hastaKayit_Click(object sender, EventArgs e)
        {
            temizle();
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("0");
                serialPort1.Close();
                groupBox1.Enabled = false;
                sinyal.BackColor = Color.Red;
                labelDurum.Text = "Bağlantı kapandı!\nport dinleyiniz!";


            }
            HastaKayit hk = new HastaKayit();
            hk.ShowDialog();
            yenile();

        }

        private void temizle()
        {
            rfid_No.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            pictureBox1.Image = null;
        }

        private void hastaOku_Click(object sender, EventArgs e)
        {
            temizle();
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("0");
                serialPort1.Close();
                groupBox1.Enabled = false;
                sinyal.BackColor = Color.Red;
                labelDurum.Text = "Bağlantı kapandı!\nport dinleyiniz!";


            }
            HastaOku ho = new HastaOku();
            ho.ShowDialog();
            yenile();

        }

        private void duzenleButton_Click(object sender, EventArgs e)
        {
            temizle();
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("0");
                serialPort1.Close();
                groupBox1.Enabled = false;
                sinyal.BackColor = Color.Red;
                labelDurum.Text = "Bağlantı kapandı!\nport dinleyiniz!";


            }
            HastaDuzenle hd = new HastaDuzenle();
            hd.ShowDialog();
            yenile();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            temizle();
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("0");
                serialPort1.Close();
                groupBox1.Enabled = false;
                sinyal.BackColor = Color.Red;
                labelDurum.Text = "Bağlantı kapandı!\nport dinleyiniz!";


            }
            HastaSil hs = new HastaSil();
            hs.ShowDialog();
            yenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Polikinlik p = new Polikinlik();
            p.ShowDialog();
            yenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doktorkayit dk = new Doktorkayit();
            dk.ShowDialog();
            yenile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoktorListe dl = new DoktorListe();
            conn.Close();
            dl.ShowDialog();
            yenile();
        }
        int simdikiwidth = 1280;
        int simdikiheight = 800;

        BindingSource bs = new BindingSource();
        BindingSource bs2 = new BindingSource();
        BindingSource bs3 = new BindingSource();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        void datadoldur()
        {
            ds.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SElect kimlik,islemtarih,tc,ad,soyad,cinsiyet,alinandr,alinanbolum,randevugun,randevusaat from randevular ORDER BY randevugun,randevusaat ASC", conn);
            da.Fill(ds, "randevular");
            conn.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.MultiSelect = false;

            dateTimePicker1.MinDate = DateTime.Now.AddDays(0);
            dateTimePicker2.Value = DateTime.Now.AddDays(0);

            bransekle();
            oncekiButon = null;
            conn.Open();

            datadoldur();
            bs.DataSource = ds.Tables["randevular"];
            dataGridView1.DataSource = bs;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "İslem Tarih";
            dataGridView1.Columns[2].HeaderText = "TC Kimlik No";
            dataGridView1.Columns[3].HeaderText = "Ad";
            dataGridView1.Columns[4].HeaderText = "Soyad";
            dataGridView1.Columns[5].HeaderText = "Cinsiyet";
            dataGridView1.Columns[6].HeaderText = "Alınan Doktor";

            dataGridView1.Columns[7].HeaderText = "Alınan Bölüm";
            dataGridView1.Columns[8].HeaderText = "Randevu Günü";
            dataGridView1.Columns[8].Width = 167;
            dataGridView1.Columns[9].HeaderText = "Randevu Saati";


            for (int i = 0; i < 10; i++)
            {
                this.dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.SpringGreen;
            this.dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;






            ds2.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbDataAdapter da2 = new OleDbDataAdapter("SElect brans from branslar ", conn);


            da2.Fill(ds2, "branslar");
            conn.Close();
            bs2.DataSource = ds2.Tables["branslar"];
            dataGridView2.DataSource = bs2;
            dataGridView2.RowHeadersVisible = false; ;
            dataGridView2.Columns[0].HeaderText = "POLİKİNLİKLER";
            this.dataGridView2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[0].Width = 125;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.RowsDefaultCellStyle.SelectionBackColor = Color.SpringGreen;
            this.dataGridView2.RowsDefaultCellStyle.SelectionForeColor = Color.Black;


            dataGridView3.RowHeadersVisible = false; ;

            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.RowsDefaultCellStyle.SelectionBackColor = Color.SpringGreen;
            this.dataGridView3.RowsDefaultCellStyle.SelectionForeColor = Color.Black;








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

        }



        void bransekle()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from branslar ", conn);
            da.Fill(dt);
            cbbrans.ValueMember = "kimlik";
            cbbrans.DisplayMember = "brans";
            cbbrans.DataSource = dt;
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("0");
                serialPort1.Close();
            }
        }
        DataTable dt = new DataTable();
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            bool kayitlimi = false;



            string data = serialPort1.ReadExisting();
            rfid_No.Text = data;
            serialPort1.Write("1");

            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            pictureBox1.Image = null;

            if (conn.State == ConnectionState.Closed) conn.Open();
            dt.Rows.Clear();
            OleDbCommand readRfid = new OleDbCommand("Select islemtarih, tckimlikno, ad, soyad, resim, dogumyeri from Hastalar where rfid_id = " + rfid_No.Text + "", conn);
            OleDbDataReader rfidControl = readRfid.ExecuteReader();
            dt.Load(rfidControl);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                label7.Text = row["tckimlikno"].ToString();
                label8.Text = row["ad"].ToString();
                label9.Text = row["soyad"].ToString();

                textBox1.Text = Application.StartupPath + "\\resimler\\" + row["resim"].ToString(); 
                pictureBox1.Load(textBox1.Text);
                kayitlimi = true;
            }
            else
            {
                MessageBox.Show("Kart Kayıtlı Değil! Hasta Kaydı Yapınız");
                rfid_No.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                pictureBox1.Image = null;
                HastaKayit hastaKayit = new HastaKayit();
                serialPort1.Write("0");
                serialPort1.Close();
                groupBox1.Enabled = false;
                sinyal.BackColor = Color.Red;
                labelDurum.Text = "Bağlantı kapandı!\nport dinleyiniz!";
                hastaKayit.ShowDialog();
            }
            conn.Close();

        }

        private void cbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbrans.SelectedIndex != -1)
            {
                cbdrad.Enabled = true;
                if (conn.State == ConnectionState.Closed) conn.Open();
                cbdrad.Text = "";
                DataTable dtt = new DataTable();

                OleDbDataAdapter dat = new OleDbDataAdapter("SELECT dr_id,(doktorad + ' ' + doktorsoyad) AS NAME, doktortc FROM doktorlar where dr_id = " + cbbrans.SelectedValue + " ", conn);
                dat.Fill(dtt);

                cbdrad.ValueMember = "doktortc";
                cbdrad.DisplayMember = "NAME";
                cbdrad.DataSource = dtt;
                conn.Close();

            }
        }



        private void randevugoster_Click(object sender, EventArgs e)
        {
            Bar bar = new Bar();
            bar.ShowDialog();

            if (cbdrad.SelectedIndex != -1)
            {


                randevuolustur();

            }
            else MessageBox.Show("Doktor seçimi yapınız");
        }
        public static int l = 1;
        DataTable doktorrand = new DataTable();
        int saat = 0;
        int dakika = 0;
        int aralik = 0;
        int sonsaat = 0;
        int sondk = 0;
        int hesap = 0;
        DataTable olustur = new DataTable();
        void randevuolustur()
        {

            randevusaat.Visible = true;


            if (conn.State == ConnectionState.Closed) conn.Open();
            olustur.Rows.Clear();
            OleDbCommand drsaattablo = new OleDbCommand("select *from drsaat WHERE drtc=@drtc", conn);
            drsaattablo.Parameters.AddWithValue("@drtc", Convert.ToDouble(cbdrad.SelectedValue.ToString()));
            OleDbDataReader drsaatioku = drsaattablo.ExecuteReader();
            olustur.Load(drsaatioku);


            saat = int.Parse(olustur.Rows[0][2].ToString());
            dakika = int.Parse(olustur.Rows[0][5].ToString());
            sonsaat = int.Parse(olustur.Rows[0][3].ToString());
            sondk = int.Parse(olustur.Rows[0][6].ToString());
            aralik = int.Parse(olustur.Rows[0][4].ToString());
            TimeSpan h = new TimeSpan(saat, dakika, 00);
            TimeSpan eh = new TimeSpan(sonsaat, sondk, 00);
            TimeSpan aralikt = new TimeSpan(00, aralik, 00);
            TimeSpan sinir = eh - h;
            hesap = (int.Parse(sinir.Hours.ToString()) * 60) / aralik;

            doktorrand.Rows.Clear();
            randevusaat.Controls.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            TimeSpan zaman = new TimeSpan(saat, dakika, 00);
            int üst = -20; int kactane = 1;
            string sonuc;
            int j = 0;
            int satır = 0;
            OleDbCommand tabloyuoku = new OleDbCommand("select *from doktor_randevu", conn);
            OleDbDataReader tabloyuçek = tabloyuoku.ExecuteReader();
            doktorrand.Load(tabloyuçek);
            for (int i = 0; i < hesap; i++)
            {

                Button btn = new Button();

                btn.Name = (i + 1).ToString();
                btn.Text = (i + 1).ToString();

                btn.Width = 70;
                btn.Height = 40;
                btn.BackColor = Color.SpringGreen;
                if (i % 14 == 0)
                {
                    üst += 40; kactane = 0;
                }
                btn.Top = üst;
                kactane++;
                btn.Left = 70 * kactane;

                satır++;

                TimeSpan eklenecek = TimeSpan.FromMinutes(j);
                sonuc = string.Format("{0:hh}:{0:mm}", zaman.Add(eklenecek));
                j += aralik;

                btn.Text = sonuc;




                btn.Click += new EventHandler(renk);


                randevusaat.Controls.Add(btn);


                TimeSpan bas = new TimeSpan(12, 00, 00);
                TimeSpan son = new TimeSpan(13, 15, 00);
                TimeSpan bast = new TimeSpan(saat, dakika, 00);
                TimeSpan sonst = new TimeSpan(sonsaat, sondk, 00);
                for (int k = 0; k < doktorrand.Rows.Count; k++)
                {

                    if (btn.Text == doktorrand.Rows[k][2].ToString() && cbdrad.Text == doktorrand.Rows[k][1].ToString() && dateTimePicker1.Value.ToShortDateString() == doktorrand.Rows[k][3].ToString())
                    {

                        btn.BackColor = Color.Red;
                        btn.Enabled = false;

                        break;
                    }
                    else
                    {
                        btn.BackColor = Color.SpringGreen;

                    }
                }
                if (TimeSpan.Parse(btn.Text) >= bas && TimeSpan.Parse(btn.Text) <= son)
                {
                    btn.Enabled = false;
                    btn.BackColor = Color.DimGray;
                }

                if (TimeSpan.Parse(btn.Text) > sonst)
                {
                    btn.Enabled = false;
                    btn.BackColor = Color.Gray;
                }

                DateTime tarih = DateTime.Now;
                string format = "H:mm";

                if (dateTimePicker1.Value.ToShortDateString() == dateTimePicker2.Value.ToShortDateString() && TimeSpan.Parse(tarih.ToString(format)) >= TimeSpan.Parse(btn.Text))
                {
                    btn.Enabled = false;
                    btn.BackColor = Color.Gray;
                }
                conn.Close();
            }

        }
        Button oncekiButon = new Button();
        bool[] saatler = new bool[100];
        string tutsaat;
        string tutbtnName;
        string tutbtnEskiName;
        private void renk(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            tutbtnEskiName = btn.Name;

            if (saatler[int.Parse(btn.Name)] == true)
            {

                btn.BackColor = Color.SpringGreen;
                saatler[int.Parse(btn.Name)] = false;

            }
            else
            {
                if (oncekiButon == null)
                {
                    btn.BackColor = Color.Red;
                    saatler[int.Parse(btn.Name)] = true;
                }
                else if (btn.Name != oncekiButon.Name)
                {
                    oncekiButon.BackColor = Color.SpringGreen;
                    int c = -1;
                    foreach (bool a in saatler)
                    {
                        c = c + 1;
                        if (a == true) saatler[c] = false;
                    }
                    btn.BackColor = Color.Red;
                    saatler[int.Parse(btn.Name)] = true;
                }
                else if (btn.Name == oncekiButon.Name)
                {

                    btn.BackColor = Color.Red;
                    saatler[int.Parse(btn.Name)] = true;
                }
            }



            tutsaat = btn.Text;
            oncekiButon = btn;






        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        int tutindex;
        private void randevuver_Click(object sender, EventArgs e)
        {

            if (cbdrad.SelectedIndex != -1 && cbdrad.Enabled != false)
            {

                if (oncekiButon != null)
                {
                    if (rfid_No.Text != "")
                    {
                        if (randevuver.Text == "Randevu Ver")
                        {

                            if (conn.State == ConnectionState.Closed) conn.Open();
                            OleDbCommand komutt = new OleDbCommand("SELECT ad,soyad,cinsiyet FROM Hastalar WHERE rfid_id=" + rfid_No.Text + "", conn);
                            OleDbDataReader drr = komutt.ExecuteReader();
                            while (drr.Read())
                            {
                                ad.Text = drr["ad"].ToString();
                                soyad.Text = drr["soyad"].ToString();
                            }
                            DialogResult dialog = new DialogResult();
                            dialog = MessageBox.Show("TC = " + label7.Text + "\n\nAd Soyad = " + ad.Text.ToUpper() + " " + soyad.Text.ToUpper() + "\n\nPolikinlik = " + cbbrans.Text.ToUpper() + "\n\nDoktor = " + cbdrad.Text.ToUpper() + "\n\nRandevu tarihi = " + dateTimePicker1.Value.ToLongDateString().ToUpper() + "\n\nRandevu Saati = " + tutsaat.ToUpper(), "Randevuyu onaylıyormusunuz ?", MessageBoxButtons.YesNo);
                            if (dialog == DialogResult.Yes)
                            {


                                OleDbCommand kmt = new OleDbCommand("INSERT INTO doktor_randevu (doktor_Ad,doktor_Saat,doktor_Tarih,kisitc,drbrans) VALUES (@doktor_Ad,@doktor_Saat,@doktor_Tarih,@kisitc,@drbrans) ", conn);
                                kmt.Parameters.AddWithValue("@doktor_Ad", cbdrad.Text);
                                kmt.Parameters.AddWithValue("@doktor_Saat", tutsaat);
                                kmt.Parameters.AddWithValue("@doktor_Tarih", dateTimePicker1.Value.ToShortDateString());
                                kmt.Parameters.AddWithValue("@kisitc", label7.Text);
                                kmt.Parameters.AddWithValue("@drbrans", cbbrans.Text);
                                kmt.ExecuteNonQuery();

                                kmt.CommandText = "SELECT @@IDENTITY";
                                int return_dr_randevu_id = Convert.ToInt32(kmt.ExecuteScalar().ToString());




                                OleDbCommand komut = new OleDbCommand("SELECT ad,soyad,cinsiyet FROM Hastalar WHERE tckimlikno=" + label7.Text + "", conn);
                                OleDbDataReader dr = komut.ExecuteReader();
                                while (dr.Read())
                                {


                                    textBox3.Text = dr["ad"].ToString();
                                    textBox4.Text = dr["soyad"].ToString();
                                    textBox5.Text = dr["cinsiyet"].ToString();
                                }

 

                                OleDbCommand komut2 = new OleDbCommand("INSERT INTO randevular (tc,ad,soyad,cinsiyet,alinandr,randevusaat,alinanbolum,islemtarih,randevugun,doktor_id,durum,doktor_randevu_id) VALUES (@tc,@ad,@soyad,@cinsiyet,@alinandr,@randevusaat,@alinanbolum,@islemtarih,@randevugun,@doktor_id,@durum,@doktor_randevu_id) ", conn);
                                
                                komut2.Parameters.AddWithValue("@tc", label7.Text);
                                komut2.Parameters.AddWithValue("@ad", textBox3.Text);
                                komut2.Parameters.AddWithValue("@soyad", textBox4.Text);
                                komut2.Parameters.AddWithValue("@cinsiyet", textBox5.Text);
                                komut2.Parameters.AddWithValue("@alinandr", cbdrad.Text);
                                komut2.Parameters.AddWithValue("@randevusaat", tutsaat);
                                komut2.Parameters.AddWithValue("@alinanbolum", cbbrans.Text);
                                komut2.Parameters.AddWithValue("@islemtarih", dateTimePicker2.Value.ToLongDateString());
                                komut2.Parameters.AddWithValue("@randevugun", dateTimePicker1.Value.ToShortDateString());
                                komut2.Parameters.AddWithValue("@doktor_id", doktor_id);
                                komut2.Parameters.AddWithValue("@durum", 0);
                                komut2.Parameters.AddWithValue("@doktor_randevu_id", return_dr_randevu_id);
                                komut2.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("Randevu başarı ile verildi");

                                randevusaat.Visible = false;
                                //button9.Text = "Randevu Saati Göster";
                                // basilimi = true;
                                oncekiButon = null;
                                datadoldur();

                                //  id++;
                                bs.DataSource = ds.Tables["randevular"];
                                dataGridView1.DataSource = bs;
                                yenile();

                            }
                            else if (dialog == DialogResult.No) MessageBox.Show("İşlem iptal edildi!");
                        }
                    }
                    else MessageBox.Show("Hasta Kartı Okutunuz!");
                }
                else MessageBox.Show("Randevu Saati Seçiniz.");
            }
            else MessageBox.Show("Doktor Seçiniz!");

        }

        private void randevusilButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult dialog = new DialogResult();
                int dt = dataGridView1.RowCount;

                dialog = MessageBox.Show(label7.Text + " TC li " + dataGridView1.CurrentRow.Cells[3].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[4].Value.ToString().ToUpper() + " ye ait " + dataGridView1.CurrentRow.Cells[7].Value.ToString().ToUpper() + " " + dataGridView1.CurrentRow.Cells[9].Value.ToString() + " randevusunu silmek istediğinize eminmisiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    DialogResult dialog2 = new DialogResult();
                    dialog2 = MessageBox.Show("Bu randevu silinecek. Bu işlem geri alınamaz. Devam etmek istiyormusunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog2 == DialogResult.Yes)
                    {
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        OleDbCommand del = new OleDbCommand("DELETE FROM doktor_randevu where kimlik=@kimlik", conn);
                        del.Parameters.AddWithValue("@kimlik", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        del.ExecuteNonQuery();
                        OleDbCommand del2 = new OleDbCommand("DELETE FROM randevular where kimlik=@kimlik", conn);
                        del2.Parameters.AddWithValue("@kimlik", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        del2.ExecuteNonQuery();
                        datadoldur();

                    }
                    else MessageBox.Show("İşlem iptal edildi!");
                }
                else MessageBox.Show("İşlem iptal edildi!");
            }
            else MessageBox.Show("Randevu Seçimi Yapmadınız!");

            yenile();

        }

        private void portkontrol_Click(object sender, EventArgs e)
        {
            comboPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            Control.CheckForIllegalCrossThreadCalls = false;
            foreach (string port in ports)
            {
                comboPorts.Items.Add(port);
                comboPorts.SelectedIndex = 0;
            }
            comboBaund.Items.Add("9600");
            comboBaund.SelectedIndex = 0;
            groupBox1.Enabled = true;

        }

        Label label11 = new Label();
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ds3.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbDataAdapter da3 = new OleDbDataAdapter("SElect doktorad,doktorsoyad from doktorlar WHERE doktorbrans=@doktorbrans ", conn);
            da3.SelectCommand.Parameters.AddWithValue("@doktorbrans", dataGridView2.CurrentRow.Cells[0].Value.ToString());

            da3.Fill(ds3, "doktorlar");
            conn.Close();
            bs3.DataSource = ds3.Tables["doktorlar"];
            dataGridView3.DataSource = bs3;
            dataGridView3.Columns[0].HeaderText = "DOKTOR AD";
            dataGridView3.Columns[1].HeaderText = "DOKTOR SOYAD";
            this.dataGridView3.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView3.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns[0].Width = 120;
            dataGridView3.Columns[1].Width = 142;
            conn.Close();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (conn.State == ConnectionState.Closed) conn.Open();
            //OleDbCommand komut = new OleDbCommand("Select doktorresim from doktorlar where doktorad=@doktorad and doktorsoyad=@doktorsoyad ", conn);
            //komut.Parameters.AddWithValue("@doktorad", dataGridView3.CurrentRow.Cells[0].Value.ToString());
            //komut.Parameters.AddWithValue("@doktorsoyad", dataGridView3.CurrentRow.Cells[1].Value.ToString());
            //OleDbDataReader dr = komut.ExecuteReader();

            //while (dr.Read())
            //{



            //    textBox1.Text = dr["doktorresim"].ToString();
            //    pictureBox2.Load(textBox1.Text);






            //}
            //conn.Close();
        }

        private void yenile_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Hastalar hastalar = new Hastalar();
            hastalar.ShowDialog();
            yenile();
        }

        private void randevular_Click(object sender, EventArgs e)
        {
            Randevular randevular = new Randevular();
            randevular.ShowDialog();
        }

        private void yenile_MouseEnter(object sender, EventArgs e)
        {

        }

        private void yenile_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            yenile();
        }

        private void yenile()
        {
            datadoldur();
            bs.DataSource = ds.Tables["randevular"];
            dataGridView1.DataSource = bs;
            bransekle();

            ds2.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbDataAdapter da2 = new OleDbDataAdapter("SElect brans from branslar ", conn);
            da2.Fill(ds2, "branslar");
            conn.Close();
            bs2.DataSource = ds2.Tables["branslar"];
            dataGridView2.DataSource = bs2;
            dataGridView2.RowHeadersVisible = false; ;
            dataGridView2.Columns[0].HeaderText = "POLİKİNLİKLER";
            this.dataGridView2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[0].Width = 125;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.RowsDefaultCellStyle.SelectionBackColor = Color.SpringGreen;
            this.dataGridView2.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DoktorEkran dE = new DoktorEkran();
            dE.ShowDialog();
        }
        int doktor_id;
        private void cbdrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbCommand command = new OleDbCommand("SELECT id FROM doktorlar WHERE doktortc=@doktortc", conn);
            command.Parameters.AddWithValue("@doktortc", Convert.ToDouble(cbdrad.SelectedValue.ToString()));
            OleDbDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                doktor_id = Convert.ToInt32(dr["id"].ToString());
            }
        }
    }
}
