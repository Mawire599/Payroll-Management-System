using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManagementSystem
{
    public partial class frmPayroll : Form
    {
        SqlConnection con = new SqlConnection(
    @"Server=.\SQLEXPRESS;Database=PayrollDB;Trusted_Connection=True;TrustServerCertificate=True;");
        public frmPayroll()
        {
            InitializeComponent();

            cmbDepartment.Items.Add("IT");
            cmbDepartment.Items.Add("HR");
            cmbDepartment.Items.Add("Finance");
            cmbDepartment.Items.Add("Barber");
            cmbDepartment.Items.Add("Manager");
        }

        private void GenerateEmployeeID()
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT TOP 1 EmployeeID FROM Employees ORDER BY EmployeeID DESC", con);

                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    txtEmployeeID.Text = "EMP001";
                }
                else
                {
                    string lastID = result.ToString();
                    int number = int.Parse(lastID.Substring(3));
                    number++;

                    txtEmployeeID.Text = "EMP" + number.ToString("000");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        private void LoadEmployees()
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Employees ORDER BY EmployeeID", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvEmployees.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        private void ClearFields()
        {
            txtFullName.Clear();
            txtSalary.Clear();
            txtHours.Clear();

            cmbDepartment.SelectedIndex = -1;

            lstPayslip.Items.Clear();

            GenerateEmployeeID();

            txtFullName.Focus();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            GenerateEmployeeID();
            LoadEmployees();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a department");
                return;
            }

            string employeeID = txtEmployeeID.Text;
            string employeeName = txtFullName.Text;
            string department = cmbDepartment.Text;

            double hourlyRate;
            int hoursWorked;

            if (!double.TryParse(txtSalary.Text, out hourlyRate))
            {
                MessageBox.Show("Enter valid hourly rate");
                return;
            }

            if (!int.TryParse(txtHours.Text, out hoursWorked))
            {
                MessageBox.Show("Enter valid hours worked");
                return;
            }

            double grossPay;
            double tax;
            double netPay;

            if (hoursWorked <= 12)
            {
                grossPay = hourlyRate * hoursWorked;
            }
            else
            {
                int overtimeHours = hoursWorked - 12;

                grossPay =
                    (12 * hourlyRate) +
                    (overtimeHours * hourlyRate * 1.5);
            }

            tax = grossPay * 0.20;
            netPay = grossPay - tax;

            try
            {
                con.Open();

                // Check if employee already exists
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Employees WHERE EmployeeID=@EmployeeID", con);

                checkCmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    DialogResult result = MessageBox.Show(
                        "Employee already exists.\n\nDo you want to update this employee?",
                        "Employee Exists",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        SqlCommand updateCmd = new SqlCommand(
                            "UPDATE Employees SET FullName=@FullName, Department=@Department, HourlyRate=@HourlyRate, HoursWorked=@HoursWorked, GrossPay=@GrossPay, Tax=@Tax, NetPay=@NetPay WHERE EmployeeID=@EmployeeID",
                            con);

                        updateCmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                        updateCmd.Parameters.AddWithValue("@FullName", employeeName);
                        updateCmd.Parameters.AddWithValue("@Department", department);
                        updateCmd.Parameters.AddWithValue("@HourlyRate", hourlyRate);
                        updateCmd.Parameters.AddWithValue("@HoursWorked", hoursWorked);
                        updateCmd.Parameters.AddWithValue("@GrossPay", grossPay);
                        updateCmd.Parameters.AddWithValue("@Tax", tax);
                        updateCmd.Parameters.AddWithValue("@NetPay", netPay);

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Employee updated successfully!");

                        con.Close();

                        LoadEmployees();
                        ClearFields();
                    }
                }
                else
                {
                    SqlCommand insertCmd = new SqlCommand(
                        "INSERT INTO Employees (EmployeeID, FullName, Department, HourlyRate, HoursWorked, GrossPay, Tax, NetPay) " +
                        "VALUES (@EmployeeID, @FullName, @Department, @HourlyRate, @HoursWorked, @GrossPay, @Tax, @NetPay)", con);

                    insertCmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                    insertCmd.Parameters.AddWithValue("@FullName", employeeName);
                    insertCmd.Parameters.AddWithValue("@Department", department);
                    insertCmd.Parameters.AddWithValue("@HourlyRate", hourlyRate);
                    insertCmd.Parameters.AddWithValue("@HoursWorked", hoursWorked);
                    insertCmd.Parameters.AddWithValue("@GrossPay", grossPay);
                    insertCmd.Parameters.AddWithValue("@Tax", tax);
                    insertCmd.Parameters.AddWithValue("@NetPay", netPay);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Employee saved successfully!");

                    con.Close();

                    LoadEmployees();
                    ClearFields();
                 
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }

            // Display Payslip
            lstPayslip.Items.Clear();

            lstPayslip.Items.Add("====================================");
            lstPayslip.Items.Add("           CUTCONNECT");
            lstPayslip.Items.Add("            PAYSLIP");
            lstPayslip.Items.Add("====================================");
            lstPayslip.Items.Add("");

            lstPayslip.Items.Add("Employee ID : " + employeeID);
            lstPayslip.Items.Add("Name        : " + employeeName);
            lstPayslip.Items.Add("Department  : " + department);
            lstPayslip.Items.Add("Hours       : " + hoursWorked);
            lstPayslip.Items.Add("");

            lstPayslip.Items.Add("------------------------------------");
            lstPayslip.Items.Add("Gross Pay   : R" + grossPay.ToString("0.00"));
            lstPayslip.Items.Add("Tax (20%)   : R" + tax.ToString("0.00"));
            lstPayslip.Items.Add("Net Pay     : R" + netPay.ToString("0.00"));
            lstPayslip.Items.Add("------------------------------------");
            lstPayslip.Items.Add("");

            lstPayslip.Items.Add("Date : " + DateTime.Now.ToShortDateString());
            lstPayslip.Items.Add("====================================");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save Payslip";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw =
                    new System.IO.StreamWriter(saveFileDialog.FileName);

                foreach (var item in lstPayslip.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();

                MessageBox.Show(
                    "Payslip Saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string payslip = "";

            foreach (var item in lstPayslip.Items)
            {
                payslip += item.ToString() + Environment.NewLine;
            }

            e.Graphics.DrawString(payslip, new Font("Consolas", 10), Brushes.Black,50,50);
        }

        private void btnViewEmployees_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Employees WHERE EmployeeID=@EmployeeID", con);

                cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtFullName.Text = dr["FullName"].ToString();
                    cmbDepartment.Text = dr["Department"].ToString();
                    txtSalary.Text = dr["HourlyRate"].ToString();
                    txtHours.Text = dr["HoursWorked"].ToString();
                }
                else
                {
                    MessageBox.Show("Employee not found.");
                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                double hourlyRate = Convert.ToDouble(txtSalary.Text);
                int hoursWorked = Convert.ToInt32(txtHours.Text);

                double grossPay;

                if (hoursWorked <= 12)
                {
                    grossPay = hourlyRate * hoursWorked;
                }
                else
                {
                    int overtimeHours = hoursWorked - 12;

                    grossPay = (12 * hourlyRate) + (overtimeHours * hourlyRate * 1.5);
                }

                double tax = grossPay * 0.20;
                double netPay = grossPay - tax;

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Employees SET FullName=@FullName, Department=@Department, HourlyRate=@HourlyRate, HoursWorked=@HoursWorked, GrossPay=@GrossPay, Tax=@Tax, NetPay=@NetPay WHERE EmployeeID=@EmployeeID",
                    con);

                cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text);
                cmd.Parameters.AddWithValue("@HourlyRate", Convert.ToDouble(txtSalary.Text));
                cmd.Parameters.AddWithValue("@HoursWorked", Convert.ToInt32(txtHours.Text));
                cmd.Parameters.AddWithValue("@GrossPay", grossPay);
                cmd.Parameters.AddWithValue("@Tax", tax);
                cmd.Parameters.AddWithValue("@NetPay", netPay);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Employee updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this employee?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Employees WHERE EmployeeID=@EmployeeID", con);

                    cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);

                    int rows = cmd.ExecuteNonQuery();

                    con.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("Employee deleted successfully!");
                        LoadEmployees();
                        ClearFields();

                    }
                    else
                    {
                        MessageBox.Show("Employee not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void lblSalary_Click(object sender, EventArgs e)
        {

        }

        private void lblDept_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }
    }

 }

