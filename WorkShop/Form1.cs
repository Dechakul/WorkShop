using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WorkShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnect.connectNorthwind();

            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Connected to Northwind database Successfully!");
            }

            conn.Close();
        }

        internal class DBConnect
        {
            public static SqlConnection connectNorthwind()
            {
                string server = "DESKTOP-PUILJ9S\\SQLEXPRESS"; //la server
                string db = "Northwind"; //lao northwind aйlu MS SQL Sever
                                         //คําสั่งในการเชื่อมต่อ Connection string เก็บไว้ในตัวแปร strCon
                string strCon = string.Format(@"Data source={0}; Initial Catalog={1}; Integrated Security=True; Encrypt= False;", server, db);
                // ประกาศตัวแปร Object ของคลาส SqlConnection เพื่อเชื่อมต่อกับ DB
                SqlConnection conn = new SqlConnection(strCon);
                conn.Open();

                return conn;
            }

            public static SqlConnection connectDBExample()
            {
                string server = "DESKTOP-PUILJ9S\\SQLEXPRESS";//server ¢Í§µÑÇàÍ§
                string db = "DBExample";

                string strCon = string.Format(@"Data source={0}; Initial Catalog={1}; Integrated Security=True; Encrypt= False;", server, db);

                SqlConnection conn = new SqlConnection(strCon);
                conn.Open();

                return conn;
            }
        }
    }
}
