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
    public partial class FrmMüsteri : Form
    {
        public FrmMüsteri()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Burak_Laptop;Initial Catalog=Bedir_Hotel;Integrated Security=True");
        private void verilerigoster()
        {
            listView.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from MüsteriEkle", conn); //Burda tabloyu göstermesini istedik
            SqlDataReader read = cmd.ExecuteReader(); //Girilen parametreleri okuyo
            while(read.Read()) 
            {
              ListViewItem item = new ListViewItem();
                item.Text = read["Müsteri_id"].ToString();
                item.SubItems.Add(read["Adi"].ToString());
                item.SubItems.Add(read["Soyadi"].ToString());
                item.SubItems.Add(read["Cinsiyet"].ToString());
                item.SubItems.Add(read["Telefon"].ToString());
                item.SubItems.Add(read["Mail"].ToString());
                item.SubItems.Add(read["Tc"].ToString());
                item.SubItems.Add(read["OdaNo"].ToString());
                item.SubItems.Add(read["Ucret"].ToString());
                item.SubItems.Add(read["GirisTarihi"].ToString());
                item.SubItems.Add(read["CikisTarihi"].ToString());
                listView.Items.Add(item);



            }
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            verilerigoster();

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////
        }
        int id = 0;
        private void listView_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView.SelectedItems[0].SubItems[0].Text);
            txt_ad.Text = listView.SelectedItems[0].SubItems[1].Text;
            txt_soyad.Text = listView.SelectedItems[0].SubItems[2].Text;
            comboBox_cinsiyet.Text = listView.SelectedItems[0].SubItems[3].Text;
            txt_tel.Text = listView.SelectedItems[0].SubItems[4].Text;
            txt_mail.Text = listView.SelectedItems[0].SubItems[5].Text;
            txt_tc.Text = listView.SelectedItems[0].SubItems[6].Text;
            txt_room.Text = listView.SelectedItems[0].SubItems[7].Text;
            txt_ucret.Text = listView.SelectedItems[0].SubItems[8].Text;
            dateTimePicker_girisTarihi.Text = listView.SelectedItems[0].SubItems[9].Text;
            dateTimePicker_quit.Text = listView.SelectedItems[0].SubItems[10].Text;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from MüsteriEkle where Müsteri_id=(" + id + ")",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            verilerigoster();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_ad.Clear();
            txt_soyad.Clear();
            comboBox_cinsiyet.Text = " ";
            txt_tel.Clear();
            txt_mail.Clear();
            txt_tc.Clear();
            txt_room.Clear();
            txt_ucret.Clear();
            dateTimePicker_girisTarihi.Text= "";
            dateTimePicker_quit.Text= "";
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update  MüsteriEkle set Adi ='" + txt_ad.Text + "',Soyadi='" + txt_soyad.Text + "',Cinsiyet='" + comboBox_cinsiyet.Text + "',Telefon='" + txt_tel.Text + "',Mail='" + txt_mail.Text + "',Tc='" + txt_tc.Text + "',OdaNo='" + txt_room.Text + "',Ucret='" + txt_ucret.Text + "',GirisTarihi='" + dateTimePicker_girisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + dateTimePicker_quit.Value.ToString("yyyy-MM-dd") + "'where Müsteri_id=" + id + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            verilerigoster();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from MüsteriEkle where Adi like '%" + textBox1.Text+"%'",conn); //Burda tabloda sorgu yaptık
            SqlDataReader read = cmd.ExecuteReader(); //Girilen parametreleri okuyo
            while (read.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = read["Müsteri_id"].ToString();
                item.SubItems.Add(read["Adi"].ToString());
                item.SubItems.Add(read["Soyadi"].ToString());
                item.SubItems.Add(read["Cinsiyet"].ToString());
                item.SubItems.Add(read["Telefon"].ToString());
                item.SubItems.Add(read["Mail"].ToString());
                item.SubItems.Add(read["Tc"].ToString());
                item.SubItems.Add(read["OdaNo"].ToString());
                item.SubItems.Add(read["Ucret"].ToString());
                item.SubItems.Add(read["GirisTarihi"].ToString());
                item.SubItems.Add(read["CikisTarihi"].ToString());
                listView.Items.Add(item);



            }
            conn.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaform frmAnaform = new FrmAnaform();
            frmAnaform.Show();
            this.Hide();
        }
    }
}

//Bağlantı Adresi=Data Source=Burak_Laptop;Initial Catalog=Bedir_Hotel;Integrated Security=True
