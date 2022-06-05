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
    public partial class frmMusteri : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public frmMusteri()
        {
            InitializeComponent();
        }
        void MusteriGetir()
        {
            baglanti = new SqlConnection("server=DESKTOP-R5V47BO; Initial Catalog=araç_kıralama;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From musteribilgi2", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
            private void frmMusteri_Load(object sender, EventArgs e)
            {
                MusteriGetir();
            }
            private void btnKaydet_Click(object sender, EventArgs e)
            {
            string sorgu = "Insert into musteribilgi2 (musteri_id,TCno,Ad,soyad,cinsiyet,doğumtarihi,mail,adres,telefon,ehliyet_no,ehliyet_tarih) values (@musteri_id,@TCno,@ad,@soyad,@cinsiyet,@doğumtarihi,@mail,@adres,@telefon,@ehliyet_no,@ehliyet_tarih)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@musteri_id", txtmusteri_id.Text);
            komut.Parameters.AddWithValue("@TCno", txtTC.Text);
            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@cinsiyet", txtCinsiyet.Text);
            komut.Parameters.AddWithValue("@doğumtarihi", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@mail", txtMail.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@ehliyet_no", txtehliyetno.Text);
            komut.Parameters.AddWithValue("@ehliyet_tarih", dtpehliyet.Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
            }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmusteri_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCinsiyet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtehliyetno.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            dtpehliyet.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From musteribilgi2 Where TCno=@TCno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TCno", (txtTC.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }
        private void btnduzenle_Click(object sender, EventArgs e)
        {
            string sorgu = "Update musteribilgi2 Set TCno=@TCno, ad=@ad,soyad=@soyad, cinsiyet=@cinsiyet, doğumtarihi=@doğumtarihi, mail=@mail, adres=@adres, telefon=@telefon, ehliyet_no=@ehliyet_no, ehliyet_tarih=@ehliyet_tarih Where musteri_id=@musteri_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@musteri_id", txtmusteri_id.Text);
            komut.Parameters.AddWithValue("@TCno", txtTC.Text);
            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@cinsiyet", txtCinsiyet.Text);
            komut.Parameters.AddWithValue("@doğumtarihi", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@mail", txtMail.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@ehliyet_no", txtehliyetno.Text);
            komut.Parameters.AddWithValue("@ehliyet_tarih", dtpehliyet.Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
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
    }
}
