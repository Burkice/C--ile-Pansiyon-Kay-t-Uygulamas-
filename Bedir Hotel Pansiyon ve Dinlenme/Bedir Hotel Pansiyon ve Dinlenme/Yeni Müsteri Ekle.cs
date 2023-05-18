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
    public partial class Yeni_Müsteri_Ekle : Form
    {
        public Yeni_Müsteri_Ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti =new SqlConnection(@"Data Source=Burak_Laptop;Initial Catalog=Bedir_Hotel;Integrated Security=True");
        //sql bağlantısını yaptık

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_101_Click(object sender, EventArgs e)
        {
            txt_room.Text = "101";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda101(Adi,Soyadi) values ('" + txt_ad.Text + "','" + txt_soyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery(); 
            baglanti.Close();
        }

        private void btn_102_Click(object sender, EventArgs e)
        {
            txt_room.Text = "102";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda102(Adi,Soyadi) values ('" + txt_ad.Text + "','" + txt_soyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn_103_Click(object sender, EventArgs e)
        {
            txt_room.Text = "103";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda103(Adi,Soyadi) values ('" + txt_ad.Text + "','" + txt_soyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn_104_Click(object sender, EventArgs e)
        {
            txt_room.Text = "104";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda104(Adi,Soyadi) values ('" + txt_ad.Text + "','" + txt_soyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn_105_Click(object sender, EventArgs e)
        {
            txt_room.Text = "105";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda105(Adi,Soyadi) values ('" + txt_ad.Text + "','" + txt_soyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn_106_Click(object sender, EventArgs e)
        {
            txt_room.Text = "106";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda106(Adi,Soyadi) values ('" + txt_ad.Text + "','" + txt_soyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn_107_Click(object sender, EventArgs e)
        {
            txt_room.Text = "107";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda107(Adi,Soyadi) values ('" + txt_ad.Text + "','" + txt_soyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn_108_Click(object sender, EventArgs e)
        {
            txt_room.Text = "108";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda108(Adi,Soyadi) values ('" + txt_ad.Text + "','" + txt_soyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn_109_Click(object sender, EventArgs e)
        {
            txt_room.Text = "109";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda109(Adi,Soyadi) values ('" + txt_ad.Text + "','" + txt_soyad.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn_dolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar dolu odaları gösterir.", "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                

        }

        private void btn_bos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar boş odaları gösterir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dateTimePicker_quit_ValueChanged(object sender, EventArgs e)
        {
            int ucret; //ucret değişkenini tanımladık

            DateTime kucukTarih = Convert.ToDateTime(dateTimePicker_girisTarihi.Text); //Giriş tarihini convert ettik.
            DateTime BuyukTarih=Convert.ToDateTime(dateTimePicker_quit.Text);

            TimeSpan Sonuc = BuyukTarih - kucukTarih;  //TimeSpan iki tarih arasındaki farkı alır.

            label13.Text = Sonuc.TotalDays.ToString(); //Total günü hesaplıyo ve labele yazdırıyo

            ucret = Convert.ToInt32(label13.Text) * 300;
            txt_ucret.Text = ucret.ToString();





        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into MüsteriEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,Tc,OdaNo,Ucret,GirisTarihi,CikisTarihi) values ('" + txt_ad.Text + "','"+ txt_soyad.Text + "','"+comboBox_cinsiyet.Text +"','"+txt_tel.Text+"','"+txt_mail.Text+"','"+txt_tc.Text+"','"+txt_room.Text+"','"+txt_ucret.Text+"','"+dateTimePicker_girisTarihi.Value.ToString("yyyy-MM-dd")+"','"+dateTimePicker_quit.Value.ToString("yyy-MM-dd")+"')",baglanti);
            sqlCommand.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müsteri Kaydı Başarıyla Yapıldı","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);

           /* txt_ad.Text=string.Empty;
            txt_mail.Text=string.Empty;
            txt_room.Text=string.Empty;
            txt_soyad.Text=string.Empty;
            txt_tc.Text=string.Empty;
           */

            var nesneler=groupBox1.Controls.OfType<TextBox>();

            foreach(var nesne in nesneler)
            {
                nesne.Clear();                       //Burada string değerlerini temizledik
            }
            

            

        }

        private void Yeni_Müsteri_Ekle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btn_101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btn_101.Text != "101")
            {
                btn_101.BackColor = Color.Red;
                btn_101.Enabled = false;
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
                btn_102.Enabled = false;
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
                btn_103.Enabled = false;
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
                btn_104.Enabled = false;
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
                btn_105.Enabled = false;
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
                btn_106.Enabled = false;
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
                btn_107.Enabled = false;
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
                btn_108.Enabled = false;
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
                btn_109.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaform frm = new FrmAnaform();
            frm.Show();
            this.Hide();
        }
    }
}


//Data Source=Burak_Laptop;Initial Catalog=Bedir_Hotel;Integrated Security=True bağlantı yolu
