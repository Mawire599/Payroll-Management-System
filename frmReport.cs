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
    public partial class frmReport : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=PayrollDB;Integrated Security=True;TrustServerCertificate=True");

        private void LoadReports()
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT EmployeeID, FullName, Department, GrossPay, Tax, NetPay FROM Employees", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvReports.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void LoadDepartments()
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT DISTINCT Department FROM Employees", con);

                SqlDataReader dr = cmd.ExecuteReader();

                cmbDepartment.Items.Clear();

                while (dr.Read())
                {
                    cmbDepartment.Items.Add(dr["Department"].ToString());
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
        public frmReport()
        {
            InitializeComponent();
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadReports();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT EmployeeID, FullName, Department, GrossPay, Tax, NetPay " +
                    "FROM Employees WHERE Department = @Department", con);

                da.SelectCommand.Parameters.AddWithValue("@Department",
                    cmbDepartment.Text);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReports.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font headerFont = new Font("Arial", 11, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 10);

            int y = 40;

            //Title
            e.Graphics.DrawString("PAYROLL REPORT", titleFont, Brushes.Black, 250, y);
            y += 50;

            //Headers
            e.Graphics.DrawString("Employee ID", headerFont, Brushes.Black, 20, y);
            e.Graphics.DrawString("Full Name", headerFont, Brushes.Black, 140, y);
            e.Graphics.DrawString("Department", headerFont, Brushes.Black, 340, y);
            e.Graphics.DrawString("Net Pay", headerFont, Brushes.Black, 520, y);

            y += 30;

            // Print DataGridView rows
            foreach (DataGridViewRow row in dgvReports.Rows)
            {
                if (!row.IsNewRow)
                {
                    e.Graphics.DrawString(row.Cells["EmployeeID"].Value.ToString(), bodyFont, Brushes.Black, 20, y);
                    e.Graphics.DrawString(row.Cells["FullName"].Value.ToString(), bodyFont, Brushes.Black, 140, y);
                    e.Graphics.DrawString(row.Cells["Department"].Value.ToString(), bodyFont, Brushes.Black, 340, y);
                    e.Graphics.DrawString("R" + row.Cells["NetPay"].Value.ToString(), bodyFont, Brushes.Black, 520, y);

                    y += 25;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    } // 
}
