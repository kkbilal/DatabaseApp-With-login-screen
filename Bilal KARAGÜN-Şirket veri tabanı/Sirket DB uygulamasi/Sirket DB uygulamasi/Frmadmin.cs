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
    public partial class Frmadmin : Form
    {
        public Frmadmin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=\"Sirket DB\";Integrated Security=True");   
        private void btnGiris_Click(object sender, EventArgs e)
        {
            /* if (txtkullaniciadi.Text == "admin" && txtsifre.Text =="12345")
             {
                 Frmadmin fr = new Frmadmin();
                 fr.Show();
                 this.Hide();

             }
             else
             {
                 MessageBox.Show("Kullanıcı adı veya Şifre hatalı!");
             } */
            try
            {
                baglanti.Open();
                string sql = "select * from admin where yoneticiadi=@adi and yoneticisifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi",txtkullaniciadi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txtsifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FrmAnaSayfa fr = new FrmAnaSayfa();
                    fr.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş!");
            }
        }
    }
}
