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

namespace Hastane
{
    public partial class Polikinlik : Form
    {
        public Polikinlik()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
          + Application.StartupPath + "\\veritabani.mdb");

        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        void datadoldur()
        {
            ds.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("SELECT kimlik,brans FROM branslar ORDER BY kimlik ASC", conn);
            oda.Fill(ds, "branslar");
            conn.Close();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

            if (button2.Text == "İPTAL")
            {
                
                bad.Enabled = true; dataGridView1.Enabled = true;
                button1.Text = "GÜNCELLE"; button1.BackColor = Color.SpringGreen; button1.ForeColor = Color.Black;
                button2.Text = "Yeni Branş Ekle"; button2.BackColor = Color.Yellow; button2.ForeColor = Color.Black;
                button3.Enabled = true;
            }
            else
            {
                bad.Enabled = true; bad.Clear();  dataGridView1.Enabled = false;
                button1.Text = "OLUŞTUR"; button1.BackColor = Color.Yellow; button1.ForeColor = Color.Black;
                button2.Text = "İPTAL"; button2.BackColor = Color.Red; button2.ForeColor = Color.White;
                button3.Enabled = false;
            }

        }
        string kimlik, bolum;
        string eskibrans;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            kimlik = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bolum = bad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            eskibrans = bolum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bad.Text != "" )
            {
                if (button1.Text == "GÜNCELLE")
                {
                    DialogResult dialog = new DialogResult();
                    int dt = dataGridView1.RowCount;

                    dialog = MessageBox.Show(dataGridView1.CurrentRow.Cells[1].Value.ToString() + "  branşı '" + bad.Text + "' olarak değiştirilsin mi ?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        OleDbCommand guncelle = new OleDbCommand("UPDATE branslar SET brans=@brans WHERE kimlik=@kimlik ", conn);
                        guncelle.Parameters.AddWithValue("@brans", bad.Text);
                        guncelle.Parameters.AddWithValue("@kimlik", kimlik);
                        guncelle.ExecuteNonQuery();

                        OleDbCommand guncelle2 = new OleDbCommand("UPDATE doktor_randevu SET drbrans=@drbrans WHERE drbrans=@eskibrans ", conn);
                        guncelle2.Parameters.AddWithValue("@drbrans", bad.Text);
                        guncelle2.Parameters.AddWithValue("@eskibrans", eskibrans);
                        guncelle2.ExecuteNonQuery();

                        OleDbCommand guncelle3 = new OleDbCommand("UPDATE doktorlar SET doktorbrans=@doktorbrans WHERE doktorbrans=@eskibrans ", conn);
                        guncelle3.Parameters.AddWithValue("@doktorbrans", bad.Text);
                        guncelle3.Parameters.AddWithValue("@eskibrans", eskibrans);
                        guncelle3.ExecuteNonQuery();

                        OleDbCommand guncelle4 = new OleDbCommand("UPDATE drsaat SET drbolum=@drbolum WHERE drbolum=@eskibrans ", conn);
                        guncelle4.Parameters.AddWithValue("@drbolum", bad.Text);
                        guncelle4.Parameters.AddWithValue("@eskibrans", eskibrans);
                        guncelle4.ExecuteNonQuery();

                        OleDbCommand guncelle5 = new OleDbCommand("UPDATE randevular SET alinanbolum=@alinanbolum WHERE alinanbolum=@eskibrans ", conn);
                        guncelle5.Parameters.AddWithValue("@alinanbolum", bad.Text);
                        guncelle5.Parameters.AddWithValue("@eskibrans", eskibrans);
                        guncelle5.ExecuteNonQuery();




                        MessageBox.Show("Branş Güncellendi!");
                        datadoldur();
                        button3.Enabled = true;
                    }
                    else MessageBox.Show("İşlem iptal edildi!");

                }
                else if (button1.Text == "OLUŞTUR")
                {
                    DialogResult dialog = new DialogResult();
                    int dt = dataGridView1.RowCount;

                    dialog = MessageBox.Show(bad.Text + " - " + " adında yeni branş oluşturulsun mu ? ", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {

                        if (conn.State == ConnectionState.Closed) conn.Open();
                        OleDbCommand ekle = new OleDbCommand("INSERT INTO branslar (brans) VALUES (@brans)", conn);
                        ekle.Parameters.AddWithValue("@brans", bad.Text);
                        ekle.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Yeni Branş Eklendi!");
                        datadoldur();
                        DialogResult dialog2 = new DialogResult();
                        int dt2 = dataGridView1.RowCount;

                        //dialog2 = MessageBox.Show("Oluşturduğunu bölümde doktor bulunmamakta! Hemen Doktor Eklemek İstermisiniz ?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //if (dialog2 == DialogResult.Yes)
                        //{
                        //    Doktorkayit doktor_kayit = new Doktorkayit();
                        //    doktor_kayit.ShowDialog();
                        //    if (Doktorkayit.iptalmi == false)
                        //    {
                        //        MessageBox.Show("Doktor eklenmeden çıkıldı!");
                        //    }
                        //    else MessageBox.Show("Doktor başarı ile eklendi!");
                        //}
                        //else MessageBox.Show("Doktor Eklenmedi");
                        bad.Enabled = true; dataGridView1.Enabled = true;
                        button1.Text = "GÜNCELLE"; button1.BackColor = Color.SpringGreen; button1.ForeColor = Color.Black;
                        button2.Text = "Yeni Branş Ekle"; button2.BackColor = Color.Yellow; button2.ForeColor = Color.Black;
                        button3.Enabled = true;
                    }
                    else MessageBox.Show("İşlem iptal edildi!");
                    button3.Enabled = true;

                }
            }
            else MessageBox.Show("Branş adı boş bırakılamaz!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       

        private void Polikinlik_Load_1(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.MultiSelect = false;
            button1.BackColor = Color.SpringGreen;
            button2.BackColor = Color.Yellow;
            button2.ForeColor = Color.Black;
            bad.Enabled = true;
            datadoldur();
            bs.DataSource = ds.Tables["branslar"];
            dataGridView1.DataSource = bs;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Polikiniklik Adı";
            dataGridView1.Columns[1].Width = 351;

            for (int i = 0; i < 1; i++)
            {
                this.dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.SpringGreen;
            this.dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            DialogResult dialog = new DialogResult();
            int dt = dataGridView1.RowCount;

            dialog = MessageBox.Show("POLİKİNİKLİ SİLMEK O POLİKİNLİKTEKİ TÜM DOKTORLARIN SİLİNMESİNE SEBEP OLACAKTIR. DEVAM ETMEK İSTİYORMUSUNUZ ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                DialogResult dialog2 = new DialogResult();
                dialog2 = MessageBox.Show(bolum + " branşındaki TÜM DOKTORLAR vs o doktora ait TÜM RANDEVULAR SİLİNECEKTİR. Bu işlem geri alınamaz. Devam etmek istiyormusunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog2 == DialogResult.Yes)
                {

                    if (conn.State == ConnectionState.Closed) conn.Open();
                    OleDbCommand del = new OleDbCommand("DELETE FROM branslar where kimlik=@kimlik", conn);
                    del.Parameters.AddWithValue("@kimlik", kimlik);
                    del.ExecuteNonQuery();
                    OleDbCommand del2 = new OleDbCommand("DELETE FROM doktorlar where doktorbrans=@doktorbrans", conn);
                    del2.Parameters.AddWithValue("@doktorbrans", bolum);
                    del2.ExecuteNonQuery();

                    OleDbCommand del3 = new OleDbCommand("DELETE FROM doktor_randevu where drbrans=@drbrans", conn);
                    del3.Parameters.AddWithValue("@drbrans", bolum);
                    del3.ExecuteNonQuery();


                    OleDbCommand del4 = new OleDbCommand("DELETE FROM randevular where alinanbolum=@alinanbolum", conn);
                    del4.Parameters.AddWithValue("@alinanbolum", bolum);
                    del4.ExecuteNonQuery();

                    OleDbCommand del5 = new OleDbCommand("DELETE FROM drsaat where drbolum=@drbolum", conn);
                    del5.Parameters.AddWithValue("@drbolum", bolum);
                    del5.ExecuteNonQuery();

                    MessageBox.Show(bolum + " BRANŞINA AİT TÜM HASTANE KAYITLARI ve DOKTORLARI silindi!");

                    datadoldur();
                }
                else MessageBox.Show("İşlem iptal edildi!");
            }
            else MessageBox.Show("İşlem iptal edildi!");
        }
    }
}
