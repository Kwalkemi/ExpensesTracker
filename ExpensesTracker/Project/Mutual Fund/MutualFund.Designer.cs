
namespace ExpensesTracker.Project.Mutual_Fund
{
    partial class MutualFund
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
            this.tabControlMutualFund = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtboxExitLoad = new System.Windows.Forms.TextBox();
            this.lblExitLoad = new System.Windows.Forms.Label();
            this.lblMutualFundStartDate = new System.Windows.Forms.Label();
            this.dateStartDateMutual = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewMutualFund = new System.Windows.Forms.DataGridView();
            this.panelSell = new System.Windows.Forms.Panel();
            this.txtSellCharges = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSellId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSellQty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateSell = new System.Windows.Forms.DateTimePicker();
            this.btnShareSell = new System.Windows.Forms.Button();
            this.panelbuy = new System.Windows.Forms.Panel();
            this.lblMutualFundBuyCharges = new System.Windows.Forms.Label();
            this.txtBuyCharges = new System.Windows.Forms.TextBox();
            this.lblBuyId = new System.Windows.Forms.Label();
            this.lblMutualFundIdBuy = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.lblMutualFundBuyPrice = new System.Windows.Forms.Label();
            this.lblMutualFundQnty = new System.Windows.Forms.Label();
            this.txtBuyQty = new System.Windows.Forms.TextBox();
            this.lblDateMFBuy = new System.Windows.Forms.Label();
            this.dateBuyMF = new System.Windows.Forms.DateTimePicker();
            this.btnMutualFundAdd = new System.Windows.Forms.Button();
            this.btnUpdateDelivery = new System.Windows.Forms.Button();
            this.btnAddMutualFundHeader = new System.Windows.Forms.Button();
            this.txtMutualFundName = new System.Windows.Forms.TextBox();
            this.lblMutualFundName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbDematAccountMutual = new System.Windows.Forms.ComboBox();
            this.lblDematAccountMutual = new System.Windows.Forms.Label();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.errorProvidermutual = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxIsSip = new System.Windows.Forms.CheckBox();
            this.mUTUALFUNDHEADERPROCEDUREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mutual_FundDataSet = new ExpensesTracker.DataSet.Mutual_FundDataSet();
            this.mUTUAL_FUND_HEADER_PROCEDURETableAdapter = new ExpensesTracker.DataSet.Mutual_FundDataSetTableAdapters.MUTUAL_FUND_HEADER_PROCEDURETableAdapter();
            this.lnkRefresh = new System.Windows.Forms.LinkLabel();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.mUTUALFUNDHEADERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUTUALFUNDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHAREAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFITLOSSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXIT_LOAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_SIP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MUTUAL_FUND_CREATED_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControlMutualFund.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMutualFund)).BeginInit();
            this.panelSell.SuspendLayout();
            this.panelbuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidermutual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUTUALFUNDHEADERPROCEDUREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutual_FundDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMutualFund
            // 
            this.tabControlMutualFund.Controls.Add(this.tabPage1);
            this.tabControlMutualFund.Controls.Add(this.tabPage2);
            this.tabControlMutualFund.Location = new System.Drawing.Point(12, 49);
            this.tabControlMutualFund.Name = "tabControlMutualFund";
            this.tabControlMutualFund.SelectedIndex = 0;
            this.tabControlMutualFund.Size = new System.Drawing.Size(1241, 690);
            this.tabControlMutualFund.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMutualFund.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Azure;
            this.tabPage1.Controls.Add(this.checkBoxIsSip);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtboxExitLoad);
            this.tabPage1.Controls.Add(this.lblExitLoad);
            this.tabPage1.Controls.Add(this.lblMutualFundStartDate);
            this.tabPage1.Controls.Add(this.dateStartDateMutual);
            this.tabPage1.Controls.Add(this.dataGridViewMutualFund);
            this.tabPage1.Controls.Add(this.panelSell);
            this.tabPage1.Controls.Add(this.panelbuy);
            this.tabPage1.Controls.Add(this.btnUpdateDelivery);
            this.tabPage1.Controls.Add(this.btnAddMutualFundHeader);
            this.tabPage1.Controls.Add(this.txtMutualFundName);
            this.tabPage1.Controls.Add(this.lblMutualFundName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1233, 661);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mutual Fund";
            // 
            // txtboxExitLoad
            // 
            this.txtboxExitLoad.Location = new System.Drawing.Point(248, 104);
            this.txtboxExitLoad.Name = "txtboxExitLoad";
            this.txtboxExitLoad.Size = new System.Drawing.Size(175, 22);
            this.txtboxExitLoad.TabIndex = 79;
            // 
            // lblExitLoad
            // 
            this.lblExitLoad.AutoSize = true;
            this.lblExitLoad.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitLoad.Location = new System.Drawing.Point(94, 102);
            this.lblExitLoad.Name = "lblExitLoad";
            this.lblExitLoad.Size = new System.Drawing.Size(121, 23);
            this.lblExitLoad.TabIndex = 78;
            this.lblExitLoad.Text = "Exit Load (%): ";
            // 
            // lblMutualFundStartDate
            // 
            this.lblMutualFundStartDate.AutoSize = true;
            this.lblMutualFundStartDate.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.lblMutualFundStartDate.Location = new System.Drawing.Point(118, 65);
            this.lblMutualFundStartDate.Name = "lblMutualFundStartDate";
            this.lblMutualFundStartDate.Size = new System.Drawing.Size(97, 23);
            this.lblMutualFundStartDate.TabIndex = 76;
            this.lblMutualFundStartDate.Text = "Start Date: ";
            // 
            // dateStartDateMutual
            // 
            this.dateStartDateMutual.Location = new System.Drawing.Point(248, 65);
            this.dateStartDateMutual.Name = "dateStartDateMutual";
            this.dateStartDateMutual.Size = new System.Drawing.Size(160, 22);
            this.dateStartDateMutual.TabIndex = 77;
            // 
            // dataGridViewMutualFund
            // 
            this.dataGridViewMutualFund.AutoGenerateColumns = false;
            this.dataGridViewMutualFund.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMutualFund.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMutualFund.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mUTUALFUNDHEADERIDDataGridViewTextBoxColumn,
            this.mUTUALFUNDNAMEDataGridViewTextBoxColumn,
            this.sHAREAMTDataGridViewTextBoxColumn,
            this.pROFITLOSSDataGridViewTextBoxColumn,
            this.EXIT_LOAD,
            this.IS_SIP,
            this.MUTUAL_FUND_CREATED_DATE,
            this.ViewDetail});
            this.dataGridViewMutualFund.DataSource = this.mUTUALFUNDHEADERPROCEDUREBindingSource;
            this.dataGridViewMutualFund.Location = new System.Drawing.Point(592, 19);
            this.dataGridViewMutualFund.Name = "dataGridViewMutualFund";
            this.dataGridViewMutualFund.RowHeadersWidth = 51;
            this.dataGridViewMutualFund.RowTemplate.Height = 24;
            this.dataGridViewMutualFund.Size = new System.Drawing.Size(635, 632);
            this.dataGridViewMutualFund.TabIndex = 75;
            this.dataGridViewMutualFund.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMutualFund_CellClick);
            // 
            // panelSell
            // 
            this.panelSell.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panelSell.Controls.Add(this.txtSellCharges);
            this.panelSell.Controls.Add(this.label5);
            this.panelSell.Controls.Add(this.lblSellId);
            this.panelSell.Controls.Add(this.label2);
            this.panelSell.Controls.Add(this.txtSellPrice);
            this.panelSell.Controls.Add(this.label7);
            this.panelSell.Controls.Add(this.label8);
            this.panelSell.Controls.Add(this.txtSellQty);
            this.panelSell.Controls.Add(this.label13);
            this.panelSell.Controls.Add(this.dateSell);
            this.panelSell.Controls.Add(this.btnShareSell);
            this.panelSell.Location = new System.Drawing.Point(18, 471);
            this.panelSell.Name = "panelSell";
            this.panelSell.Size = new System.Drawing.Size(537, 180);
            this.panelSell.TabIndex = 74;
            // 
            // txtSellCharges
            // 
            this.txtSellCharges.Location = new System.Drawing.Point(221, 107);
            this.txtSellCharges.Name = "txtSellCharges";
            this.txtSellCharges.Size = new System.Drawing.Size(138, 22);
            this.txtSellCharges.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(33, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Share Buy Charges:";
            // 
            // lblSellId
            // 
            this.lblSellId.AutoSize = true;
            this.lblSellId.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblSellId.Location = new System.Drawing.Point(216, 13);
            this.lblSellId.Name = "lblSellId";
            this.lblSellId.Size = new System.Drawing.Size(116, 27);
            this.lblSellId.TabIndex = 23;
            this.lblSellId.Text = "SellIdLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(113, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Share Id: ";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(221, 45);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(138, 22);
            this.txtSellPrice.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Share Sell Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(23, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Share Sell Quantity: ";
            // 
            // txtSellQty
            // 
            this.txtSellQty.Location = new System.Drawing.Point(222, 74);
            this.txtSellQty.Name = "txtSellQty";
            this.txtSellQty.Size = new System.Drawing.Size(138, 22);
            this.txtSellQty.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(106, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "Sell Date: ";
            // 
            // dateSell
            // 
            this.dateSell.Location = new System.Drawing.Point(221, 140);
            this.dateSell.Name = "dateSell";
            this.dateSell.Size = new System.Drawing.Size(160, 22);
            this.dateSell.TabIndex = 16;
            // 
            // btnShareSell
            // 
            this.btnShareSell.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnShareSell.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.btnShareSell.Location = new System.Drawing.Point(395, 59);
            this.btnShareSell.Margin = new System.Windows.Forms.Padding(4);
            this.btnShareSell.Name = "btnShareSell";
            this.btnShareSell.Size = new System.Drawing.Size(111, 40);
            this.btnShareSell.TabIndex = 22;
            this.btnShareSell.Text = "Add";
            this.btnShareSell.UseVisualStyleBackColor = false;
            // 
            // panelbuy
            // 
            this.panelbuy.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panelbuy.Controls.Add(this.lblMutualFundBuyCharges);
            this.panelbuy.Controls.Add(this.txtBuyCharges);
            this.panelbuy.Controls.Add(this.lblBuyId);
            this.panelbuy.Controls.Add(this.lblMutualFundIdBuy);
            this.panelbuy.Controls.Add(this.txtBuyPrice);
            this.panelbuy.Controls.Add(this.lblMutualFundBuyPrice);
            this.panelbuy.Controls.Add(this.lblMutualFundQnty);
            this.panelbuy.Controls.Add(this.txtBuyQty);
            this.panelbuy.Controls.Add(this.lblDateMFBuy);
            this.panelbuy.Controls.Add(this.dateBuyMF);
            this.panelbuy.Controls.Add(this.btnMutualFundAdd);
            this.panelbuy.Location = new System.Drawing.Point(18, 246);
            this.panelbuy.Name = "panelbuy";
            this.panelbuy.Size = new System.Drawing.Size(537, 179);
            this.panelbuy.TabIndex = 73;
            // 
            // lblMutualFundBuyCharges
            // 
            this.lblMutualFundBuyCharges.AutoSize = true;
            this.lblMutualFundBuyCharges.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.lblMutualFundBuyCharges.Location = new System.Drawing.Point(40, 106);
            this.lblMutualFundBuyCharges.Name = "lblMutualFundBuyCharges";
            this.lblMutualFundBuyCharges.Size = new System.Drawing.Size(141, 23);
            this.lblMutualFundBuyCharges.TabIndex = 24;
            this.lblMutualFundBuyCharges.Text = "MF Buy Charges:";
            // 
            // txtBuyCharges
            // 
            this.txtBuyCharges.Location = new System.Drawing.Point(222, 108);
            this.txtBuyCharges.Name = "txtBuyCharges";
            this.txtBuyCharges.Size = new System.Drawing.Size(138, 22);
            this.txtBuyCharges.TabIndex = 25;
            // 
            // lblBuyId
            // 
            this.lblBuyId.AutoSize = true;
            this.lblBuyId.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblBuyId.Location = new System.Drawing.Point(216, 10);
            this.lblBuyId.Name = "lblBuyId";
            this.lblBuyId.Size = new System.Drawing.Size(118, 27);
            this.lblBuyId.TabIndex = 23;
            this.lblBuyId.Text = "BuyIdLabel";
            // 
            // lblMutualFundIdBuy
            // 
            this.lblMutualFundIdBuy.AutoSize = true;
            this.lblMutualFundIdBuy.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.lblMutualFundIdBuy.Location = new System.Drawing.Point(43, 13);
            this.lblMutualFundIdBuy.Name = "lblMutualFundIdBuy";
            this.lblMutualFundIdBuy.Size = new System.Drawing.Size(138, 23);
            this.lblMutualFundIdBuy.TabIndex = 22;
            this.lblMutualFundIdBuy.Text = "Mutual Fund Id: ";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(221, 45);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(138, 22);
            this.txtBuyPrice.TabIndex = 21;
            // 
            // lblMutualFundBuyPrice
            // 
            this.lblMutualFundBuyPrice.AutoSize = true;
            this.lblMutualFundBuyPrice.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMutualFundBuyPrice.Location = new System.Drawing.Point(55, 43);
            this.lblMutualFundBuyPrice.Name = "lblMutualFundBuyPrice";
            this.lblMutualFundBuyPrice.Size = new System.Drawing.Size(126, 23);
            this.lblMutualFundBuyPrice.TabIndex = 14;
            this.lblMutualFundBuyPrice.Text = "Nav Buy Price: ";
            // 
            // lblMutualFundQnty
            // 
            this.lblMutualFundQnty.AutoSize = true;
            this.lblMutualFundQnty.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.lblMutualFundQnty.Location = new System.Drawing.Point(34, 74);
            this.lblMutualFundQnty.Name = "lblMutualFundQnty";
            this.lblMutualFundQnty.Size = new System.Drawing.Size(147, 23);
            this.lblMutualFundQnty.TabIndex = 20;
            this.lblMutualFundQnty.Text = "MF Buy Quantity:";
            // 
            // txtBuyQty
            // 
            this.txtBuyQty.Location = new System.Drawing.Point(221, 74);
            this.txtBuyQty.Name = "txtBuyQty";
            this.txtBuyQty.Size = new System.Drawing.Size(138, 22);
            this.txtBuyQty.TabIndex = 21;
            // 
            // lblDateMFBuy
            // 
            this.lblDateMFBuy.AutoSize = true;
            this.lblDateMFBuy.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateMFBuy.Location = new System.Drawing.Point(92, 138);
            this.lblDateMFBuy.Name = "lblDateMFBuy";
            this.lblDateMFBuy.Size = new System.Drawing.Size(89, 23);
            this.lblDateMFBuy.TabIndex = 15;
            this.lblDateMFBuy.Text = "Buy Date: ";
            // 
            // dateBuyMF
            // 
            this.dateBuyMF.Location = new System.Drawing.Point(221, 138);
            this.dateBuyMF.Name = "dateBuyMF";
            this.dateBuyMF.Size = new System.Drawing.Size(160, 22);
            this.dateBuyMF.TabIndex = 16;
            // 
            // btnMutualFundAdd
            // 
            this.btnMutualFundAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMutualFundAdd.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.btnMutualFundAdd.Location = new System.Drawing.Point(400, 65);
            this.btnMutualFundAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnMutualFundAdd.Name = "btnMutualFundAdd";
            this.btnMutualFundAdd.Size = new System.Drawing.Size(111, 40);
            this.btnMutualFundAdd.TabIndex = 22;
            this.btnMutualFundAdd.Text = "Add";
            this.btnMutualFundAdd.UseVisualStyleBackColor = false;
            this.btnMutualFundAdd.Click += new System.EventHandler(this.btnMutualFundAdd_Click);
            // 
            // btnUpdateDelivery
            // 
            this.btnUpdateDelivery.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateDelivery.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDelivery.Location = new System.Drawing.Point(269, 174);
            this.btnUpdateDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateDelivery.Name = "btnUpdateDelivery";
            this.btnUpdateDelivery.Size = new System.Drawing.Size(100, 35);
            this.btnUpdateDelivery.TabIndex = 72;
            this.btnUpdateDelivery.Text = "Update";
            this.btnUpdateDelivery.UseVisualStyleBackColor = false;
            this.btnUpdateDelivery.Click += new System.EventHandler(this.btnUpdateDelivery_Click);
            // 
            // btnAddMutualFundHeader
            // 
            this.btnAddMutualFundHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddMutualFundHeader.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddMutualFundHeader.Location = new System.Drawing.Point(145, 174);
            this.btnAddMutualFundHeader.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMutualFundHeader.Name = "btnAddMutualFundHeader";
            this.btnAddMutualFundHeader.Size = new System.Drawing.Size(100, 35);
            this.btnAddMutualFundHeader.TabIndex = 68;
            this.btnAddMutualFundHeader.Text = "Add";
            this.btnAddMutualFundHeader.UseVisualStyleBackColor = false;
            this.btnAddMutualFundHeader.Click += new System.EventHandler(this.btnAddMutualFundHeader_Click);
            // 
            // txtMutualFundName
            // 
            this.txtMutualFundName.Location = new System.Drawing.Point(248, 33);
            this.txtMutualFundName.Name = "txtMutualFundName";
            this.txtMutualFundName.Size = new System.Drawing.Size(175, 22);
            this.txtMutualFundName.TabIndex = 70;
            // 
            // lblMutualFundName
            // 
            this.lblMutualFundName.AutoSize = true;
            this.lblMutualFundName.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMutualFundName.Location = new System.Drawing.Point(54, 32);
            this.lblMutualFundName.Name = "lblMutualFundName";
            this.lblMutualFundName.Size = new System.Drawing.Size(168, 23);
            this.lblMutualFundName.TabIndex = 69;
            this.lblMutualFundName.Text = "Mutual Fund Name: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1233, 661);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Summary";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbDematAccountMutual
            // 
            this.cmbDematAccountMutual.FormattingEnabled = true;
            this.cmbDematAccountMutual.Location = new System.Drawing.Point(548, 19);
            this.cmbDematAccountMutual.Name = "cmbDematAccountMutual";
            this.cmbDematAccountMutual.Size = new System.Drawing.Size(156, 24);
            this.cmbDematAccountMutual.TabIndex = 8;
            this.cmbDematAccountMutual.SelectedIndexChanged += new System.EventHandler(this.cmbDematAccountMutual_SelectedIndexChanged);
            // 
            // lblDematAccountMutual
            // 
            this.lblDematAccountMutual.AutoSize = true;
            this.lblDematAccountMutual.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.lblDematAccountMutual.Location = new System.Drawing.Point(399, 18);
            this.lblDematAccountMutual.Name = "lblDematAccountMutual";
            this.lblDematAccountMutual.Size = new System.Drawing.Size(137, 23);
            this.lblDematAccountMutual.TabIndex = 7;
            this.lblDematAccountMutual.Text = "Demat Account: ";
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Location = new System.Drawing.Point(1178, 13);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(52, 17);
            this.lnkLogout.TabIndex = 10;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(1070, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(38, 17);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "User";
            // 
            // errorProvidermutual
            // 
            this.errorProvidermutual.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 80;
            this.label1.Text = "Is SIP: ";
            // 
            // checkBoxIsSip
            // 
            this.checkBoxIsSip.AutoSize = true;
            this.checkBoxIsSip.Location = new System.Drawing.Point(250, 139);
            this.checkBoxIsSip.Name = "checkBoxIsSip";
            this.checkBoxIsSip.Size = new System.Drawing.Size(120, 21);
            this.checkBoxIsSip.TabIndex = 81;
            this.checkBoxIsSip.Text = "checkBoxIsSip";
            this.checkBoxIsSip.UseVisualStyleBackColor = true;
            // 
            // mUTUALFUNDHEADERPROCEDUREBindingSource
            // 
            this.mUTUALFUNDHEADERPROCEDUREBindingSource.DataMember = "MUTUAL_FUND_HEADER_PROCEDURE";
            this.mUTUALFUNDHEADERPROCEDUREBindingSource.DataSource = this.mutual_FundDataSet;
            // 
            // mutual_FundDataSet
            // 
            this.mutual_FundDataSet.DataSetName = "Mutual_FundDataSet";
            this.mutual_FundDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mUTUAL_FUND_HEADER_PROCEDURETableAdapter
            // 
            this.mUTUAL_FUND_HEADER_PROCEDURETableAdapter.ClearBeforeFill = true;
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.AutoSize = true;
            this.lnkRefresh.Location = new System.Drawing.Point(67, 13);
            this.lnkRefresh.Name = "lnkRefresh";
            this.lnkRefresh.Size = new System.Drawing.Size(58, 17);
            this.lnkRefresh.TabIndex = 12;
            this.lnkRefresh.TabStop = true;
            this.lnkRefresh.Text = "Refresh";
            // 
            // lnkBack
            // 
            this.lnkBack.AutoSize = true;
            this.lnkBack.Location = new System.Drawing.Point(14, 12);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(39, 17);
            this.lnkBack.TabIndex = 11;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "Back";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);
            // 
            // mUTUALFUNDHEADERIDDataGridViewTextBoxColumn
            // 
            this.mUTUALFUNDHEADERIDDataGridViewTextBoxColumn.DataPropertyName = "MUTUAL_FUND_HEADER_ID";
            this.mUTUALFUNDHEADERIDDataGridViewTextBoxColumn.HeaderText = "Mutual Fund Header Id";
            this.mUTUALFUNDHEADERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUTUALFUNDHEADERIDDataGridViewTextBoxColumn.Name = "mUTUALFUNDHEADERIDDataGridViewTextBoxColumn";
            this.mUTUALFUNDHEADERIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mUTUALFUNDNAMEDataGridViewTextBoxColumn
            // 
            this.mUTUALFUNDNAMEDataGridViewTextBoxColumn.DataPropertyName = "MUTUAL_FUND_NAME";
            this.mUTUALFUNDNAMEDataGridViewTextBoxColumn.HeaderText = "Mutual Fund Name";
            this.mUTUALFUNDNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUTUALFUNDNAMEDataGridViewTextBoxColumn.Name = "mUTUALFUNDNAMEDataGridViewTextBoxColumn";
            // 
            // sHAREAMTDataGridViewTextBoxColumn
            // 
            this.sHAREAMTDataGridViewTextBoxColumn.DataPropertyName = "SHARE_AMT";
            this.sHAREAMTDataGridViewTextBoxColumn.HeaderText = "Share Amount";
            this.sHAREAMTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sHAREAMTDataGridViewTextBoxColumn.Name = "sHAREAMTDataGridViewTextBoxColumn";
            this.sHAREAMTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROFITLOSSDataGridViewTextBoxColumn
            // 
            this.pROFITLOSSDataGridViewTextBoxColumn.DataPropertyName = "PROFIT_LOSS";
            this.pROFITLOSSDataGridViewTextBoxColumn.HeaderText = "PROFIT_LOSS";
            this.pROFITLOSSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pROFITLOSSDataGridViewTextBoxColumn.Name = "pROFITLOSSDataGridViewTextBoxColumn";
            this.pROFITLOSSDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROFITLOSSDataGridViewTextBoxColumn.Visible = false;
            // 
            // EXIT_LOAD
            // 
            this.EXIT_LOAD.DataPropertyName = "EXIT_LOAD";
            this.EXIT_LOAD.HeaderText = "EXIT_LOAD";
            this.EXIT_LOAD.MinimumWidth = 6;
            this.EXIT_LOAD.Name = "EXIT_LOAD";
            this.EXIT_LOAD.Visible = false;
            // 
            // IS_SIP
            // 
            this.IS_SIP.DataPropertyName = "IS_SIP";
            this.IS_SIP.HeaderText = "IS_SIP";
            this.IS_SIP.MinimumWidth = 6;
            this.IS_SIP.Name = "IS_SIP";
            this.IS_SIP.Visible = false;
            // 
            // MUTUAL_FUND_CREATED_DATE
            // 
            this.MUTUAL_FUND_CREATED_DATE.DataPropertyName = "MUTUAL_FUND_CREATED_DATE";
            this.MUTUAL_FUND_CREATED_DATE.HeaderText = "MUTUAL_FUND_CREATED_DATE";
            this.MUTUAL_FUND_CREATED_DATE.MinimumWidth = 6;
            this.MUTUAL_FUND_CREATED_DATE.Name = "MUTUAL_FUND_CREATED_DATE";
            this.MUTUAL_FUND_CREATED_DATE.Visible = false;
            // 
            // ViewDetail
            // 
            this.ViewDetail.HeaderText = "Detail";
            this.ViewDetail.MinimumWidth = 6;
            this.ViewDetail.Name = "ViewDetail";
            this.ViewDetail.Text = "View Detail";
            this.ViewDetail.ToolTipText = "View Detail";
            this.ViewDetail.UseColumnTextForButtonValue = true;
            // 
            // MutualFund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1265, 751);
            this.Controls.Add(this.lnkRefresh);
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.cmbDematAccountMutual);
            this.Controls.Add(this.lblDematAccountMutual);
            this.Controls.Add(this.tabControlMutualFund);
            this.Name = "MutualFund";
            this.Text = "Mutual Fund";
            this.Load += new System.EventHandler(this.MutualFund_Load);
            this.tabControlMutualFund.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMutualFund)).EndInit();
            this.panelSell.ResumeLayout(false);
            this.panelSell.PerformLayout();
            this.panelbuy.ResumeLayout(false);
            this.panelbuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidermutual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUTUALFUNDHEADERPROCEDUREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutual_FundDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMutualFund;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdateDelivery;
        private System.Windows.Forms.Button btnAddMutualFundHeader;
        private System.Windows.Forms.TextBox txtMutualFundName;
        private System.Windows.Forms.Label lblMutualFundName;
        private System.Windows.Forms.Panel panelSell;
        private System.Windows.Forms.TextBox txtSellCharges;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSellId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSellQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateSell;
        private System.Windows.Forms.Button btnShareSell;
        private System.Windows.Forms.Panel panelbuy;
        private System.Windows.Forms.Label lblMutualFundBuyCharges;
        private System.Windows.Forms.TextBox txtBuyCharges;
        private System.Windows.Forms.Label lblBuyId;
        private System.Windows.Forms.Label lblMutualFundIdBuy;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Label lblMutualFundBuyPrice;
        private System.Windows.Forms.Label lblMutualFundQnty;
        private System.Windows.Forms.TextBox txtBuyQty;
        private System.Windows.Forms.Label lblDateMFBuy;
        private System.Windows.Forms.DateTimePicker dateBuyMF;
        private System.Windows.Forms.Button btnMutualFundAdd;
        private System.Windows.Forms.DataGridView dataGridViewMutualFund;
        private System.Windows.Forms.ComboBox cmbDematAccountMutual;
        private System.Windows.Forms.Label lblDematAccountMutual;
        private System.Windows.Forms.Label lblMutualFundStartDate;
        private System.Windows.Forms.DateTimePicker dateStartDateMutual;
        private System.Windows.Forms.TextBox txtboxExitLoad;
        private System.Windows.Forms.Label lblExitLoad;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.BindingSource mUTUALFUNDHEADERPROCEDUREBindingSource;
        private DataSet.Mutual_FundDataSet mutual_FundDataSet;
        private DataSet.Mutual_FundDataSetTableAdapters.MUTUAL_FUND_HEADER_PROCEDURETableAdapter mUTUAL_FUND_HEADER_PROCEDURETableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvidermutual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxIsSip;
        private System.Windows.Forms.LinkLabel lnkRefresh;
        private System.Windows.Forms.LinkLabel lnkBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUTUALFUNDHEADERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUTUALFUNDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHAREAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROFITLOSSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXIT_LOAD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IS_SIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUTUAL_FUND_CREATED_DATE;
        private System.Windows.Forms.DataGridViewButtonColumn ViewDetail;
    }
}