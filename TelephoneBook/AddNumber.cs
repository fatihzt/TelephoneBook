using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneBook
{
    public partial class AddNumber : Form
    {
        private int Id;
        private bool forupdate;
        public AddNumber()
        {
            InitializeComponent();
        }
        public AddNumber(int id)
        {
            InitializeComponent();
            Id = id;
            forupdate = true;
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand(cmdText: "select top 1 [Id],[Name],[Surname],[Number] from Table1 where Id= @id", sqlConnection);
            cmd.Parameters.AddWithValue(parameterName: "@id", Id);
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    AddName.Text = sqlDataReader.GetString(i:1);
                    AddNumberSurname.Text = sqlDataReader.GetString(i:2);
                    AddNumberMask.Text = sqlDataReader.GetString(i:3);
                }

            }
            catch (Exception ex )
            {

                MessageBox.Show(text: "Cant take TelephoneNumber!" + Environment.NewLine + ex.Message, caption: "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
           
        }
        private void AddNumberSave_Click(object sender, EventArgs e)
        {
            int value = -1;

            string Connection = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(Connection);
            SqlCommand sqlCommand;
            if (forupdate)
            {
                sqlCommand = new SqlCommand(cmdText: "UPDATE Table1 SET Name = @n, Surname = @s,Number=@nm Where Id=@id", sqlConnection);
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Id;
               
                //sqlCommand.Parameters.AddWithValue(parameterName: "@id", Id);


                //sqlCommand = new SqlCommand(cmdText: "update Table1 set Name=@n,Surname=@s,Number=@nm where Id=@id", sqlConnection);
            }
            else
            {
                sqlCommand = new SqlCommand(cmdText: "insert into Table1([Name],[Surname],[Number]) values( @n, @s, @nm)", sqlConnection);
                sqlCommand.Parameters.AddWithValue(parameterName: "@id", Id);
            }



            sqlCommand.Parameters.AddWithValue(parameterName:"@n",AddName.Text);
            sqlCommand.Parameters.AddWithValue(parameterName: "s", AddNumberSurname.Text);
            sqlCommand.Parameters.AddWithValue(parameterName: "nm", AddNumberMask.Text);
            try
            {
                sqlConnection.Open();
                value = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(text: "Connection Error!"+Environment.NewLine+ex.Message, caption: "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
            if (value > 0)
            {
                MessageBox.Show(text: "added telephone number.", caption: "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show(text: "cant add telephone number.", caption: "error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
