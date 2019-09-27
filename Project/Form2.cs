using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace Project
{

    public partial class Form2 : Form
    {



        public Form2()
        {
            InitializeComponent();
        }








        private void button5_Click(object sender, EventArgs e)
        {

            string str;
            str = "";
            OutData.Text = "";


            OutData.Text = " " + "คุณ " + txt1.Text + " " + textbirth.Text + " " + txtaddress.Text + " " + txtmail.Text + " " + txttel.Text;

            int cbz1;
            int cbz2;
            int cbz3;
            int cbz4;
            int cbz5;
            int cbz6;
            int cbz7;
            int cbz8;
            int cbz9;
            int cbz10;
            int cbz11;
            int sumzall;

            string cbz1t;
            string cbz2t;
            string cbz3t;
            string cbz4t;
            string cbz5t;
            string cbz6t;
            string cbz7t;
            string cbz8t;
            string cbz9t;
            string cbz10t;
            string cbz11t;



            if (cb1.Checked == true)

            {
                cbz1t = "เอสเพรสโซ ";
                cbz1 = 40;
            }
            else
            {
                cbz1t = "";
                cbz1 = 0;
            }


            if (cb2.Checked == true)
            {
                cbz2t = "อเมริกาโน่ ";
                cbz2 = 60;
            }
            else
            {
                cbz2t = "";
                cbz2 = 0;
            }

            if (cb3.Checked == true)

            {
                cbz3t = "ลาเต้ ";
                cbz3 = 55;
            }
            else
            {
                cbz3t = "";
                cbz3 = 0;
            }


            if (cb4.Checked == true)
            {
                cbz4t = "โกโก้ร้อน ";
                cbz4 = 55;
            }
            else
            {
                cbz4t = "";
                cbz4 = 0;
            }


            if (cb5.Checked == true)
            {
                cbz5t = "คาปูชิโน ";
                cbz5 = 80;
            }
            else
            {
                cbz5t = "";
                cbz5 = 0;
            }


            if (cb6.Checked == true)
            {
                cbz6t = "โกโกเย็น ";
                cbz6 = 55;
            }
            else
            {
                cbz6t = "";
                cbz6 = 0;
            }


            if (cb7.Checked == true)
            {
                cbz7t = "เฮเซอนัส ";
                cbz7 = 59;
            }
            else
            {
                cbz7t = "";
                cbz7 = 0;
            }


            if (cb8.Checked == true)
            {
                cbz8t = "มัฟฟินบลูเบอร์รี่ ";
                cbz8 = 45;
            }
            else
            {
                cbz8t = "";
                cbz8 = 0;
            }

            if (cb9.Checked == true)
            {
                cbz9t = "ฮันนี่โทสต์ ";
                cbz9 = 120;
            }
            else
            {
                cbz9t = "";
                cbz9 = 0;
            }

            if (cb10.Checked == true)
            {
                cbz10t = "มากาลอง (1 ชุด) ";
                cbz10 = 239;
            }
            else
            {
                cbz10t = "";
                cbz10 = 0;
            }

            if (cb11.Checked == true)
            {
                cbz11t = "รอฟเฟิล";
                cbz11 = 150;
            }
            else
            {
                cbz11t = "";
                cbz11 = 0;
            }

          

            sumzall = cbz1 + cbz2 + cbz3 + cbz4 + cbz5 + cbz6 + cbz7 + cbz8 + cbz9 + cbz10 + cbz11;


            order.Text = cbz1t + cbz2t + cbz3t + cbz4t + cbz5t + cbz6t + cbz7t + cbz8t + cbz9t + cbz10t + cbz11t;
            sumz.Text = (sumzall + " บาท ");








        }

        /////////////////

        private void button22_Click_1(object sender, EventArgs e)
        {


            txt1.Clear();
            textbirth.Clear();
            txtaddress.Clear();
            txtmail.Clear();
            txttel.Clear();
            OutData.Clear();
            order.Clear();
            sumz.Clear();

            //////////////////////////////

            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
            cb5.Checked = false;
            cb6.Checked = false;
            cb7.Checked = false;
            cb8.Checked = false;
            cb9.Checked = false;
            cb10.Checked = false;
            cb11.Checked = false;
        }


        private void button88_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("แล้วเจอกันใหม่ในโอกาสหน้าที่ร้าน CoffeeCafe น่ะครับ/ค่ะ ", "CoffeeCafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = false;

        }



        /////////////////







        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OutData_TextChanged(object sender, EventArgs e)
        {

        }

        private void order_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void emailsend_Click(object sender, EventArgs e)
        {

            MailMessage mail = new MailMessage();
            SmtpClient server = new SmtpClient("smtp-mail.outlook.com");
            mail.From = new MailAddress("lovegod_jubjub@hotmail.com");
            mail.To.Add("lovegod_jubjub @hotmail.com"); 
            mail.Subject = ("สั่งอาหาร " + OutData.Text);
            mail.Body = (order.Text + "รวม " + sumz.Text);
            server.Port = 587;
            server.Credentials = new System.Net.NetworkCredential("lovegod_jubjub@hotmail.com", "jutiporn");
            server.EnableSsl = true;

           server.Send(mail);



            try
            {
                
                string ConnectString2 = "datasource = localhost; username = root; password =; database = coffeshop ;SslMode = none ;character set=utf8";
         
            string Query = "insert into coffeshop.info(name,address,number,list,price) values('" +this.txt1.Text + this.textbirth.Text + "', '" +  this.txtaddress.Text + this.txtmail.Text  + "', '" + this.txttel.Text + "', '" +  this.order.Text + "', '" + this.sumz.Text+ "');";




                MySqlConnection MyConn2 = new MySqlConnection(ConnectString2);
          
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();   
            MessageBox.Show("สั่งกาแฟเรียบร้อย จะส่งถึงที่อยู่ภายใน 15 นาที ขอบคุณที่ใช้บริการครับ/ค่ะ", "CoffeeCafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }















        }
        private void DBconnection()
        {

            {
                string ConnectString = "datasource = localhost; username = root; password =; database = coffeshop ;SslMode = none";
                MySqlConnection DBconnect = new MySqlConnection(ConnectString);

                try
                {
                    DBconnect.Open();
                    MessageBox.Show("เชื่อมต่อแล้ว");

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }

    }
}

