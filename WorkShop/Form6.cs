using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static WorkShop.Form1;

namespace WorkShop
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public void showCountry()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sql = String.Format("Select Distinct Shipcountry From Orders Order By ShipCountry ASC");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboCountry.DataSource = dt;
            cboCountry.DisplayMember = "ShipCountry";
            cboCountry.ValueMember = "ShipCountry";
            conn.Close();
        }

        public void showYear()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sql = String.Format("Select Distinct YEAR(OrderDate) AS YearOeder From Orders Order By YEAR(OrderDate) ASC");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboYear.DataSource = dt;
            cboYear.DisplayMember = "YearOeder";
            cboYear.ValueMember = "YearOeder";
            conn.Close();
        }

        public void showOrder()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sql = String.Format("Select * From Temp_Order_View");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvOrder.DataSource = dt;
            conn.Close();
        }

        public void showOrder(String country, int Year)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sql = String.Format("Select * From Temp_Order_View Where Shipcountry = '{0}' AND YEAR(OrderDate) = '{1}';", country, Year);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvOrder.DataSource = dt;
            conn.Close();
        }

        public void showOrderDetail(int orderID)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sql = String.Format("Select * from Details_view where orderID = {0}", orderID);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvorderDetail.DataSource = dt;
            conn.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            showCountry();
            showYear();
            showOrder();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            string country = cboCountry.SelectedValue.ToString();
            int Year = Convert.ToInt32(cboYear.SelectedValue);
            showOrder(country, Year);
        }

        private void dgvOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            int orderID = Convert.ToInt32(dgvOrder.Rows[row].Cells[0].Value);
            showOrderDetail(orderID);
        }
    }
}
