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
    public partial class Frmpersoneller : Form
    {
        public Frmpersoneller()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=\"Sirket DB\";Integrated Security=True");
        private void verilerigoster()
        {   listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from personel", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["personel_no"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["dogum_tarihi"].ToString());
                ekle.SubItems.Add(oku["dogum_yeri"].ToString());
                ekle.SubItems.Add(oku["baslama_tarihi"].ToString());
                ekle.SubItems.Add(oku["birim_no"].ToString());
                ekle.SubItems.Add(oku["unvan_no"].ToString());
                ekle.SubItems.Add(oku["calisma_saati"].ToString());
                ekle.SubItems.Add(oku["maas"].ToString());
                ekle.SubItems.Add(oku["prim"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();

        }

        private void Frmpersoneller_Load(object sender, EventArgs e)
        {

        }

        private void Frmpersoneller_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        int id = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtadi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoy.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtcins.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtdogumt.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtdogumy.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtbaslama.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtbirim.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtunvan.Text = listView1.SelectedItems[0].SubItems[8].Text;
            txtcalismasaat.Text = listView1.SelectedItems[0].SubItems[9].Text;
            txtmaas.Text = listView1.SelectedItems[0].SubItems[10].Text;
            txtprim.Text = listView1.SelectedItems[0].SubItems[11].Text;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from personel where personel_no=("+id+")",baglanti); //personel silmeye yarayan komut dizini fakat hata alıyorum
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtadi.Clear();
            txtsoy.Clear();
            txtcins.Clear();
            txtdogumt.Clear();
            txtdogumy.Clear();
            txtbaslama.Clear();                                                                                                                                                                                                                                                                             
            txtbirim.Clear();
            txtunvan.Clear();
            txtcalismasaat.Clear();
            txtmaas.Clear();
            txtprim.Clear();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update personel set ad='" + txtadi.Text + "',soyad='" + txtsoy.Text + "',cinsiyet='" + txtcins.Text +  "',dogum_yeri='" + txtdogumy.Text +  "',birim_no='" + txtbirim.Text + "',unvan_no='" + txtunvan.Text + "',calisma_saati='" + txtcalismasaat.Text + "',maas='" + txtmaas.Text + "',prim='" + txtprim.Text + "'where personel_no=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from personel where Ad like '%"+txtad.Text+"'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["personel_no"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["dogum_tarihi"].ToString());
                ekle.SubItems.Add(oku["dogum_yeri"].ToString());
                ekle.SubItems.Add(oku["baslama_tarihi"].ToString());
                ekle.SubItems.Add(oku["birim_no"].ToString());
                ekle.SubItems.Add(oku["unvan_no"].ToString());
                ekle.SubItems.Add(oku["calisma_saati"].ToString());
                ekle.SubItems.Add(oku["maas"].ToString());
                ekle.SubItems.Add(oku["prim"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butmain_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
        }
    }
}
/*    Data Source=.\SQLEXPRESS;Initial Catalog="Sirket DB";Integrated Security=True    */