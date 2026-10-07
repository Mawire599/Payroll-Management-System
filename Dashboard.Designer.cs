namespace PayrollManagementSystem
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panelEmployeeDetails = new System.Windows.Forms.Panel();
            this.lblDetailDateCreated = new System.Windows.Forms.Label();
            this.lblDetailNetPay = new System.Windows.Forms.Label();
            this.lblDetailDepartment = new System.Windows.Forms.Label();
            this.lblDetailName = new System.Windows.Forms.Label();
            this.lblDetailEmployeeID = new System.Windows.Forms.Label();
            this.lblEmployeeDetailsTitle = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRecentEmployees = new System.Windows.Forms.DataGridView();
            this.chartDepartment = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPayroll = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblLowestPay = new System.Windows.Forms.Label();
            this.lblLowestTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHighestPay = new System.Windows.Forms.Label();
            this.lblHighestTilte = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPayrollTotal = new System.Windows.Forms.Label();
            this.lblPayrollTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmployeeCount = new System.Windows.Forms.Label();
            this.lblEmployeesTitle = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panelEmployeeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayroll)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHeader.Controls.Add(this.lblTime);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Controls.Add(this.lblUser);
            this.pnlHeader.Controls.Add(this.lblGreeting);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1833, 102);
            this.pnlHeader.TabIndex = 7;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Blue;
            this.lblTime.Location = new System.Drawing.Point(1202, 57);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(125, 38);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "11:15 AM";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDate.Location = new System.Drawing.Point(986, 69);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(106, 23);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "29 July 2026";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Blue;
            this.lblUser.Location = new System.Drawing.Point(152, 64);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(72, 28);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Admin";
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.SystemColors.Control;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblGreeting.Location = new System.Drawing.Point(32, 69);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(123, 23);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "Good Morning,";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(28, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(763, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CUTCONNECT PAYROLL MANAGEMENT SYSTEM";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnReports);
            this.pnlMenu.Controls.Add(this.btnPayroll);
            this.pnlMenu.Controls.Add(this.btnEmployees);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 102);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(210, 809);
            this.pnlMenu.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(26, 351);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(134, 50);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.DarkCyan;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(26, 238);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(134, 57);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            this.btnReports.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnReports.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnPayroll
            // 
            this.btnPayroll.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPayroll.FlatAppearance.BorderSize = 0;
            this.btnPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayroll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayroll.ForeColor = System.Drawing.Color.White;
            this.btnPayroll.Location = new System.Drawing.Point(26, 146);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Size = new System.Drawing.Size(133, 50);
            this.btnPayroll.TabIndex = 1;
            this.btnPayroll.Text = "Payroll";
            this.btnPayroll.UseVisualStyleBackColor = false;
            this.btnPayroll.Click += new System.EventHandler(this.btnPayroll_Click);
            this.btnPayroll.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnPayroll.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Location = new System.Drawing.Point(26, 60);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(133, 45);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            this.btnEmployees.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnEmployees.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panelEmployeeDetails);
            this.pnlMain.Controls.Add(this.btnExportExcel);
            this.pnlMain.Controls.Add(this.picSearch);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.dgvRecentEmployees);
            this.pnlMain.Controls.Add(this.chartDepartment);
            this.pnlMain.Controls.Add(this.chartPayroll);
            this.pnlMain.Controls.Add(this.panel5);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(210, 102);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1623, 809);
            this.pnlMain.TabIndex = 9;
            // 
            // panelEmployeeDetails
            // 
            this.panelEmployeeDetails.Controls.Add(this.lblDetailDateCreated);
            this.panelEmployeeDetails.Controls.Add(this.lblDetailNetPay);
            this.panelEmployeeDetails.Controls.Add(this.lblDetailDepartment);
            this.panelEmployeeDetails.Controls.Add(this.lblDetailName);
            this.panelEmployeeDetails.Controls.Add(this.lblDetailEmployeeID);
            this.panelEmployeeDetails.Controls.Add(this.lblEmployeeDetailsTitle);
            this.panelEmployeeDetails.Location = new System.Drawing.Point(1332, 64);
            this.panelEmployeeDetails.Name = "panelEmployeeDetails";
            this.panelEmployeeDetails.Size = new System.Drawing.Size(258, 429);
            this.panelEmployeeDetails.TabIndex = 12;
            this.panelEmployeeDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEmployeeDetails_Paint);
            // 
            // lblDetailDateCreated
            // 
            this.lblDetailDateCreated.AutoSize = true;
            this.lblDetailDateCreated.Location = new System.Drawing.Point(11, 396);
            this.lblDetailDateCreated.Name = "lblDetailDateCreated";
            this.lblDetailDateCreated.Size = new System.Drawing.Size(92, 17);
            this.lblDetailDateCreated.TabIndex = 5;
            this.lblDetailDateCreated.Text = "Date Created:";
            // 
            // lblDetailNetPay
            // 
            this.lblDetailNetPay.Location = new System.Drawing.Point(17, 314);
            this.lblDetailNetPay.Name = "lblDetailNetPay";
            this.lblDetailNetPay.Size = new System.Drawing.Size(180, 40);
            this.lblDetailNetPay.TabIndex = 4;
            this.lblDetailNetPay.Text = "Net Pay:";
            // 
            // lblDetailDepartment
            // 
            this.lblDetailDepartment.AutoSize = true;
            this.lblDetailDepartment.Location = new System.Drawing.Point(17, 225);
            this.lblDetailDepartment.Name = "lblDetailDepartment";
            this.lblDetailDepartment.Size = new System.Drawing.Size(86, 17);
            this.lblDetailDepartment.TabIndex = 3;
            this.lblDetailDepartment.Text = "Department:";
            // 
            // lblDetailName
            // 
            this.lblDetailName.AutoSize = true;
            this.lblDetailName.Location = new System.Drawing.Point(17, 153);
            this.lblDetailName.Name = "lblDetailName";
            this.lblDetailName.Size = new System.Drawing.Size(48, 17);
            this.lblDetailName.TabIndex = 2;
            this.lblDetailName.Text = "Name:";
            // 
            // lblDetailEmployeeID
            // 
            this.lblDetailEmployeeID.AutoSize = true;
            this.lblDetailEmployeeID.Location = new System.Drawing.Point(13, 82);
            this.lblDetailEmployeeID.Name = "lblDetailEmployeeID";
            this.lblDetailEmployeeID.Size = new System.Drawing.Size(90, 17);
            this.lblDetailEmployeeID.TabIndex = 1;
            this.lblDetailEmployeeID.Text = "Employee ID:";
            // 
            // lblEmployeeDetailsTitle
            // 
            this.lblEmployeeDetailsTitle.AutoSize = true;
            this.lblEmployeeDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDetailsTitle.Location = new System.Drawing.Point(45, 9);
            this.lblEmployeeDetailsTitle.Name = "lblEmployeeDetailsTitle";
            this.lblEmployeeDetailsTitle.Size = new System.Drawing.Size(174, 28);
            this.lblEmployeeDetailsTitle.TabIndex = 0;
            this.lblEmployeeDetailsTitle.Text = "Employee Details";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Location = new System.Drawing.Point(379, 505);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(148, 30);
            this.btnExportExcel.TabIndex = 11;
            this.btnExportExcel.Text = "Export to Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // picSearch
            // 
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(194, 504);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(38, 34);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 10;
            this.picSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(232, 510);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(125, 25);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search Employee:";
            // 
            // dgvRecentEmployees
            // 
            this.dgvRecentEmployees.AllowUserToAddRows = false;
            this.dgvRecentEmployees.AllowUserToDeleteRows = false;
            this.dgvRecentEmployees.AllowUserToResizeRows = false;
            this.dgvRecentEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentEmployees.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRecentEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentEmployees.Location = new System.Drawing.Point(33, 544);
            this.dgvRecentEmployees.MultiSelect = false;
            this.dgvRecentEmployees.Name = "dgvRecentEmployees";
            this.dgvRecentEmployees.ReadOnly = true;
            this.dgvRecentEmployees.RowHeadersVisible = false;
            this.dgvRecentEmployees.RowHeadersWidth = 51;
            this.dgvRecentEmployees.RowTemplate.Height = 24;
            this.dgvRecentEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentEmployees.Size = new System.Drawing.Size(1284, 124);
            this.dgvRecentEmployees.TabIndex = 7;
            this.dgvRecentEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentEmployees_CellClick);
            // 
            // chartDepartment
            // 
            chartArea17.Name = "ChartArea1";
            this.chartDepartment.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.chartDepartment.Legends.Add(legend17);
            this.chartDepartment.Location = new System.Drawing.Point(1022, 178);
            this.chartDepartment.Name = "chartDepartment";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Series1";
            this.chartDepartment.Series.Add(series17);
            this.chartDepartment.Size = new System.Drawing.Size(295, 300);
            this.chartDepartment.TabIndex = 6;
            this.chartDepartment.Text = "chart1";
            // 
            // chartPayroll
            // 
            chartArea18.Name = "ChartArea1";
            this.chartPayroll.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chartPayroll.Legends.Add(legend18);
            this.chartPayroll.Location = new System.Drawing.Point(33, 178);
            this.chartPayroll.Name = "chartPayroll";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Series1";
            this.chartPayroll.Series.Add(series18);
            this.chartPayroll.Size = new System.Drawing.Size(983, 300);
            this.chartPayroll.TabIndex = 5;
            this.chartPayroll.Text = "chart1";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 715);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1623, 94);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.lblLowestPay);
            this.panel4.Controls.Add(this.lblLowestTitle);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(999, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 130);
            this.panel4.TabIndex = 3;
            // 
            // lblLowestPay
            // 
            this.lblLowestPay.AutoSize = true;
            this.lblLowestPay.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestPay.Location = new System.Drawing.Point(77, 51);
            this.lblLowestPay.Name = "lblLowestPay";
            this.lblLowestPay.Size = new System.Drawing.Size(126, 54);
            this.lblLowestPay.TabIndex = 5;
            this.lblLowestPay.Text = "R0.00";
            this.lblLowestPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowestTitle
            // 
            this.lblLowestTitle.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblLowestTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestTitle.ForeColor = System.Drawing.Color.White;
            this.lblLowestTitle.Location = new System.Drawing.Point(34, 2);
            this.lblLowestTitle.Name = "lblLowestTitle";
            this.lblLowestTitle.Size = new System.Drawing.Size(201, 38);
            this.lblLowestTitle.TabIndex = 0;
            this.lblLowestTitle.Text = "Lowest Salary";
            this.lblLowestTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.lblHighestPay);
            this.panel3.Controls.Add(this.lblHighestTilte);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(678, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 130);
            this.panel3.TabIndex = 2;
            // 
            // lblHighestPay
            // 
            this.lblHighestPay.AutoSize = true;
            this.lblHighestPay.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestPay.Location = new System.Drawing.Point(78, 43);
            this.lblHighestPay.Name = "lblHighestPay";
            this.lblHighestPay.Size = new System.Drawing.Size(126, 54);
            this.lblHighestPay.TabIndex = 1;
            this.lblHighestPay.Text = "R0.00";
            // 
            // lblHighestTilte
            // 
            this.lblHighestTilte.AutoSize = true;
            this.lblHighestTilte.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestTilte.Location = new System.Drawing.Point(80, 10);
            this.lblHighestTilte.Name = "lblHighestTilte";
            this.lblHighestTilte.Size = new System.Drawing.Size(124, 23);
            this.lblHighestTilte.TabIndex = 0;
            this.lblHighestTilte.Text = "Highest Salary";
            this.lblHighestTilte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.lblPayrollTotal);
            this.panel2.Controls.Add(this.lblPayrollTitle);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(357, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 130);
            this.panel2.TabIndex = 1;
            // 
            // lblPayrollTotal
            // 
            this.lblPayrollTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayrollTotal.Location = new System.Drawing.Point(68, 43);
            this.lblPayrollTotal.Name = "lblPayrollTotal";
            this.lblPayrollTotal.Size = new System.Drawing.Size(158, 54);
            this.lblPayrollTotal.TabIndex = 1;
            this.lblPayrollTotal.Text = "R0.00";
            // 
            // lblPayrollTitle
            // 
            this.lblPayrollTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayrollTitle.Location = new System.Drawing.Point(58, 2);
            this.lblPayrollTitle.Name = "lblPayrollTitle";
            this.lblPayrollTitle.Size = new System.Drawing.Size(168, 41);
            this.lblPayrollTitle.TabIndex = 0;
            this.lblPayrollTitle.Text = "Total Payroll";
            this.lblPayrollTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.lblEmployeeCount);
            this.panel1.Controls.Add(this.lblEmployeesTitle);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(33, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 130);
            this.panel1.TabIndex = 0;
            // 
            // lblEmployeeCount
            // 
            this.lblEmployeeCount.AutoSize = true;
            this.lblEmployeeCount.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeCount.Location = new System.Drawing.Point(114, 46);
            this.lblEmployeeCount.Name = "lblEmployeeCount";
            this.lblEmployeeCount.Size = new System.Drawing.Size(46, 54);
            this.lblEmployeeCount.TabIndex = 1;
            this.lblEmployeeCount.Text = "0";
            // 
            // lblEmployeesTitle
            // 
            this.lblEmployeesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeesTitle.Location = new System.Drawing.Point(64, 5);
            this.lblEmployeesTitle.Name = "lblEmployeesTitle";
            this.lblEmployeesTitle.Size = new System.Drawing.Size(162, 41);
            this.lblEmployeesTitle.TabIndex = 0;
            this.lblEmployeesTitle.Text = "Total Employees";
            this.lblEmployeesTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1833, 911);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panelEmployeeDetails.ResumeLayout(false);
            this.panelEmployeeDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayroll)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel pnlMain;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmployeeCount;
        private System.Windows.Forms.Label lblEmployeesTitle;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPayrollTotal;
        private System.Windows.Forms.Label lblPayrollTitle;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHighestPay;
        private System.Windows.Forms.Label lblHighestTilte;

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblLowestPay;
        private System.Windows.Forms.Label lblLowestTitle;

        private System.Windows.Forms.Panel panel5;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPayroll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDepartment;

        private System.Windows.Forms.DataGridView dgvRecentEmployees;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picSearch;

        private System.Windows.Forms.Button btnExportExcel;

        private System.Windows.Forms.Panel panelEmployeeDetails;
        private System.Windows.Forms.Label lblEmployeeDetailsTitle;
        private System.Windows.Forms.Label lblDetailEmployeeID;
        private System.Windows.Forms.Label lblDetailName;
        private System.Windows.Forms.Label lblDetailDepartment;
        private System.Windows.Forms.Label lblDetailNetPay;
        private System.Windows.Forms.Label lblDetailDateCreated;

        private System.Windows.Forms.Timer timerClock;
    }
}