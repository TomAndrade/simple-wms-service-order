using Microsoft.Data.SqlClient;

namespace Gatekeeper
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            buttonLogin.Enabled = false;
            textBoxUserName.Focus();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
            {
                MessageBox.Show("Please insert a username.", "Username is blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Please insert a password.", "Password is blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\GitHub\publicProjectsCS\simple-wms\RegistrationSys\localDB.mdf; Integrated Security=True";
            string command = "SELECT Username, Password FROM RegisterCodes WHERE Username=@Username AND Password=@Password";
            SqlConnection? conn = null;

            try
            {
                conn = new SqlConnection(connection);
                conn.Open();

                SqlCommand sqlCommand = new(command,conn);
                sqlCommand.Parameters.AddWithValue("@Username", textBoxUserName.Text);
                sqlCommand.Parameters.AddWithValue("@Password", textBoxPassword.Text);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    textBoxUserName.Enabled = false;
                    textBoxPassword.Enabled = false;
                    buttonLogin.Enabled = false;
                    buttonLogin.Text = "Connected";
                    Thread.Sleep(1000);
                    this.Hide();
                    FormMainWindow mainWindow = new FormMainWindow();
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Username not exist or invalid.");
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "")
            {
                buttonLogin.Enabled = false;

            }
            else
            {
                buttonLogin.Enabled = true;

            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "" || textBoxUserName.Text == "")
            {
                buttonLogin.Enabled = false;

            }
            else
            {
                buttonLogin.Enabled = true;

            }
        }
    }
}
