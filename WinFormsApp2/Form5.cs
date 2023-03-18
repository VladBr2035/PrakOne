using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //Новости
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e) //Профиль
        {
            Form3 newForm = new Form3();
            newForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) //Пополнить счет
        {
            Form7 newForm = new Form7();
            newForm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e) //Каталог
        {
            Form4 newForm = new Form4();
            newForm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
