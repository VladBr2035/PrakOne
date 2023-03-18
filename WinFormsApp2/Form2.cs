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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Профиль
        {
            Form3 newForm = new Form3();
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

        private void pictureBox1_Click(object sender, EventArgs e) //Страница игры
        {
            Form6 newForm = new Form6();
            newForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) //Пополнить счет
        {
            Form7 newForm = new Form7();
            newForm.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
