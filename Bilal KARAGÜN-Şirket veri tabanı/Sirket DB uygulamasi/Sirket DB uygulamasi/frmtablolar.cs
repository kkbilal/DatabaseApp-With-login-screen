using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Sirket_DB_uygulamasi
{
    public partial class frmtablolar : Form
    {
        public frmtablolar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=\"Sirket DB\";Integrated Security=True");
        private void veriunvan()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from unvan", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["unvan_no"].ToString();
                ekle.SubItems.Add(oku["unvan_ad"].ToString());
              
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void veriil()
        {
            listView5.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from il", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["il_no"].ToString();
                ekle.SubItems.Add(oku["il_ad"].ToString());

                listView5.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void veribirim()
        {
            listView3.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from birim", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["birim_no"].ToString();
                ekle.SubItems.Add(oku["birim_ad"].ToString());

                listView3.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void veriilce()
        {
            listView4.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from ilce", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ilce_no"].ToString();
                ekle.SubItems.Add(oku["ilce_ad"].ToString());
                ekle.SubItems.Add(oku["il_no"].ToString());

                listView4.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void veriproje()
        {
            listView6.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from proje", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["proje_no"].ToString();
                ekle.SubItems.Add(oku["proje_ad"].ToString());
                ekle.SubItems.Add(oku["baslama_tarihi"].ToString());
                ekle.SubItems.Add(oku["planlanan_bitis_tarihi"].ToString());

                listView6.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void verigorevlendirme()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from gorevlendirme", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["gorevlendirme_no"].ToString();
                ekle.SubItems.Add(oku["proje_no"].ToString());
                ekle.SubItems.Add(oku["personel_no"].ToString());

                listView2.Items.Add(ekle);
            }
            baglanti.Close();
        }




        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void butveriunvan_Click(object sender, EventArgs e)
        {
            veriunvan();
        }

        private void butveriil_Click(object sender, EventArgs e)
        {
            veriil();
        }

        private void butveribirim_Click(object sender, EventArgs e)
        {
            veribirim();
        }

        private void butverigörev_Click(object sender, EventArgs e)
        {
            verigorevlendirme();
        }

        private void butveriilce_Click(object sender, EventArgs e)
        {
            veriilce();
        }

        private void butveriproje_Click(object sender, EventArgs e)
        {
            veriproje ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
        }
    }
}
