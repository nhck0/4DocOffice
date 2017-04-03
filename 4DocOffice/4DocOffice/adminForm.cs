using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4DocOffice
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutTheProgram about = new aboutTheProgram();
            //this.Close();
            about.Show();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authorization login = new authorization();
            this.Hide();
            login.Show();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Profession". При необходимости она может быть перемещена или удалена.
            this.professionTableAdapter.Fill(this.docOfficeDataSet.Profession);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Medical_tests". При необходимости она может быть перемещена или удалена.
            this.medical_testsTableAdapter.Fill(this.docOfficeDataSet.Medical_tests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.docOfficeDataSet.Doctor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                professionBindingSource.AddNew();
            }

            if (tabControl1.SelectedIndex == 1)
            {
                doctorBindingSource.AddNew();
            }

            if (tabControl1.SelectedIndex == 2)
            {
                medical_testsBindingSource.AddNew();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                int ind = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(ind);
            }

            if (tabControl1.SelectedIndex == 1)
            {
                int ind = dataGridView2.SelectedCells[0].RowIndex;
                dataGridView2.Rows.RemoveAt(ind);
            }

            if (tabControl1.SelectedIndex == 2)
            {
                int ind = dataGridView3.SelectedCells[0].RowIndex;
                dataGridView3.Rows.RemoveAt(ind);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.professionTableAdapter.Update
               (this.docOfficeDataSet.Profession);
                this.professionTableAdapter.Fill(this.docOfficeDataSet.Profession);
            }

            if (tabControl1.SelectedIndex == 1)
            {
                this.doctorTableAdapter.Update
               (this.docOfficeDataSet.Doctor);
                this.doctorTableAdapter.Fill(this.docOfficeDataSet.Doctor);
            }

            if (tabControl1.SelectedIndex == 2)
            {
                this.medical_testsTableAdapter.Update
               (this.docOfficeDataSet.Medical_tests);
                this.medical_testsTableAdapter.Fill(this.docOfficeDataSet.Medical_tests);

            }

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
