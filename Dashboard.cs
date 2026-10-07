using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManagementSystem
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();

            lblUser.Text = "Admin";

            int hour = DateTime.Now.Hour;

            if (hour < 12)
            {
                lblGreeting.Text = "Good Morning,";
            }
            else if (hour < 17)
            {
                lblGreeting.Text = "Good Afternoon,";
            }
            else
            {
                lblGreeting.Text = "Good Evening,";
            }
        }

        private void MenuButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightCyan;
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.SteelBlue;
        }

        SqlConnection con = new SqlConnection(
    @"Data Source=.\SQLEXPRESS;Initial Catalog=PayrollDB;Integrated Security=True;TrustServerCertificate=True");

        private void LoadDashboard()
        {
            try
            {

                chartPayroll.Series.Clear();
                chartPayroll.Titles.Clear();

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                Series series = new Series("Monthly Payroll");
                
                series.ChartType = SeriesChartType.Bar;
                series["PointWidth"] = "0.85";
                series.BorderWidth = 0;
                series.ShadowOffset = 0;

                chartPayroll.Series.Add(series);

                series.Palette = ChartColorPalette.None;                             
                series.IsValueShownAsLabel = true;
                series["BarLabelStyle"] = "Outside";
                series.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                series.LabelForeColor = Color.Black;

                
                chartPayroll.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                chartPayroll.ChartAreas[0].BackColor = Color.Transparent;
                chartPayroll.ChartAreas[0].InnerPlotPosition.Auto = true;

                chartPayroll.BackColor = Color.Transparent;
                chartPayroll.BorderlineWidth = 0;
                chartPayroll.BorderlineColor = Color.Transparent;

                chartPayroll.ChartAreas[0].BorderWidth = 0;

                chartPayroll.ChartAreas[0].BorderColor = Color.White;
                chartPayroll.ChartAreas[0].ShadowColor = Color.Transparent;

                chartPayroll.Legends[0].Enabled = false;

                chartPayroll.ChartAreas[0].AxisX.Title = "";
                chartPayroll.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";

                chartPayroll.ChartAreas[0].AxisX.LineWidth = 0;
                chartPayroll.ChartAreas[0].AxisY.LineWidth = 0;
                chartPayroll.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gainsboro;
                chartPayroll.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

                chartPayroll.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
                chartPayroll.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;

                chartPayroll.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartPayroll.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                chartPayroll.ChartAreas[0].AxisX.LineColor = Color.Transparent;
                chartPayroll.ChartAreas[0].AxisY.LineColor = Color.Transparent;

                chartPayroll.ChartAreas[0].AxisX.LabelStyle.Font =
                    new Font("Segoe UI Semibold", 10, FontStyle.Bold);

                chartPayroll.ChartAreas[0].AxisY.LabelStyle.Font =
                    new Font("Segoe UI Semibold", 11);

                chartPayroll.ChartAreas[0].AxisY.IsMarginVisible = false;


                chartPayroll.Titles.Add("Payroll Statistics");
                chartPayroll.Titles[0].Font = new Font("Segoe UI Semibold", 20, FontStyle.Bold);
                chartPayroll.Titles[0].ForeColor = Color.FromArgb(45, 45, 48);

                // Total Employees
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Employees", con);
                int employeeCount = Convert.ToInt32(cmd1.ExecuteScalar());

                // Total Payroll
                SqlCommand cmd2 = new SqlCommand("SELECT ISNULL(SUM(NetPay),0) FROM Employees", con);
                decimal payrollTotal = Convert.ToDecimal(cmd2.ExecuteScalar());

                // Highest Salary
                SqlCommand cmd3 = new SqlCommand("SELECT ISNULL(MAX(NetPay),0) FROM Employees", con);
                decimal highestPay = Convert.ToDecimal(cmd3.ExecuteScalar());

                // Lowest Salary
                SqlCommand cmd4 = new SqlCommand("SELECT ISNULL(MIN(NetPay),0) FROM Employees", con);
                decimal lowestPay = Convert.ToDecimal(cmd4.ExecuteScalar());

                // Update Dashboard Cards
                lblEmployeeCount.Text = employeeCount.ToString();
                lblPayrollTotal.Text = "R" + payrollTotal.ToString("N2");
                lblHighestPay.Text = "R" + highestPay.ToString("N2");
                lblLowestPay.Text = "R" + lowestPay.ToString("N2");

                SqlCommand cmdChart = new SqlCommand(@"
                 SELECT Department,
                 SUM(NetPay) AS TotalPayroll
                 FROM Employees
                 GROUP BY Department
                 ORDER BY TotalPayroll DESC", con);

                using (SqlDataReader reader = cmdChart.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataPoint point = new DataPoint();

                        point.AxisLabel = reader["Department"].ToString();
                        point.YValues = new double[]
                        {
            Convert.ToDouble(reader["TotalPayroll"])
                        };

                        point.Label = "R" +
                            Convert.ToDecimal(reader["TotalPayroll"]).ToString("N2");

                        series.Points.Add(point);
                    }
                }

                Color[] colors =
                {
                Color.SteelBlue,
                Color.MediumSeaGreen,
                Color.DarkOrange,
                Color.IndianRed,
                Color.MediumPurple,
                Color.Teal,
                Color.DeepSkyBlue
                };

                for (int i = 0; i < series.Points.Count; i++)
                {
                    series.Points[i].Color = colors[i % colors.Length];
                }

                LoadDepartmentChart();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void LoadDepartmentChart()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            chartDepartment.Series.Clear();
            chartDepartment.Titles.Clear();

            Series series = new Series("Departments");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.Label = "#VALX\n#PERCENT";

            chartDepartment.Series.Add(series);

            SqlCommand cmd = new SqlCommand(@"
        SELECT Department,
               COUNT(*) AS TotalEmployees
        FROM Employees
        GROUP BY Department", con);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    series.Points.AddXY(
                        reader["Department"].ToString(),
                        Convert.ToInt32(reader["TotalEmployees"]));
                }
            }

            chartDepartment.Titles.Add("Employees by Department");
        }

        private void LoadRecentEmployees()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string query = @"
        SELECT TOP 10
            EmployeeID,
            FullName,
            Department,
            NetPay,
            DateCreated
        FROM Employees
        ORDER BY DateCreated DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRecentEmployees.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recent employees:\n" + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();

                this.Close();
            }
        }
        
        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
            LoadDepartmentChart();
            LoadRecentEmployees();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {

            frmEmployees employees = new frmEmployees();
            employees.Show();

        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            frmPayroll payroll = new frmPayroll();
            payroll.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.Show();
        }

        private void btnEmployees_MouseEnter(object sender, EventArgs e)
        {

            btnEmployees.BackColor = Color.LightCyan;
        }

        private void btnEmployees_MouseLeave(object sender, EventArgs e)
        {

            btnEmployees.BackColor = Color.SteelBlue;
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            int hour = DateTime.Now.Hour;

            if (hour < 12)
                lblGreeting.Text = "Good Morning,";
            else if (hour < 17)
                lblGreeting.Text = "Good Afternoon,";
            else
                lblGreeting.Text = "Good Evening,";
        }

        private void lblEmployeesTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblPayrollTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeCount_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string query = @"
        SELECT EmployeeID,
               FullName,
               Department,
               NetPay,
               DateCreated
        FROM Employees
        WHERE EmployeeID LIKE @search
           OR FullName LIKE @search
           OR Department LIKE @search
        ORDER BY DateCreated DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRecentEmployees.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "CSV File (*.csv)|*.csv";
            save.Title = "Export Employees";
            save.FileName = "EmployeesReport.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(save.FileName))
                {
                    // Write column headers
                    for (int i = 0; i < dgvRecentEmployees.Columns.Count; i++)
                    {
                        sw.Write(dgvRecentEmployees.Columns[i].HeaderText);

                        if (i < dgvRecentEmployees.Columns.Count - 1)
                            sw.Write(",");
                    }

                    sw.WriteLine();

                    // Write rows
                    foreach (DataGridViewRow row in dgvRecentEmployees.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dgvRecentEmployees.Columns.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value);

                                if (i < dgvRecentEmployees.Columns.Count - 1)
                                    sw.Write(",");
                            }

                            sw.WriteLine();
                        }
                    }
                }

                MessageBox.Show(
                    "Employees exported successfully!",
                    "Export Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Process.Start(save.FileName);
            }
        }

        private void dgvRecentEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvRecentEmployees.Rows[e.RowIndex];

            lblDetailEmployeeID.Text = "Employee ID: " +
                row.Cells["EmployeeID"].Value?.ToString();

            lblDetailName.Text = "Name: " +
                row.Cells["FullName"].Value?.ToString();

            lblDetailDepartment.Text = "Department: " +
                row.Cells["Department"].Value?.ToString();

            lblDetailNetPay.Text = "Net Pay: R" +
                Convert.ToDecimal(row.Cells["NetPay"].Value).ToString("N2");

            lblDetailDateCreated.Text = "Date Created: " +
                Convert.ToDateTime(row.Cells["DateCreated"].Value).ToString("dd MMM yyyy");
        }
        // Add this method to handle the lblTime.Click event and resolve CS1061
        private void lblTime_Click(object sender, EventArgs e)
        {
            // Optionally, add any logic you want to execute when lblTime is clicked.
            // For now, this can be left empty or display the current time.
            MessageBox.Show("Current Time: " + DateTime.Now.ToString("hh:mm tt"), "Time");
        }
    }
    
}
