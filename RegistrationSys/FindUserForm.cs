using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace RegistrationSys
{
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável
    public partial class FindUserForm : Form
    {
        public FindUserForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFindUser.Enabled = true;
            buttonFind.Enabled = true;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            textBoxFindUser.Text.Trim();
            string column = "";
            string ofCommand = "";
            // Connection chain. It gives access to local DB. You must create one within your project.
            string ofConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\publicProjectsCS\RegistrationSys\localDB.mdf;Integrated Security=True";
            // SQL commands
            if (comboBoxFindBy.SelectedIndex == 0)
            {
                column = "@Username";
                ofCommand = $"SELECT * FROM RegisterCodes WHERE Username='{column}'";
            }else if (comboBoxFindBy.SelectedIndex == 1)
            {
                column = "@Code";
                ofCommand = $"SELECT * FROM RegisterCodes WHERE Code='{column}'";
            }

            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(ofConnect);
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(ofCommand, connection))
                {
                    if (sqlCommand.Parameters.Count > 0)
                    {
                        //sqlCommand.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                        sqlCommand.Parameters.AddWithValue(column, textBoxFindUser.Text.ToString());
                        sqlCommand.ExecuteNonQuery();

                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        if (reader.Read())
                        {
                            string isExist = reader["Username"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Isn't possible find it. ");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An inesperate error has occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null)
                {
                    //MessageBox.Show("User successfully deleted.");
                    connection.Close();
                }
            }
        }
    }
}
