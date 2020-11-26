namespace ExpensesTracker.Project.Expenses
{
    partial class Expenses
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
            this.lblTotal_Exp = new System.Windows.Forms.Label();
            this.lblValue_Exp = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotal_Amt = new System.Windows.Forms.Label();
            this.lblValue_Amt = new System.Windows.Forms.Label();
            this.lblTotal_Remaining = new System.Windows.Forms.Label();
            this.lblValue_Remaining = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dateTimePickerExpense = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblitem = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblAmt = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddCtgry = new System.Windows.Forms.Button();
            this.btnRmvCtgry = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.rdoOtging = new System.Windows.Forms.RadioButton();
            this.lblExpnseType = new System.Windows.Forms.Label();
            this.rdiIncmg = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExpensesUser = new System.Windows.Forms.Label();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lnkExpensesBack = new System.Windows.Forms.LinkLabel();
            this.expenses_TrackerDataset = new ExpensesTracker.DataSet.Expenses_TrackerDataset();
            this.eXPENSESTRACKERPROCEDUREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPENSES_TRACKER_PROCEDURETableAdapter = new ExpensesTracker.DataSet.Expenses_TrackerDatasetTableAdapters.EXPENSES_TRACKER_PROCEDURETableAdapter();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPENSESCATEGORYNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPENSESTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPENSESTRACKERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenses_TrackerDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSESTRACKERPROCEDUREBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal_Exp
            // 
            this.lblTotal_Exp.AutoSize = true;
            this.lblTotal_Exp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal_Exp.Location = new System.Drawing.Point(941, 101);
            this.lblTotal_Exp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal_Exp.Name = "lblTotal_Exp";
            this.lblTotal_Exp.Size = new System.Drawing.Size(109, 27);
            this.lblTotal_Exp.TabIndex = 2;
            this.lblTotal_Exp.Text = "Outgoing :";
            // 
            // lblValue_Exp
            // 
            this.lblValue_Exp.AutoSize = true;
            this.lblValue_Exp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblValue_Exp.Location = new System.Drawing.Point(1072, 101);
            this.lblValue_Exp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue_Exp.Name = "lblValue_Exp";
            this.lblValue_Exp.Size = new System.Drawing.Size(64, 27);
            this.lblValue_Exp.TabIndex = 3;
            this.lblValue_Exp.Text = "Value";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(710, 99);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 40);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.eXPENSESCATEGORYNAMEDataGridViewTextBoxColumn,
            this.eXPENSESTYPEDataGridViewTextBoxColumn,
            this.eXPENSESTRACKERIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eXPENSESTRACKERPROCEDUREBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 208);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(962, 428);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // lblTotal_Amt
            // 
            this.lblTotal_Amt.AutoSize = true;
            this.lblTotal_Amt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal_Amt.Location = new System.Drawing.Point(941, 56);
            this.lblTotal_Amt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal_Amt.Name = "lblTotal_Amt";
            this.lblTotal_Amt.Size = new System.Drawing.Size(109, 27);
            this.lblTotal_Amt.TabIndex = 9;
            this.lblTotal_Amt.Text = "Incoming :";
            // 
            // lblValue_Amt
            // 
            this.lblValue_Amt.AutoSize = true;
            this.lblValue_Amt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblValue_Amt.Location = new System.Drawing.Point(1072, 59);
            this.lblValue_Amt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue_Amt.Name = "lblValue_Amt";
            this.lblValue_Amt.Size = new System.Drawing.Size(88, 27);
            this.lblValue_Amt.TabIndex = 10;
            this.lblValue_Amt.Text = "Amount";
            // 
            // lblTotal_Remaining
            // 
            this.lblTotal_Remaining.AutoSize = true;
            this.lblTotal_Remaining.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal_Remaining.Location = new System.Drawing.Point(887, 145);
            this.lblTotal_Remaining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal_Remaining.Name = "lblTotal_Remaining";
            this.lblTotal_Remaining.Size = new System.Drawing.Size(179, 27);
            this.lblTotal_Remaining.TabIndex = 11;
            this.lblTotal_Remaining.Text = "Total Remaining : ";
            // 
            // lblValue_Remaining
            // 
            this.lblValue_Remaining.AutoSize = true;
            this.lblValue_Remaining.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblValue_Remaining.Location = new System.Drawing.Point(1072, 146);
            this.lblValue_Remaining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue_Remaining.Name = "lblValue_Remaining";
            this.lblValue_Remaining.Size = new System.Drawing.Size(111, 27);
            this.lblValue_Remaining.TabIndex = 12;
            this.lblValue_Remaining.Text = "Remaining";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(488, 98);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(121, 24);
            this.cmbcategory.TabIndex = 18;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(378, 94);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(104, 27);
            this.lblCategory.TabIndex = 17;
            this.lblCategory.Text = "Category: ";
            // 
            // dateTimePickerExpense
            // 
            this.dateTimePickerExpense.Location = new System.Drawing.Point(488, 52);
            this.dateTimePickerExpense.Name = "dateTimePickerExpense";
            this.dateTimePickerExpense.Size = new System.Drawing.Size(187, 22);
            this.dateTimePickerExpense.TabIndex = 16;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(353, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(129, 27);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Spend Date: ";
            // 
            // lblitem
            // 
            this.lblitem.AutoSize = true;
            this.lblitem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblitem.Location = new System.Drawing.Point(37, 45);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(145, 27);
            this.lblitem.TabIndex = 14;
            this.lblitem.Text = "Expense Item: ";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(188, 50);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(138, 22);
            this.txtItem.TabIndex = 19;
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblAmt.Location = new System.Drawing.Point(5, 94);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(177, 27);
            this.lblAmt.TabIndex = 20;
            this.lblAmt.Text = "Expense Amount: ";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(188, 99);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(138, 22);
            this.txtAmount.TabIndex = 21;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(710, 42);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 40);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddCtgry
            // 
            this.btnAddCtgry.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddCtgry.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCtgry.Location = new System.Drawing.Point(1049, 224);
            this.btnAddCtgry.Name = "btnAddCtgry";
            this.btnAddCtgry.Size = new System.Drawing.Size(169, 44);
            this.btnAddCtgry.TabIndex = 23;
            this.btnAddCtgry.Text = "Add Category";
            this.btnAddCtgry.UseVisualStyleBackColor = false;
            this.btnAddCtgry.Click += new System.EventHandler(this.btnAddCtgry_Click);
            // 
            // btnRmvCtgry
            // 
            this.btnRmvCtgry.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRmvCtgry.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnRmvCtgry.Location = new System.Drawing.Point(1047, 286);
            this.btnRmvCtgry.Name = "btnRmvCtgry";
            this.btnRmvCtgry.Size = new System.Drawing.Size(185, 44);
            this.btnRmvCtgry.TabIndex = 24;
            this.btnRmvCtgry.Text = "Remove Category";
            this.btnRmvCtgry.UseVisualStyleBackColor = false;
            this.btnRmvCtgry.Click += new System.EventHandler(this.btnRmvCtgry_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRefresh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(1049, 346);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(169, 44);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAnalysis.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnalysis.Location = new System.Drawing.Point(1049, 403);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(169, 44);
            this.btnAnalysis.TabIndex = 26;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = false;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // rdoOtging
            // 
            this.rdoOtging.AutoSize = true;
            this.rdoOtging.Checked = true;
            this.rdoOtging.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.rdoOtging.Location = new System.Drawing.Point(327, 12);
            this.rdoOtging.Name = "rdoOtging";
            this.rdoOtging.Size = new System.Drawing.Size(120, 31);
            this.rdoOtging.TabIndex = 30;
            this.rdoOtging.TabStop = true;
            this.rdoOtging.Text = "Outgoing";
            this.rdoOtging.UseVisualStyleBackColor = true;
            // 
            // lblExpnseType
            // 
            this.lblExpnseType.AutoSize = true;
            this.lblExpnseType.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblExpnseType.Location = new System.Drawing.Point(17, 11);
            this.lblExpnseType.Name = "lblExpnseType";
            this.lblExpnseType.Size = new System.Drawing.Size(158, 27);
            this.lblExpnseType.TabIndex = 31;
            this.lblExpnseType.Text = "Expenses Type: ";
            // 
            // rdiIncmg
            // 
            this.rdiIncmg.AutoSize = true;
            this.rdiIncmg.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.rdiIncmg.Location = new System.Drawing.Point(190, 12);
            this.rdiIncmg.Name = "rdiIncmg";
            this.rdiIncmg.Size = new System.Drawing.Size(120, 31);
            this.rdiIncmg.TabIndex = 29;
            this.rdiIncmg.Text = "Incoming";
            this.rdiIncmg.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblExpnseType);
            this.panel1.Controls.Add(this.rdoOtging);
            this.panel1.Controls.Add(this.rdiIncmg);
            this.panel1.Location = new System.Drawing.Point(208, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 52);
            this.panel1.TabIndex = 32;
            // 
            // lblExpensesUser
            // 
            this.lblExpensesUser.AutoSize = true;
            this.lblExpensesUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblExpensesUser.Location = new System.Drawing.Point(1107, 10);
            this.lblExpensesUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpensesUser.Name = "lblExpensesUser";
            this.lblExpensesUser.Size = new System.Drawing.Size(38, 17);
            this.lblExpensesUser.TabIndex = 33;
            this.lblExpensesUser.Text = "User";
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lnkLogout.LinkColor = System.Drawing.Color.Blue;
            this.lnkLogout.Location = new System.Drawing.Point(1202, 9);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(52, 17);
            this.lnkLogout.TabIndex = 67;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            // 
            // lnkExpensesBack
            // 
            this.lnkExpensesBack.AutoSize = true;
            this.lnkExpensesBack.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lnkExpensesBack.LinkColor = System.Drawing.Color.Blue;
            this.lnkExpensesBack.Location = new System.Drawing.Point(12, 9);
            this.lnkExpensesBack.Name = "lnkExpensesBack";
            this.lnkExpensesBack.Size = new System.Drawing.Size(39, 17);
            this.lnkExpensesBack.TabIndex = 68;
            this.lnkExpensesBack.TabStop = true;
            this.lnkExpensesBack.Text = "Back";
            this.lnkExpensesBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExpensesBack_LinkClicked);
            // 
            // expenses_TrackerDataset
            // 
            this.expenses_TrackerDataset.DataSetName = "Expenses_TrackerDataset";
            this.expenses_TrackerDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXPENSESTRACKERPROCEDUREBindingSource
            // 
            this.eXPENSESTRACKERPROCEDUREBindingSource.DataMember = "EXPENSES_TRACKER_PROCEDURE";
            this.eXPENSESTRACKERPROCEDUREBindingSource.DataSource = this.expenses_TrackerDataset;
            // 
            // eXPENSES_TRACKER_PROCEDURETableAdapter
            // 
            this.eXPENSES_TRACKER_PROCEDURETableAdapter.ClearBeforeFill = true;
            // 
            // SNo
            // 
            this.SNo.HeaderText = "Serial No";
            this.SNo.MinimumWidth = 6;
            this.SNo.Name = "SNo";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EXPENSES_ITEM";
            this.dataGridViewTextBoxColumn1.HeaderText = "Expenses Item";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EXPENSES_AMT";
            this.dataGridViewTextBoxColumn3.HeaderText = "Expenses Amt";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EXPENSES_DATE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Expenses Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // eXPENSESCATEGORYNAMEDataGridViewTextBoxColumn
            // 
            this.eXPENSESCATEGORYNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXPENSES_CATEGORY_NAME";
            this.eXPENSESCATEGORYNAMEDataGridViewTextBoxColumn.HeaderText = "Expenses Category";
            this.eXPENSESCATEGORYNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXPENSESCATEGORYNAMEDataGridViewTextBoxColumn.Name = "eXPENSESCATEGORYNAMEDataGridViewTextBoxColumn";
            // 
            // eXPENSESTYPEDataGridViewTextBoxColumn
            // 
            this.eXPENSESTYPEDataGridViewTextBoxColumn.DataPropertyName = "EXPENSES_TYPE";
            this.eXPENSESTYPEDataGridViewTextBoxColumn.HeaderText = "EXPENSES_TYPE";
            this.eXPENSESTYPEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXPENSESTYPEDataGridViewTextBoxColumn.Name = "eXPENSESTYPEDataGridViewTextBoxColumn";
            this.eXPENSESTYPEDataGridViewTextBoxColumn.Visible = false;
            // 
            // eXPENSESTRACKERIDDataGridViewTextBoxColumn
            // 
            this.eXPENSESTRACKERIDDataGridViewTextBoxColumn.DataPropertyName = "EXPENSES_TRACKER_ID";
            this.eXPENSESTRACKERIDDataGridViewTextBoxColumn.HeaderText = "EXPENSES_TRACKER_ID";
            this.eXPENSESTRACKERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXPENSESTRACKERIDDataGridViewTextBoxColumn.Name = "eXPENSESTRACKERIDDataGridViewTextBoxColumn";
            this.eXPENSESTRACKERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eXPENSESTRACKERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1266, 656);
            this.Controls.Add(this.lnkExpensesBack);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lblExpensesUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRmvCtgry);
            this.Controls.Add(this.btnAddCtgry);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmt);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.cmbcategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dateTimePickerExpense);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblitem);
            this.Controls.Add(this.lblValue_Remaining);
            this.Controls.Add(this.lblTotal_Remaining);
            this.Controls.Add(this.lblValue_Amt);
            this.Controls.Add(this.lblTotal_Amt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblValue_Exp);
            this.Controls.Add(this.lblTotal_Exp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Expenses";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenses_TrackerDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPENSESTRACKERPROCEDUREBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal_Exp;
        private System.Windows.Forms.Label lblValue_Exp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotal_Amt;
        private System.Windows.Forms.Label lblValue_Amt;
        private System.Windows.Forms.Label lblTotal_Remaining;
        private System.Windows.Forms.Label lblValue_Remaining;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpense;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblitem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddCtgry;
        private System.Windows.Forms.Button btnRmvCtgry;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExpnseType;
        private System.Windows.Forms.RadioButton rdoOtging;
        private System.Windows.Forms.RadioButton rdiIncmg;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENSESITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENSESAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENSESDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPENSES_CATEGORY_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPENSES_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPENSES_TRACKER_ID;
        private System.Windows.Forms.Label lblExpensesUser;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.LinkLabel lnkExpensesBack;
        private System.Windows.Forms.BindingSource eXPENSESTRACKERPROCEDUREBindingSource;
        private DataSet.Expenses_TrackerDataset expenses_TrackerDataset;
        private DataSet.Expenses_TrackerDatasetTableAdapters.EXPENSES_TRACKER_PROCEDURETableAdapter eXPENSES_TRACKER_PROCEDURETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENSESCATEGORYNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENSESTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPENSESTRACKERIDDataGridViewTextBoxColumn;
    }
}