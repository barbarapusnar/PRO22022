using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PovezanDostop
{
    public partial class Form1 : Form
    {
        string povezava = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PRO22022\northwnd.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "SELECT * FROM EMPLOYEES";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            p.Open();
            SqlDataReader bralec = u.ExecuteReader();
            while (bralec.Read())
            {
                string r = bralec["TitleOfCourtesy"] + " " 
                           + bralec["FirstName"] 
                           + " " + bralec["LastName"];
                listBox1.Items.Add(r);
            }
            bralec.Close();
            p.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "SELECT * FROM EMPLOYEES WHERE City=@City";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;

            SqlParameter par = new SqlParameter("@City", SqlDbType.NVarChar);
            u.Parameters.Add(par);
            par.Value = textBox1.Text;

            p.Open();
            SqlDataReader bralec = u.ExecuteReader();
            
            while (bralec.Read())
            {
                string r = bralec["TitleOfCourtesy"] + " "
                           + bralec["FirstName"]
                           + " " + bralec["LastName"];
                listBox1.Items.Add(r);
            }
            bralec.Close();
            p.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "SELECT SUM(UnitPrice*Quantity) FROM [Order Details]";
            SqlCommand u = new SqlCommand(ukaz, p);
            p.Open();
            double rezultat = double.Parse(u.ExecuteScalar().ToString());
            listBox1.Items.Clear();
            listBox1.Items.Add("Vsota je " + rezultat);
            p.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "UPDATE EMPLOYEES SET REGION='X' WHERE REGION IS NULL";
            SqlCommand u = new SqlCommand(ukaz, p);
            p.Open();
            int štVrstic = u.ExecuteNonQuery();
            listBox1.Items.Clear();
            listBox1.Items.Add("Posodbljeno "+štVrstic);
            p.Close();
        }
    }
}
