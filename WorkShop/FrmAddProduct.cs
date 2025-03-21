﻿using System;
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
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }

        public void insertNewProduct()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            SqlCommand cmd = new SqlCommand("insertNewProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pname", txtPname.Text);

            // ตรวจสอบและแปลงค่า txtPrice.Text เป็น decimal ก่อน
            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("กรุณากรอกราคาที่ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmd.Parameters.Add("@price", SqlDbType.Money).Value = price;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void showProduct()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sql = "Select * From Temp_Product";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProduct.DataSource = dt;
            conn.Close();
            formatdgv();
        }
        public void clearForm()
        {
            txtPname.Clear();
            txtPrice.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            insertNewProduct();
            showProduct();
            clearForm();
            formatdgv();
        }
        public void formatdgv()
        {
            dgvProduct.Columns[2].DefaultCellStyle.Format = "#,##0.00";
            dgvProduct.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvProduct.Columns[0].HeaderText = "รหัสสินค้า";
            dgvProduct.Columns[1].HeaderText = "ชื่อสินค้า";
            dgvProduct.Columns[2].HeaderText = "ราคาต่อหน่วย";
        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            showProduct();
            formatdgv();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
