using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sql
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LeandroDuran;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into table1 values('"+NametextBox1.Text+"','"+CiudadtextBox2.Text+"')";

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registro insertado correctamente");
            NametextBox1.Text = "";
            CiudadtextBox2.Text = "";

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from table1 where Nombre ='" + NametextBox1.Text + "','" + CiudadtextBox2.Text + "')";

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro eliminado correctamente");
                NametextBox1.Text = "";
                CiudadtextBox2.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error...");
            }
        }
    }
}
