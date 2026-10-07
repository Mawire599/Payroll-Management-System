using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PayrollManagementSystem
{
    public partial class frmEmployees : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=PayrollDB;Integrated Security=True;TrustServerCertificate=True");
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void LoadEmployees()
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Employees", con);

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

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void SearchEmployees()
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Employees WHERE EmployeeID LIKE @search OR FullName LIKE @search",
                    con);

                da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please enter an Employee ID or Full Name.");
                return;
            }

            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Employees WHERE EmployeeID LIKE @Search OR FullName LIKE @Search",
                    con);

                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];

                txtEmployeeID.Text = row.Cells["EmployeeID"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                cmbDepartment.Text = row.Cells["Department"].Value.ToString();
                txtSalary.Text = row.Cells["HourlyRate"].Value.ToString();
                txtHours.Text = row.Cells["HoursWorked"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

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

                    grossPay = (12 * hourlyRate) +
                               (overtimeHours * hourlyRate * 1.5);
                }

                double tax = grossPay * 0.20;
                double netPay = grossPay - tax;

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Employees SET " +
                    "FullName=@FullName, " +
                    "Department=@Department, " +
                    "HourlyRate=@HourlyRate, " +
                    "HoursWorked=@HoursWorked, " +
                    "GrossPay=@GrossPay, " +
                    "Tax=@Tax, " +
                    "NetPay=@NetPay " +
                    "WHERE EmployeeID=@EmployeeID", con);

                cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text);
                cmd.Parameters.AddWithValue("@HourlyRate", hourlyRate);
                cmd.Parameters.AddWithValue("@HoursWorked", hoursWorked);
                cmd.Parameters.AddWithValue("@GrossPay", grossPay);
                cmd.Parameters.AddWithValue("@Tax", tax);
                cmd.Parameters.AddWithValue("@NetPay", netPay);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Employee updated successfully!");

                LoadEmployees();
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
            if (MessageBox.Show("Are you sure you want to delete this employee?",
                   "Confirm Delete",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Employees WHERE EmployeeID=@EmployeeID", con);

                    cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Employee deleted successfully!");

                    LoadEmployees();

                    txtEmployeeID.Clear();
                    txtFullName.Clear();
                    txtSalary.Clear();
                    txtHours.Clear();
                    cmbDepartment.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
        }
    }
    }

