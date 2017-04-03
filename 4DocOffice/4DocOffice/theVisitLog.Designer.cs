namespace _4DocOffice
{
    partial class theVisitLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(theVisitLog));
            this.button1 = new System.Windows.Forms.Button();
            this.docOfficeDataSet = new _4DocOffice.DocOfficeDataSet();
            this.the_visit_logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.the_visit_logTableAdapter = new _4DocOffice.DocOfficeDataSetTableAdapters.The_visit_logTableAdapter();
            this.tableAdapterManager = new _4DocOffice.DocOfficeDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idlogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idpatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametestsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorTableAdapter = new _4DocOffice.DocOfficeDataSetTableAdapters.DoctorTableAdapter();
            this.patientTableAdapter = new _4DocOffice.DocOfficeDataSetTableAdapters.PatientTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.docOfficeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_visit_logBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1210, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // docOfficeDataSet
            // 
            this.docOfficeDataSet.DataSetName = "DocOfficeDataSet";
            this.docOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // the_visit_logBindingSource
            // 
            this.the_visit_logBindingSource.DataMember = "The_visit_log";
            this.the_visit_logBindingSource.DataSource = this.docOfficeDataSet;
            // 
            // the_visit_logTableAdapter
            // 
            this.the_visit_logTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.Health_insurance_policyTableAdapter = null;
            this.tableAdapterManager.Medical_testsTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.ProfessionTableAdapter = null;
            this.tableAdapterManager.Tests_resultTableAdapter = null;
            this.tableAdapterManager.The_visit_logTableAdapter = this.the_visit_logTableAdapter;
            this.tableAdapterManager.UpdateOrder = _4DocOffice.DocOfficeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlogDataGridViewTextBoxColumn,
            this.iddoctorDataGridViewTextBoxColumn,
            this.idpatientDataGridViewTextBoxColumn,
            this.visitdateDataGridViewTextBoxColumn,
            this.complainsDataGridViewTextBoxColumn,
            this.nametestsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.the_visit_logBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1210, 272);
            this.dataGridView1.TabIndex = 1;
            // 
            // idlogDataGridViewTextBoxColumn
            // 
            this.idlogDataGridViewTextBoxColumn.DataPropertyName = "id_log";
            this.idlogDataGridViewTextBoxColumn.FillWeight = 15.22843F;
            this.idlogDataGridViewTextBoxColumn.HeaderText = "№";
            this.idlogDataGridViewTextBoxColumn.Name = "idlogDataGridViewTextBoxColumn";
            this.idlogDataGridViewTextBoxColumn.ReadOnly = true;
            this.idlogDataGridViewTextBoxColumn.Visible = false;
            // 
            // iddoctorDataGridViewTextBoxColumn
            // 
            this.iddoctorDataGridViewTextBoxColumn.DataPropertyName = "id_doctor";
            this.iddoctorDataGridViewTextBoxColumn.DataSource = this.doctorBindingSource;
            this.iddoctorDataGridViewTextBoxColumn.DisplayMember = "Full_name";
            this.iddoctorDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iddoctorDataGridViewTextBoxColumn.FillWeight = 85.20654F;
            this.iddoctorDataGridViewTextBoxColumn.HeaderText = "Врач";
            this.iddoctorDataGridViewTextBoxColumn.Name = "iddoctorDataGridViewTextBoxColumn";
            this.iddoctorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddoctorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iddoctorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iddoctorDataGridViewTextBoxColumn.ValueMember = "id_doctor";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.docOfficeDataSet;
            // 
            // idpatientDataGridViewTextBoxColumn
            // 
            this.idpatientDataGridViewTextBoxColumn.DataPropertyName = "id_patient";
            this.idpatientDataGridViewTextBoxColumn.DataSource = this.patientBindingSource;
            this.idpatientDataGridViewTextBoxColumn.DisplayMember = "Full_name";
            this.idpatientDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idpatientDataGridViewTextBoxColumn.FillWeight = 87.1218F;
            this.idpatientDataGridViewTextBoxColumn.HeaderText = "Пациент";
            this.idpatientDataGridViewTextBoxColumn.Name = "idpatientDataGridViewTextBoxColumn";
            this.idpatientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpatientDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idpatientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idpatientDataGridViewTextBoxColumn.ValueMember = "id_patient";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.docOfficeDataSet;
            // 
            // visitdateDataGridViewTextBoxColumn
            // 
            this.visitdateDataGridViewTextBoxColumn.DataPropertyName = "Visit_date";
            this.visitdateDataGridViewTextBoxColumn.FillWeight = 57.30987F;
            this.visitdateDataGridViewTextBoxColumn.HeaderText = "Дата приема";
            this.visitdateDataGridViewTextBoxColumn.Name = "visitdateDataGridViewTextBoxColumn";
            this.visitdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complainsDataGridViewTextBoxColumn
            // 
            this.complainsDataGridViewTextBoxColumn.DataPropertyName = "Complains";
            this.complainsDataGridViewTextBoxColumn.FillWeight = 139.368F;
            this.complainsDataGridViewTextBoxColumn.HeaderText = "Жалобы";
            this.complainsDataGridViewTextBoxColumn.Name = "complainsDataGridViewTextBoxColumn";
            this.complainsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nametestsDataGridViewTextBoxColumn
            // 
            this.nametestsDataGridViewTextBoxColumn.DataPropertyName = "Name_tests";
            this.nametestsDataGridViewTextBoxColumn.FillWeight = 215.7656F;
            this.nametestsDataGridViewTextBoxColumn.HeaderText = "Назначенные анализы";
            this.nametestsDataGridViewTextBoxColumn.Name = "nametestsDataGridViewTextBoxColumn";
            this.nametestsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 29);
            this.panel1.TabIndex = 2;
            // 
            // theVisitLog
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1210, 272);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "theVisitLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Журнал посещений";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.theVisitLog_FormClosed);
            this.Load += new System.EventHandler(this.theVisitLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.docOfficeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_visit_logBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DocOfficeDataSet docOfficeDataSet;
        private System.Windows.Forms.BindingSource the_visit_logBindingSource;
        private DocOfficeDataSetTableAdapters.The_visit_logTableAdapter the_visit_logTableAdapter;
        private DocOfficeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private DocOfficeDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DocOfficeDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iddoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idpatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametestsDataGridViewTextBoxColumn;
    }
}