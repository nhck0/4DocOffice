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
    public partial class doctorsForm : Form
    {
        public doctorsForm()
        {
            InitializeComponent();

        }
        DocOfficeDataSet docds = new DocOfficeDataSet();

        private void doctorsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.The_visit_log". При необходимости она может быть перемещена или удалена.
            this.the_visit_logTableAdapter.Fill(this.docOfficeDataSet.The_visit_log);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Tests_result". При необходимости она может быть перемещена или удалена.
            this.tests_resultTableAdapter.Fill(this.docOfficeDataSet.Tests_result);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Profession". При необходимости она может быть перемещена или удалена.
            this.professionTableAdapter.Fill(this.docOfficeDataSet.Profession);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.docOfficeDataSet.Patient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Medical_tests". При необходимости она может быть перемещена или удалена.
            this.medical_testsTableAdapter.Fill(this.docOfficeDataSet.Medical_tests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Health_insurance_policy". При необходимости она может быть перемещена или удалена.
            this.health_insurance_policyTableAdapter.Fill(this.docOfficeDataSet.Health_insurance_policy);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.docOfficeDataSet.Doctor);
            textBox2.Text = Convert.ToString(0);
            comboBox1.Text = "Мужской";
            this.comboBox3.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox3_MouseWheel);
            this.comboBox2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox2_MouseWheel);
        }
      
        // Блокировка скролла
        private void comboBox3_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }
        //Блокировка скролла
        private void comboBox2_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutTheProgram about = new aboutTheProgram();
            about.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authorization login = new authorization();
            this.Hide();
            login.Show();
        }

        private void посмотретьИсториюПосещенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theVisitLog log = new theVisitLog();
            log.Show();
        }

        private void результатыАнализовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testsResult result = new testsResult();
            this.Hide();
            result.Show();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dateTimePicker1.Value.Year;
            textBox2.Text = Convert.ToString(age);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.AppendText(comboBox3.Text  + Environment.NewLine);
        }

        // Заполнение таблиц(Заполнение журнала)
        private void button1_Click(object sender, EventArgs e)
        {
            int id1 = dataGridView3.Rows.Count;
            int id2 = dataGridView1.Rows.Count;
            if (textBox1.Text.Length == 0 || textBox3.Text.Length == 0 ||  textBox5.Text.Length == 0 || textBox4.Text.Length == 0)
            {
                MessageBox.Show("Не все обязательные поля были заполнены!");

            } else {
                    //try {
                        health_insurance_policyTableAdapter.Insert(id1, Convert.ToString(textBox4.Text));
                        health_insurance_policyTableAdapter.Update(docds);
                        this.health_insurance_policyTableAdapter.Fill(this.docOfficeDataSet.Health_insurance_policy); // Заполнение таблицы Медецинский полис

                        patientTableAdapter.Insert(id1, textBox1.Text, comboBox1.Text, dateTimePicker1.Value, textBox2.Text, textBox3.Text, id1);
                        patientTableAdapter.Update(docds);
                        this.patientTableAdapter.Fill(this.docOfficeDataSet.Patient);// Заполнение таблицы пациенты

                        the_visit_logTableAdapter.Insert(id2, comboBox2.SelectedIndex + 1, id2, DateTime.Now, textBox5.Text, textBox6.Text);
                        the_visit_logTableAdapter.Update(docds);
                        this.the_visit_logTableAdapter.Fill(this.docOfficeDataSet.The_visit_log); // Заполнение таблицы Журнал посещений

                        MessageBox.Show("Запись добавлена в журнал!");
                        textBox1.Clear();
                        textBox2.Text = Convert.ToString(0);
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                //}
                //    catch (ConstraintException)
                //{
                //        health_insurance_policyTableAdapter.Delete(id1, Convert.ToString(textBox4.Text));
                //        health_insurance_policyTableAdapter.Update(docds);
                //        this.health_insurance_policyTableAdapter.Fill(this.docOfficeDataSet.Health_insurance_policy);

                //        patientTableAdapter.Delete(id1, textBox1.Text, comboBox1.Text, dateTimePicker1.Value, textBox2.Text, textBox3.Text, id1);
                //        patientTableAdapter.Update(docds);
                //        this.patientTableAdapter.Fill(this.docOfficeDataSet.Patient);

                //        the_visit_logTableAdapter.Delete(id2, comboBox2.SelectedIndex + 1, id2, DateTime.Now, textBox5.Text, textBox6.Text);
                //        the_visit_logTableAdapter.Update(docds);
                //        this.the_visit_logTableAdapter.Fill(this.docOfficeDataSet.The_visit_log);

                //        MessageBox.Show("Запись не добавлена в журнал!");
                //}      
            }
        }

        //Удаление данных из таблицы Медецинский полис
        private void button3_Click(object sender, EventArgs e)
        {
            int ind = dataGridView3.SelectedCells[0].RowIndex;
            dataGridView3.Rows.RemoveAt(ind);
        }

        //Обновление данных в таблице Медецинский полис
        private void button4_Click(object sender, EventArgs e)
        {
            this.health_insurance_policyTableAdapter.Update
           (this.docOfficeDataSet.Health_insurance_policy);
        }

        //Удаление данных из таблицы Пациенты
        private void button5_Click(object sender, EventArgs e)
        {
            int ind = dataGridView2.SelectedCells[0].RowIndex;
            dataGridView2.Rows.RemoveAt(ind);
        }

        //Удаление данных из таблицы Журнал посещений
        private void button7_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(ind);
        }

        //Обновление данных в таблице Пациенты
        private void button6_Click(object sender, EventArgs e)
        {
            this.patientTableAdapter.Update
           (this.docOfficeDataSet.Patient);
        }

        //Обновление данных в таблице Журнал посещений
        private void button8_Click(object sender, EventArgs e)
        {
            this.the_visit_logTableAdapter.Update
           (this.docOfficeDataSet.The_visit_log);
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                textBox6.SelectedText = "";
            }
        }
        // Блок ввода символов
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

            // SQL-запрос профессия-анализы
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.getTestProseffionTableAdapter.Fill(this.docOfficeDataSet.GetTestProseffion, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBox2.SelectedValue, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void doctorsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // LostFocus
        private void textBox4_Leave(object sender, EventArgs e)
        {
            
            if (textBox4.Text.Length != 5)
            {
                MessageBox.Show("Некорректный номер полиса");
                textBox4.Focus();
            }
        }
    }
}
