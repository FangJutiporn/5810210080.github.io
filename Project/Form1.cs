using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.Visible = true;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("แล้วเจอกันใหม่โอกาสหน้าที่ร้าน CoffeeCafe Project น่ะครับ/ค่ะ", "CoffeeCafe Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = false;
        }
    }
}
