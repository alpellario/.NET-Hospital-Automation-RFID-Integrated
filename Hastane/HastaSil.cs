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
    public partial class HastaSil : Form
    {
        string[] portlar = SerialPort.GetPortNames();
        public HastaSil()
        {
            InitializeComponent();
            baglantiAc.Text = "Bağlantı Aç";
            baglantiAc.BackColor = Color.Yellow;
            groupBox1.Text = "BAĞLANTI";

        }

        private void HastaSil_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            labelkapa();
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
        void labelkapa()
        {
            islemtx.Visible = false;
            tctx.Visible = false;
            adtx.Visible = false;
            soytx.Visible = false;
            ctx.Visible = false;
            babatx.Visible = false;
            annetx.Visible = false;
            dttx.Visible = false;
            teltx.Visible = false;
            adrestx.Visible = false;
            dytx.Visible = false;
            textBox1.Visible = false;
        }
        void labelac()
        {
            islemtx.Visible = true;
            tctx.Visible = true;
            adtx.Visible = true;
            soytx.Visible = true;
            ctx.Visible = true;
            babatx.Visible = true;
            annetx.Visible = true;
            dttx.Visible = true;
            teltx.Visible = true;
            adrestx.Visible = true;
            dytx.Visible = true;

        }
        void labeltemizle()
        {
            islemtx.Text = "";
            tctx.Text = "";
            adtx.Text = "";
            soytx.Text = "";
            ctx.Text = "";
            babatx.Text = "";
            annetx.Text = "";
            dttx.Text = "";
            teltx.Text = "";
            adrestx.Text = "";
            dytx.Text = "";
            pictureBox1.Image = null;




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

        private void HastaSil_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("0");
                serialPort1.Close();

            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            labeltemizle();
            string data = serialPort1.ReadExisting();
            rfid_No.Text = data;
            serialPort1.Write("1");
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
          + Application.StartupPath + "\\veritabani.mdb");
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();

            OleDbCommand rfoku = new OleDbCommand("select * from Hastalar WHERE rfid_id=@rfid_id", baglanti);
            rfoku.Parameters.AddWithValue("rfid_id", rfid_No.Text);
            OleDbDataReader rfkontrol = rfoku.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rfkontrol);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                islemtx.Text = row["islemtarih"].ToString();
                tctx.Text = row["tckimlikno"].ToString();
                adtx.Text = row["ad"].ToString();
                soytx.Text = row["soyad"].ToString();
                ctx.Text = row["cinsiyet"].ToString();
                babatx.Text = row["babaadi"].ToString();
                annetx.Text = row["anneadi"].ToString();
                dttx.Text = row["dogumtarih"].ToString();
                teltx.Text = row["telefonno"].ToString();
                adrestx.Text = row["adres"].ToString();
                dytx.Text = row["dogumyeri"].ToString();
                textBox1.Text = Application.StartupPath + "\\resimler\\" + row["resim"].ToString();
                pictureBox1.Load(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Okutulan karta ait hasta bilgisi zaten mevcut değil.");
                baglanti.Close();
                this.Close();
            }

            baglanti.Close();
            labelac();
        }

        string rfid, tc, ad, soyad;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
          + Application.StartupPath + "\\veritabani.mdb");
        private void sil_Click(object sender, EventArgs e)
        {
            if (rfid_No.Text != "")
            {
                rfid = rfid_No.Text;
                tc = tctx.Text;
                ad = adtx.Text;
                soyad = soytx.Text;

                DialogResult dialog = new DialogResult();


                dialog = MessageBox.Show(tc + " TC li " + ad.ToUpper() + " " + soyad.ToUpper() + " kişisine ait HASTANE KAYITINI silmek istediğinize eminmisiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    DialogResult dialog2 = new DialogResult();
                    dialog2 = MessageBox.Show("Bu Hasta ve Hastaya ait TÜM RANDEVULAR silinecek. Bu işlem geri alınamaz. Devam etmek istiyormusunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog2 == DialogResult.Yes)
                    {

                        if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                        OleDbCommand del = new OleDbCommand("DELETE FROM Hastalar where rfid_id=@rfid_id", baglanti);
                        del.Parameters.AddWithValue("@rfid_id", rfid_No.Text);
                        del.ExecuteNonQuery();

                        if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                        OleDbCommand del2 = new OleDbCommand("DELETE FROM randevular where tc=@tc", baglanti);
                        del2.Parameters.AddWithValue("@tc", tctx.Text);
                        del2.ExecuteNonQuery();

                        if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                        OleDbCommand del3 = new OleDbCommand("DELETE FROM doktor_randevu where kisitc=@kisitc", baglanti);
                        del3.Parameters.AddWithValue("@kisitc", tctx.Text);
                        del3.ExecuteNonQuery();

                        MessageBox.Show("Hastaya ait TÜM HASTANE KAYITLARI silindi!");

                    }
                    else MessageBox.Show("İşlem iptal edildi!");
                }
                else MessageBox.Show("İşlem iptal edildi!");
            }
            else MessageBox.Show("Herhangi bir kart okutulmadı");

        }
    }
}
