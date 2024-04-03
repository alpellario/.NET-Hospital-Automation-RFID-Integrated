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
    public partial class HastaOku : Form
    {



        string[] portlar = SerialPort.GetPortNames();
        public HastaOku()
        {
            InitializeComponent();
            baglantiAc.Text = "Bağlantı Aç";
            baglantiAc.BackColor = Color.Yellow;
            groupBox1.Text = "BAĞLANTI";

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

        private void HastaOku_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("0");
                serialPort1.Close();


            }
        }

        private void HastaOku_Load(object sender, EventArgs e)
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
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            bool varmi = true;
            labeltemizle();
            string data = serialPort1.ReadExisting();
            rfid_No.Text = data;
            serialPort1.Write("1");
            serialPort1.Write("0");
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
          + Application.StartupPath + "\\veritabani.mdb");
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();

            //OleDbCommand rfoku = new OleDbCommand("select *from Hastalar", baglanti);
            //OleDbDataReader rfkontrol = rfoku.ExecuteReader();
            //DataTable kontrol = new DataTable();
            //kontrol.Load(rfkontrol);
            //for (int tcs = 0; tcs < kontrol.Rows.Count; tcs++)
            //{
            //    if (rfid_No.Text != kontrol.Rows[tcs][0].ToString())
            //    {
                    
                    
            //    }
            //}
            

            
            OleDbCommand komut = new OleDbCommand("Select islemtarih,tckimlikno,ad,soyad,cinsiyet,babaadi,anneadi,dogumtarih,telefonno,adres,resim,dogumyeri from Hastalar where rfid_id=" + rfid_No.Text + "", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                islemtx.Text = dr["islemtarih"].ToString();
                tctx.Text = dr["tckimlikno"].ToString();
                adtx.Text = dr["ad"].ToString();
                soytx.Text = dr["soyad"].ToString();
                ctx.Text = dr["cinsiyet"].ToString();
                babatx.Text = dr["babaadi"].ToString();
                annetx.Text = dr["anneadi"].ToString();
                dttx.Text = dr["dogumtarih"].ToString();
                teltx.Text = dr["telefonno"].ToString();
                adrestx.Text = dr["adres"].ToString();
                dytx.Text = dr["dogumyeri"].ToString();
                textBox1.Text = dr["resim"].ToString();
                pictureBox1.Load( Application.StartupPath + "\\resimler\\" + textBox1.Text);
                
                

                
                

            }
            baglanti.Close();
            labelac();
        }
    }
}
