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
    public partial class testsResult : Form
    {
        public testsResult()
        {
            InitializeComponent();
        }
        theVisitLog log = new theVisitLog();
        doctorsForm doc = new doctorsForm();
        DocOfficeDataSet docds = new DocOfficeDataSet();
        private void testsResult_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.The_visit_log". При необходимости она может быть перемещена или удалена.
            this.the_visit_logTableAdapter.Fill(this.docOfficeDataSet.The_visit_log);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.docOfficeDataSet.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Profession". При необходимости она может быть перемещена или удалена.
            this.professionTableAdapter.Fill(this.docOfficeDataSet.Profession);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Medical_tests". При необходимости она может быть перемещена или удалена.
            this.medical_testsTableAdapter.Fill(this.docOfficeDataSet.Medical_tests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Health_insurance_policy". При необходимости она может быть перемещена или удалена.
            this.health_insurance_policyTableAdapter.Fill(this.docOfficeDataSet.Health_insurance_policy);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Tests_result". При необходимости она может быть перемещена или удалена.
            this.tests_resultTableAdapter.Fill(this.docOfficeDataSet.Tests_result);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.docOfficeDataSet.Patient);
            this.comboBox2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox2_MouseWheel);
            this.comboBox3.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox3_MouseWheel);

        }
        // Блок скролла 
        private void comboBox3_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }
        // Блок скролла 
        private void comboBox2_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            log.Hide();
            this.Hide();
            doc.Show();
        }

        //Запись результатов анализов в БД
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox3.Text == "" )
            {
                MessageBox.Show("Не все обязательные поля были заполнены!");
            } else {
                int id = dataGridView1.Rows.Count;
                tests_resultTableAdapter.Insert(id, comboBox1.SelectedIndex + 1, textBox1.Text, textBox2.Text, dateTimePicker1.Value, comboBox3.SelectedIndex + 1, Convert.ToInt32(comboBox1.SelectedValue));
                tests_resultTableAdapter.Update(docds);
                this.tests_resultTableAdapter.Fill(this.docOfficeDataSet.Tests_result);

                MessageBox.Show("Результаты записаны!");
                log.Hide();
                this.Hide();
                doc.Show();
            }
        }

        private void журналПосещенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.AppendText(comboBox2.Text + " " + Environment.NewLine);
        }

        private void comboBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.AppendText(comboBox2.Text + " " + Environment.NewLine);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(ind);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tests_resultTableAdapter.Update
           (this.docOfficeDataSet.Tests_result);
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                textBox2.SelectedText = "";
            }
        }

        // sql-запрос профессия-анализы
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.getTestProseffionTableAdapter.Fill(this.docOfficeDataSet.GetTestProseffion, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBox3.SelectedValue, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void testsResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // sql-запрос пациент-полис

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.getPatientPolicyTableAdapter.Fill(this.docOfficeDataSet.getPatientPolicy, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBox1.SelectedValue, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

    
    }
}
