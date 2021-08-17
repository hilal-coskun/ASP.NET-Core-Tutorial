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

namespace EntityOrnekProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-7T3A46FU\MSSQLSERVER_2;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("Select * from tblDersler",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOgrenci.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnNotListesi_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLNotlar
                        select new { item.NOTID, item.OgrID, item.DersID, item.Sinav1,item.Sinav2, item.Sinav3, item.Ortalama, item.Durum };
            dataGridView1.DataSource = query.ToList();
            /*dataGridView1.DataSource = db.TBLNotlar.ToList();
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;*/
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLOgrenci t = new TBLOgrenci();
            t.Ad = txtAd.Text;
            t.Soyad = txtSoyad.Text;
            db.TBLOgrenci.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ogrenci listeye eklenmiştir..");
            
        }

        private void btnDersKayıt_Click(object sender, EventArgs e)
        {
            TBLDersler d = new TBLDersler();
            d.DERSAD = txtDersAdı.Text;
            db.TBLDersler.Add(d);
            db.SaveChanges();
            MessageBox.Show("Ders listeye eklenmiştir");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrenciID.Text);
            var x = db.TBLOgrenci.Find(id);
            db.TBLOgrenci.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci silindi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrenciID.Text);
            var x = db.TBLOgrenci.Find(id);
            x.Ad = txtAd.Text;
            x.Soyad = txtSoyad.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci güncellendi");
        }
    }
}
