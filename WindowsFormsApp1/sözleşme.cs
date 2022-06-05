using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class sözleşme : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public sözleşme()
        {
            InitializeComponent();
        }
        void AraçGetir()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-R5V47BO;Initial Catalog=araç_kıralama;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM araçbilgi2";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["plaka"]);
            }
            baglanti.Close();
        }
        void MusteriGetir()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-R5V47BO;Initial Catalog=araç_kıralama;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM musteribilgi2";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbtc.Items.Add(dr["tcno"]);
            }
            baglanti.Close();
        }
        void SözlesmeGetir()
        {
            baglanti = new SqlConnection("server=DESKTOP-R5V47BO; Initial Catalog=araç_kıralama;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From sözlesme", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void closebuttons_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void minimizebuttons_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panelüst_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void panelüst_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }
        private void panelüst_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
        private void sözleşme_Load(object sender, EventArgs e)
        {
            AraçGetir();
            MusteriGetir();
            SözlesmeGetir();
            
        }
        private void maximizebuttons_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestart.Visible = true;
            maximizebuttons.Visible = false;
        }
        private void iconrestart_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestart.Visible = false;
            maximizebuttons.Visible = true;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            komut = new SqlCommand("Select * From araçbilgi2 Where plaka ='" + comboBox2.Text+"'", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string id = (string)dr["id"].ToString();
                txtaraç_id.Text = id;

                string marka = (string)dr["marka"].ToString();
                comboBox3.Text = marka;

                string model = (string)dr["model"].ToString();
                comboBox4.Text = model;

                string renk = (string)dr["renk"].ToString();
                comboBox5.Text = renk;

                string günlük = (string)dr["günlük"].ToString();
                txtgünlük.Text = günlük;

                string resim = (string)dr["resim"].ToString();
                pictureBox1.ImageLocation = resim;
            }
            baglanti.Close();
        }
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            DateTime btarih = Convert.ToDateTime(dtbaslamaTarihi.Text);
            DateTime ktarih = Convert.ToDateTime(dtbitisTarihi.Text);
            lblKalanGun.Refresh();
            TimeSpan Sonuc = ktarih - btarih;

            lblKalanGun.Text = Sonuc.TotalDays.ToString();
        }
        private void btnhesapla_Click(object sender, EventArgs e)
        {
            int sonuc;
            int sayi1 = Convert.ToInt32(lblKalanGun.Text);
            int sayi2 = Convert.ToInt32(txtgünlük.Text);

            sonuc = sayi1 * sayi2;
            txtfiyat.Text = sonuc.ToString();
        }
        private void cmbtc_SelectedIndexChanged(object sender, EventArgs e)
        {
            komut = new SqlCommand("Select * From musteribilgi2 Where tcno ='" + cmbtc.Text + "'", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string ad = (string)dr["ad"].ToString();
                txtAd.Text = ad;

                string soyad = (string)dr["soyad"].ToString();
                txtSoyad.Text = soyad;

                string cinsiyet = (string)dr["cinsiyet"].ToString();
                txtCinsiyet.Text = cinsiyet;

                string doğumtarihi = (string)dr["doğumtarihi"].ToString();
                dateTimePicker1.Text = doğumtarihi;

                string mail = (string)dr["mail"].ToString();
                txtMail.Text = mail;

                string adres = (string)dr["adres"].ToString();
                txtAdres.Text = adres;

                string telefon = (string)dr["telefon"].ToString();
                txtTel.Text = telefon;

                string ehliyet_no = (string)dr["ehliyet_no"].ToString();
                txtehliyetno.Text = ehliyet_no;

                string ehliyet_tarih = (string)dr["ehliyet_tarih"].ToString();
                dateTimePicker2.Text = ehliyet_tarih;

                string musteri_id = (string)dr["musteri_id"].ToString();
                txtsiparis_id.Text = musteri_id;
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into sözlesme (musteri_id,başlama_tarihi,bitiş_tarihi,fiyat,id,tcno) values (@musteri_id,@başlama_tarihi,@bitiş_tarihi,@fiyat,@id,@tcno)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@musteri_id", txtsiparis_id.Text);
            komut.Parameters.AddWithValue("@başlama_tarihi", dtbaslamaTarihi.Value);
            komut.Parameters.AddWithValue("@bitiş_tarihi", dtbitisTarihi.Value);
            komut.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
            komut.Parameters.AddWithValue("@id", txtaraç_id.Text);
            komut.Parameters.AddWithValue("@tcno", cmbtc.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            SözlesmeGetir();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From sözlesme Where musteri_id=@musteri_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@musteri_id", (txtsiparis_id.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            SözlesmeGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsiparis_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
