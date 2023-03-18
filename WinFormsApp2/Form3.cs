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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //Пополнить счет 
        {
            Form7 newForm = new Form7();
            newForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e) //Новости
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e) //Каталог
        {
            Form4 newForm = new Form4();
            newForm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e) //Корзина
        {
            Form5 newForm = new Form5();
            newForm.Show();
            this.Close();
        }
    }
}
