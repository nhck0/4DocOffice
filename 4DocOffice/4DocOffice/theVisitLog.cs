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
    public partial class theVisitLog : Form
    {
        public theVisitLog()
        {
            InitializeComponent();
        }
        private void theVisitLog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.docOfficeDataSet.Patient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.docOfficeDataSet.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "docOfficeDataSet.The_visit_log". При необходимости она может быть перемещена или удалена.
            this.the_visit_logTableAdapter.Fill(this.docOfficeDataSet.The_visit_log);
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void theVisitLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
