using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace RegistrationSys
{
#pragma warning disable CS8601 // Possível atribuição de referência nula.
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável
    public partial class Form1 : Form
    {
        bool isSaved;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            dateTimeVality.MinDate = DateTime.Now;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (!isSaved)
            {
                result = MessageBox.Show("There are unsaved chages. Are you sure want to exit?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes) this.Close();
            }

            result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Shows pass", buttonShowPass);
        }

        private void buttonShowPass_Click(object sender, EventArgs e)
        {
            if (textBoxNewPass.PasswordChar == '*' && textBoxConfirmPass.PasswordChar == '*')
            {
                textBoxNewPass.PasswordChar = '\0';
                textBoxConfirmPass.PasswordChar = '\0';
            }
            else
            {
                textBoxNewPass.PasswordChar = '*';
                textBoxConfirmPass.PasswordChar = '*';
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (textBoxConfirmPass.Text != textBoxNewPass.Text)
            {
                MessageBox.Show("Both Password and Confirm Pass fields must be identical.");
                textBoxNewPass.Focus();
                return;
            }
            if (textBoxNewPass.Text.Length <= 3)
            {
                MessageBox.Show("Password: min 4 chars");
                textBoxNewPass.Focus();
                return;
            }

            Random random = new();
            int regNum = random.Next(1, 99999);
            StringBuilder regCode = new StringBuilder();

            switch (comboBoxDepartment.SelectedIndex)
            {
                case 0:
                    regCode.Append("EXP0");
                    break;
                case 1:
                    regCode.Append("CUSTOMS0");
                    break;
                case 2:
                    regCode.Append("MGMT0");
                    break;
                case 3:
                    regCode.Append("TEMP0");
                    break;
                default: MessageBox.Show("No departments"); break;
            }
            regCode.Append(regNum);
            // Connection chain. It gives access to local DB. You must create one within your project.
            string ofConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\publicProjectsCS\RegistrationSys\localDB.mdf;Integrated Security=True";
            // SQL commands
            string ofCommand = "INSERT INTO RegisterCodes (Name, Surname, Username, Password, Department, RegistrationDate, Expires, Code) VALUES (@Name, @Surname, @Username, @Password, @Department, @RegistrationDate, @Expires, @Code)";
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(ofConnect);
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(ofCommand, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@Name", textBoxName.Text);
                    sqlCommand.Parameters.AddWithValue("@Surname", textBoxSurname.Text);
                    sqlCommand.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                    sqlCommand.Parameters.AddWithValue("@Password", textBoxNewPass.Text);
                    sqlCommand.Parameters.AddWithValue("@Department", comboBoxDepartment.SelectedItem);
                    sqlCommand.Parameters.AddWithValue("@Expires", dateTimeVality.Value);
                    sqlCommand.Parameters.AddWithValue("@Code", regCode.ToString().Trim());
                    sqlCommand.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("User successfully registered.");
                groupBoxRegistration.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An inesperate error has occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //labelRegDateStamp.Text = DateTime.Now.ToString("d");
            //labelShowRegNumber.Text = regNum.ToString();

            if (connection != null)
            {
                isSaved = true;
                connection.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            labelVality.Text = dateTimeVality.Text.ToString();
        }

        private void buttonValidateEmpCode_Click(object sender, EventArgs e)
        {
            textBoxEmpCode.Text.Trim();

            if (textBoxEmpCode.Text.First() == 'A')
            {
                comboBoxDepartment.SelectedIndex = 3;
            }

            // Use a file reader to validate:
            string reader = File.ReadAllText(@"D:\GitHub\publicProjectsCS\EmployeeMaker\bin\Debug\employees.txt");

            if (reader.Contains(textBoxEmpCode.Text))
            {
                groupBoxRegistration.Enabled = true;
                buttonAddUser.Enabled = true;
                isSaved = false;
                
            }
            else
            {
                MessageBox.Show("Employee not exist or invalid.");
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            Form deleteUser = new Form();
            DeleteUserForm confirmDelete = new DeleteUserForm();
            confirmDelete.ShowDialog();
        }

        private void textBoxEmpCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonDeleteUser.Enabled = true;
                groupBoxRegistration.Enabled = true;
            }
        }

        private void buttonFindUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            DateTime regDate = new DateTime();

            textBoxFindUser.Text.Trim();
            string ofCommand = "";
            string ofConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\publicProjectsCS\RegistrationSys\localDB.mdf;Integrated Security=True";

            ofCommand = "SELECT * FROM RegisterCodes WHERE Username=@Username";

            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(ofConnect);
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(ofCommand, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@Username", textBoxFindUser.Text);

                    SqlDataReader reader = sqlCommand.ExecuteReader();      // Verifies if user exists

                    if (reader.Read())
                    {
                        user.Name = reader["Name"].ToString();
                        user.Surname = reader["Surname"].ToString();
                        user.Department = reader["Department"].ToString();
                        regDate = (DateTime)reader["RegistrationDate"];
                        user.Expires = (DateTime)reader["Expires"];
                        user.Code = reader["Code"].ToString();
                    }

                    labelShowName.Text = user.Name;
                    labelShowSurname.Text = user.Surname;
                    labelShowRegNumber.Text = user.Code;
                    labelRegDateStamp.Text = regDate.ToString("d");
                    labelShowExpires.Text = user.Expires.ToString("d");
                    labelShowDepartment.Text = user.Department;
                }
                groupBoxRegistration.Enabled = true;
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
