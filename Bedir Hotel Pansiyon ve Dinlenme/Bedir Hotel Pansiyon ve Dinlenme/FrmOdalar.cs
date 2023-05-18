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

namespace Bedir_Hotel_Pansiyon_ve_Dinlenme
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = Burak_Laptop\\; Initial Catalog = Bedir_Hotel; Integrated Security = True");

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
           baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1=komut1.ExecuteReader();

            while(oku1.Read())
            {
                btn_101.Text = oku1["Adi"].ToString()+" "+ oku1["Soyadi"].ToString();

            }
            baglanti.Close();
            if(btn_101.Text!="101")
            {
                btn_101.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btn_102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btn_102.Text != "102")
            {
                btn_102.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btn_103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btn_103.Text != "103")
            {
                btn_103.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                btn_104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btn_104.Text != "104")
            {
                btn_104.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                btn_105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btn_105.Text != "105")
            {
                btn_105.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                btn_106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btn_106.Text != "106")
            {
                btn_106.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                btn_107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btn_107.Text != "107")
            {
                btn_107.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                btn_108.Text = oku8["Adi"].ToString() + " " + oku2["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btn_108.Text != "108")
            {
                btn_108.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                btn_109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btn_109.Text != "109")
            {
                btn_109.BackColor = Color.Red;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaform frmAnaform = new FrmAnaform();
            frmAnaform.Show();
            this.Hide();
        }
    }
}

//Data Source = Burak_Laptop; Initial Catalog = Bedir_Hotel; Integrated Security = True
