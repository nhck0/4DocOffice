namespace _4DocOffice
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idprofessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameproffesionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docOfficeDataSet = new _4DocOffice.DocOfficeDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iddoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprofessionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idmedicaltestsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprofessionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nametestsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medical_testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new _4DocOffice.DocOfficeDataSetTableAdapters.DoctorTableAdapter();
            this.tableAdapterManager = new _4DocOffice.DocOfficeDataSetTableAdapters.TableAdapterManager();
            this.medical_testsTableAdapter = new _4DocOffice.DocOfficeDataSetTableAdapters.Medical_testsTableAdapter();
            this.professionTableAdapter = new _4DocOffice.DocOfficeDataSetTableAdapters.ProfessionTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docOfficeDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_testsBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 26);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1102, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.файлToolStripMenuItem.Text = "Выйти";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1102, 26);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1102, 386);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1094, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Специальизации врачей клиники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprofessionDataGridViewTextBoxColumn,
            this.nameproffesionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.professionBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1088, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // idprofessionDataGridViewTextBoxColumn
            // 
            this.idprofessionDataGridViewTextBoxColumn.DataPropertyName = "id_profession";
            this.idprofessionDataGridViewTextBoxColumn.FillWeight = 7.106599F;
            this.idprofessionDataGridViewTextBoxColumn.HeaderText = "№";
            this.idprofessionDataGridViewTextBoxColumn.Name = "idprofessionDataGridViewTextBoxColumn";
            // 
            // nameproffesionDataGridViewTextBoxColumn
            // 
            this.nameproffesionDataGridViewTextBoxColumn.DataPropertyName = "Name_proffesion";
            this.nameproffesionDataGridViewTextBoxColumn.FillWeight = 192.8934F;
            this.nameproffesionDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.nameproffesionDataGridViewTextBoxColumn.Name = "nameproffesionDataGridViewTextBoxColumn";
            // 
            // professionBindingSource
            // 
            this.professionBindingSource.DataMember = "Profession";
            this.professionBindingSource.DataSource = this.docOfficeDataSet;
            // 
            // docOfficeDataSet
            // 
            this.docOfficeDataSet.DataSetName = "DocOfficeDataSet";
            this.docOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1094, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Информация о врачах";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddoctorDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephonenumberDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.idprofessionDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.doctorBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1088, 354);
            this.dataGridView2.TabIndex = 0;
            // 
            // iddoctorDataGridViewTextBoxColumn
            // 
            this.iddoctorDataGridViewTextBoxColumn.DataPropertyName = "id_doctor";
            this.iddoctorDataGridViewTextBoxColumn.FillWeight = 21.31979F;
            this.iddoctorDataGridViewTextBoxColumn.HeaderText = "№";
            this.iddoctorDataGridViewTextBoxColumn.Name = "iddoctorDataGridViewTextBoxColumn";
            this.iddoctorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Full_name";
            this.fullnameDataGridViewTextBoxColumn.FillWeight = 166.0249F;
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.FillWeight = 203.1227F;
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // telephonenumberDataGridViewTextBoxColumn
            // 
            this.telephonenumberDataGridViewTextBoxColumn.DataPropertyName = "Telephone_number";
            this.telephonenumberDataGridViewTextBoxColumn.FillWeight = 78.84162F;
            this.telephonenumberDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.telephonenumberDataGridViewTextBoxColumn.Name = "telephonenumberDataGridViewTextBoxColumn";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.FillWeight = 58.0005F;
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            // 
            // idprofessionDataGridViewTextBoxColumn1
            // 
            this.idprofessionDataGridViewTextBoxColumn1.DataPropertyName = "id_profession";
            this.idprofessionDataGridViewTextBoxColumn1.DataSource = this.professionBindingSource;
            this.idprofessionDataGridViewTextBoxColumn1.DisplayMember = "Name_proffesion";
            this.idprofessionDataGridViewTextBoxColumn1.FillWeight = 72.69019F;
            this.idprofessionDataGridViewTextBoxColumn1.HeaderText = "Специальность";
            this.idprofessionDataGridViewTextBoxColumn1.Name = "idprofessionDataGridViewTextBoxColumn1";
            this.idprofessionDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idprofessionDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idprofessionDataGridViewTextBoxColumn1.ValueMember = "id_profession";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.docOfficeDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1094, 360);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Медецинские анализы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmedicaltestsDataGridViewTextBoxColumn,
            this.idprofessionDataGridViewTextBoxColumn2,
            this.nametestsDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.medical_testsBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1088, 354);
            this.dataGridView3.TabIndex = 0;
            // 
            // idmedicaltestsDataGridViewTextBoxColumn
            // 
            this.idmedicaltestsDataGridViewTextBoxColumn.DataPropertyName = "id_medical_tests";
            this.idmedicaltestsDataGridViewTextBoxColumn.FillWeight = 10.6599F;
            this.idmedicaltestsDataGridViewTextBoxColumn.HeaderText = "№";
            this.idmedicaltestsDataGridViewTextBoxColumn.Name = "idmedicaltestsDataGridViewTextBoxColumn";
            // 
            // idprofessionDataGridViewTextBoxColumn2
            // 
            this.idprofessionDataGridViewTextBoxColumn2.DataPropertyName = "id_profession";
            this.idprofessionDataGridViewTextBoxColumn2.DataSource = this.professionBindingSource;
            this.idprofessionDataGridViewTextBoxColumn2.DisplayMember = "Name_proffesion";
            this.idprofessionDataGridViewTextBoxColumn2.FillWeight = 144.67F;
            this.idprofessionDataGridViewTextBoxColumn2.HeaderText = "Специальность";
            this.idprofessionDataGridViewTextBoxColumn2.Name = "idprofessionDataGridViewTextBoxColumn2";
            this.idprofessionDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idprofessionDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idprofessionDataGridViewTextBoxColumn2.ValueMember = "id_profession";
            // 
            // nametestsDataGridViewTextBoxColumn
            // 
            this.nametestsDataGridViewTextBoxColumn.DataPropertyName = "Name_tests";
            this.nametestsDataGridViewTextBoxColumn.FillWeight = 144.67F;
            this.nametestsDataGridViewTextBoxColumn.HeaderText = "Название анализа";
            this.nametestsDataGridViewTextBoxColumn.Name = "nametestsDataGridViewTextBoxColumn";
            // 
            // medical_testsBindingSource
            // 
            this.medical_testsBindingSource.DataMember = "Medical_tests";
            this.medical_testsBindingSource.DataSource = this.docOfficeDataSet;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = this.doctorTableAdapter;
            this.tableAdapterManager.Health_insurance_policyTableAdapter = null;
            this.tableAdapterManager.Medical_testsTableAdapter = this.medical_testsTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.ProfessionTableAdapter = this.professionTableAdapter;
            this.tableAdapterManager.Tests_resultTableAdapter = null;
            this.tableAdapterManager.The_visit_logTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _4DocOffice.DocOfficeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medical_testsTableAdapter
            // 
            this.medical_testsTableAdapter.ClearBeforeFill = true;
            // 
            // professionTableAdapter
            // 
            this.professionTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1102, 29);
            this.panel3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adminForm_FormClosed);
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docOfficeDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_testsBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DocOfficeDataSet docOfficeDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private DocOfficeDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private DocOfficeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DocOfficeDataSetTableAdapters.Medical_testsTableAdapter medical_testsTableAdapter;
        private System.Windows.Forms.BindingSource medical_testsBindingSource;
        private DocOfficeDataSetTableAdapters.ProfessionTableAdapter professionTableAdapter;
        private System.Windows.Forms.BindingSource professionBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprofessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameproffesionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idprofessionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmedicaltestsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idprofessionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametestsDataGridViewTextBoxColumn;
    }
}