using Microsoft.Data.SqlClient;

namespace RegistrationSys
{
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmDelete_Click(object sender, EventArgs e)
        {
            // Connection chain. It gives access to local DB. You must create one within your project.
            string ofConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\publicProjectsCS\RegistrationSys\localDB.mdf;Integrated Security=True";
            // SQL commands
            string ofCommand = "DELETE FROM RegisterCodes WHERE Code=@Code";
            SqlConnection? connection = null;

            try
            {
                connection = new SqlConnection(ofConnect);
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(ofCommand, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@Code", textBoxRegCode.Text.Trim());
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("User successfully deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An inesperate error has occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
