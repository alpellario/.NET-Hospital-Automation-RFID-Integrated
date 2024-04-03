using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Hastane
{
    public partial class DoktorEkran : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
         + Application.StartupPath + "\\veritabani.mdb");
        public DoktorEkran()
        {
            InitializeComponent();
        }
        int doktor_id = Login.doktor_id;
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        private void DoktorEkran_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.MultiSelect = false;


            default_randevu_listele();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "TC Kimlik No";
            dataGridView1.Columns[2].HeaderText = "Ad";
            dataGridView1.Columns[3].HeaderText = "Soyad";
            dataGridView1.Columns[4].HeaderText = "Cinsiyet";
            dataGridView1.Columns[5].HeaderText = "Randevu Günü";
            dataGridView1.Columns[6].HeaderText = "Randevu Saati";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                this.dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            this.dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Blue;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11);
            this.dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 12);

            renklendir();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 30);
            listView1.Columns.Add("İLAÇ ADI", 210);

            DateTime dt = DateTime.Now;
            string time = dt.ToString("HH:mm:ss");
            lbl_saat.Text = time;
            timer1.Enabled = true;
        }

        void default_randevu_listele()
        {
            //bugünün tarihinin randevularının listelenmesi
            ds.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SElect kimlik,tc,ad,soyad,cinsiyet,randevugun,randevusaat,durum,doktor_randevu_id FROM randevular WHERE doktor_id=@doktor_id AND randevugun=@randevu_gun AND durum=@durum ORDER BY randevugun,randevusaat ASC", conn);
            da.SelectCommand.Parameters.AddWithValue("@doktor_id", doktor_id);
            da.SelectCommand.Parameters.AddWithValue("@randevu_gun", dateTimePicker2.Value.ToShortDateString());
            da.SelectCommand.Parameters.AddWithValue("@durum", 0);
            da.Fill(ds, "randevular");
            bs.DataSource = ds.Tables["randevular"];
            dataGridView1.DataSource = bs;
            conn.Close();


        }

        void tamamlananlar_dahil_randevu_listele()
        {
            ds.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SElect kimlik,tc,ad,soyad,cinsiyet,randevugun,randevusaat,durum,doktor_randevu_id FROM randevular WHERE doktor_id=@doktor_id AND randevugun=@randevu_gun ORDER BY randevugun,randevusaat ASC", conn);
            da.SelectCommand.Parameters.AddWithValue("@doktor_id", doktor_id);
            da.SelectCommand.Parameters.AddWithValue("@randevu_gun", dateTimePicker2.Value.ToShortDateString());
            da.Fill(ds, "randevular");
            bs.DataSource = ds.Tables["randevular"];
            dataGridView1.DataSource = bs;
            conn.Close();

        }
        private void btn_bugun_randevu_Click(object sender, EventArgs e)
        {
            default_randevu_listele();
            renklendir();
        }
        private void include_completed_randevu_Click(object sender, EventArgs e)
        {
            tamamlananlar_dahil_randevu_listele();
            renklendir();
        }
        int pass;
        int available;
        int completed;

        int randevu_id;
        int doktor_randevu_id;
        void renklendir()
        {
            pass = 0;
            available = 0;
            completed = 0;
            string rowDate;
            string rowTime;
            string randevuDurum;
            DateTime simdiki_tarih = DateTime.Now;
            foreach (DataGridViewRow Myrow in dataGridView1.Rows)
            {

                rowDate = Myrow.Cells[5].Value.ToString();
                rowTime = Myrow.Cells[6].Value.ToString();
                randevu_id = Convert.ToInt32(Myrow.Cells[7].Value.ToString());
                randevuDurum = Myrow.Cells[7].Value.ToString();
                string[] arr_date = rowDate.Split('.');
                string[] arr_time = rowTime.Split(':');
                int gun = Convert.ToInt32(arr_date[0]);
                int ay = Convert.ToInt32(arr_date[1]);
                int yil = Convert.ToInt32(arr_date[2]);
                int saat = Convert.ToInt32(arr_time[0]);
                int dakika = Convert.ToInt32(arr_time[1]);
                DateTime randevu_tarih = new DateTime(yil, ay, gun, saat, dakika, 0);
                int res = DateTime.Compare(randevu_tarih, simdiki_tarih);


                if (res < 0)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                    pass++;
                }
                else if (res > 0)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Yellow;
                    available++;
                }
                if (randevuDurum == "1")
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Chartreuse;
                    completed++;
                }
                lb_gecen_randevu_sayisi.Text = pass.ToString();
                lb_bekleyen_randevu_sayisi.Text = available.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
                e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
            }
            else
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Regular);
            }
        }

        DataTable dt = new DataTable();
        bool hasta_secildi = false;
        
        private void btn_hasta_kabul_Click(object sender, EventArgs e)
        {
            string imagePath;
            lbl_tc.Text = "";
            lbl_ad.Text = "";
            lbl_soyad.Text = "";
            pictureBox1.Image = null;

            if (conn.State == ConnectionState.Closed) conn.Open();
            dt.Rows.Clear();
            OleDbCommand readTc = new OleDbCommand("Select tckimlikno, ad, soyad, resim from Hastalar where tckimlikno=@tckimlikno", conn);
            readTc.Parameters.AddWithValue("@tckimlikno", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            OleDbDataReader tcControl = readTc.ExecuteReader();
            dt.Load(tcControl);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lbl_tc.Text = row["tckimlikno"].ToString();
                lbl_ad.Text = row["ad"].ToString();
                lbl_soyad.Text = row["soyad"].ToString();
                

                imagePath = Application.StartupPath + "\\resimler\\" + row["resim"].ToString();
                pictureBox1.Load(imagePath);
            }
            randevu_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            doktor_randevu_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            hasta_secildi = true;
        }

        private void btn_kabul_iptal_Click(object sender, EventArgs e)
        {
            hasta_temize();
        }

        void hasta_temize()
        {
            lbl_tc.Text = "";
            lbl_ad.Text = "";
            lbl_soyad.Text = "";
            pictureBox1.Image = null;
            listView1.Items.Clear();
            tb_teshis.Text = "";
            default_randevu_listele();
            renklendir();
            hasta_secildi = false;
        }

        private void adagore_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (adagore.Text.Trim() == "")
                {
                    default_randevu_listele();
                    renklendir();

                }
                else
                {

                    ds.Clear();
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter("SElect kimlik,tc,ad,soyad,cinsiyet,randevugun,randevusaat,durum,doktor_randevu_id FROM randevular WHERE doktor_id=@doktor_id AND randevugun=@randevu_gun AND durum=@durum AND ad LIKE '" + adagore.Text + "%' ORDER BY randevugun,randevusaat ASC", conn);
                    da.SelectCommand.Parameters.AddWithValue("@doktor_id", doktor_id);
                    da.SelectCommand.Parameters.AddWithValue("@randevu_gun", dateTimePicker2.Value.ToShortDateString());
                    da.SelectCommand.Parameters.AddWithValue("@durum", 0);
                    da.Fill(ds, "randevular");
                    bs.DataSource = ds.Tables["randevular"];
                    dataGridView1.DataSource = bs;
                    conn.Close();
                    renklendir();
                }
            }
            catch { }
        }

        public static int ilac_id;
        public static string ilac_ad;
        public static bool secim = false;
        private void btn_ilac_ekle_Click(object sender, EventArgs e)
        {
            if (hasta_secildi == true)
            {
                secim = false;
                IlacListe iL = new IlacListe();
                iL.ShowDialog();
                if (secim == true)
                {
                    string[] items = { ilac_id.ToString(), ilac_ad };
                    listView1.Items.Add(new ListViewItem(items));
                }
            }
            else
            {
                MessageBox.Show("Hasta Seçimi yapmadınız");
            }
        }

        private void btn_ilac_sil_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem row in listView1.SelectedItems)
            {
                row.Remove();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string time = dt.ToString("HH:mm:ss");
            lbl_saat.Text = time;
        }

        public static string token;
        private void btn_recete_yaz_Click(object sender, EventArgs e)
        {
            if(hasta_secildi == true)
            {
                string ilaclar = "";
                if (tb_teshis.Text != "" || listView1.Items.Count > 0)
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        int ii = 1;
                        ilaclar += listView1.Items[i].SubItems[ii].Text + "|";

                    }
                    token = token_olustur();

                    if (conn.State == ConnectionState.Closed) conn.Open();
                    OleDbCommand command = new OleDbCommand("INSERT INTO receteler (recete_token, recete_ilac_adi, hasta_ad_soyad, teshis) VALUES (@recete_token,@recete_ilac_adi,@hasta_ad_soyad, @teshis)", conn);
                    command.Parameters.AddWithValue("@recete_token", token);
                    command.Parameters.AddWithValue("@recete_ilac_adi", ilaclar);
                    command.Parameters.AddWithValue("@hasta_ad_soyad", lbl_ad.Text + " " + lbl_soyad.Text);
                    command.Parameters.AddWithValue("@teshis", tb_teshis.Text);
                    command.ExecuteNonQuery();

                    OleDbCommand command2 = new OleDbCommand("UPDATE randevular SET durum=@durum WHERE kimlik=@kimlik", conn);
                    command2.Parameters.AddWithValue("@durum", 1);
                    command2.Parameters.AddWithValue("@kimlik", randevu_id);
                    command2.ExecuteNonQuery();

                    OleDbCommand command3 = new OleDbCommand("DELETE FROM doktor_randevu WHERE dr_randevu_id=@dr_randevu_id", conn);
                    command3.Parameters.AddWithValue("@dr_randevu_id", doktor_randevu_id);
                    command3.ExecuteNonQuery();

                    recete_kodu rK = new recete_kodu();
                    rK.ShowDialog();
                    hasta_temize();
                    default_randevu_listele();
                    renklendir();

                }
                else
                {
                    MessageBox.Show("Reçete yazmak için ilaç veya teşhis alanları doldurulmalıdır");
                }
            }
            else
            {
                MessageBox.Show("Hasta seçimi yapmadınız");
            }
            
        }

        private string token_olustur()
        {
            Guid guid = Guid.NewGuid();
            string rString = Convert.ToBase64String(guid.ToByteArray());
            rString = rString.Replace("=", "");
            return rString.Substring(0, 6);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            default_randevu_listele();
            renklendir();
        }
    }
}
