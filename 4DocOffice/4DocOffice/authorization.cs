using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _4DocOffice
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox2.Select();
            comboBox1.Text = "Doctor";
        }

        // Авторизация
        private void button1_Click(object sender, EventArgs e)
        {

            adminForm admin = new adminForm();
            doctorsForm doc = new doctorsForm();
            //try
            //{
            //int prem = this.checkAutorizTableAdapter.Fill(this.docOfficeDataSet.checkAutoriz, comboBox1.Text, textBox2.Text);
            //    if (this.checkAutorizTableAdapter.Fill(this.docOfficeDataSet.checkAutoriz, comboBox1.Text, textBox2.Text) == 1)
            //    {
            //        this.Hide();
            //        admin.Show();
            //    }
            //    else if (this.checkAutorizTableAdapter.Fill(this.docOfficeDataSet.checkAutoriz, comboBox1.Text, textBox2.Text) == 2)
            //    {
            //        this.Hide();
            //        doc.Show();
            //    }
            //    //else if (prem != 1 || prem != 2)
            //    //{
            //    //    MessageBox.Show("Введен неверный пароль.");
            //    //}
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
            if (comboBox1.Text == "Admin")
            {
                if (textBox2.Text == "111")
                {
                    this.Hide();
                    admin.Show();
                }
                else MessageBox.Show("Неверный пароль");
            }

            else if (comboBox1.Text == "Doctor")
            {
                if (textBox2.Text == "222")
                {
                    this.Hide();
                    doc.Show();
                }
                else MessageBox.Show("Неверный пароль");
            }
        }

        private void authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
