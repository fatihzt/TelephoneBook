using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNumber addNumber = new AddNumber();
            addNumber.ShowDialog();
            TakeTelephoneNumber();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TakeTelephoneNumber();
        }
        void TakeTelephoneNumber()
        {
            string sql = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand(cmdText: "select [Id],[Name],[Surname],[Number] from Table1", sqlConn);

            try
            {
                sqlConn.Open();
                SqlDataReader sqlDataReader= cmd.ExecuteReader();
                dataGridViewNumbers.Rows.Clear();
                while (sqlDataReader.Read())
                {
                    dataGridViewNumbers.Rows.Add( sqlDataReader.GetInt32(i:0), sqlDataReader.GetString(i:1), sqlDataReader.GetString(i: 2), sqlDataReader.GetString(i: 3));

                }
            }
            catch (Exception)
            {
                MessageBox.Show("number cant taken!",caption:"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlConn.State != ConnectionState.Closed)
                {
                    sqlConn.Close();
                }

                }
            }

        private void removeNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int var = -1;
            if (dataGridViewNumbers.SelectedRows.Count ==0)
            {
                return;
            }
            object value = dataGridViewNumbers.SelectedRows[0].Cells[0].Value;
            int id=(int)value;
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand(cmdText:"delete Table1 where Id =@id", sqlConnection);
            cmd.Parameters.AddWithValue(parameterName: "@id", id);
            try
            {
                sqlConnection.Open();
                var = cmd.ExecuteNonQuery();
                MessageBox.Show(text: $"Telephone number {(var >0 ? "deleted" : "cant deleted")}", caption: var > 0 ? "Information" : "Error", MessageBoxButtons.OK, var > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error!");
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
            if (var > 0)
            {
                TakeTelephoneNumber();
            }

             

        }

        private void upateNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridViewNumbers.SelectedRows.Count == 0)
            {
                return;
            }
            object value = dataGridViewNumbers.SelectedRows[0].Cells[0].Value;
            int id = (int)value;
            AddNumber addNumber = new AddNumber(id);
            addNumber.ShowDialog();
            TakeTelephoneNumber();
        }
    }
    }

