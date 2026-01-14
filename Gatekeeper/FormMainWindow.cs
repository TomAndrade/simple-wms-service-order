using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Gatekeeper
{
    public partial class FormMainWindow : Form
    {
        ClassSO order = new();
        List<ClassSO> orderList = [];
        int newOrder = 0;
        public FormMainWindow()
        {
            InitializeComponent();
            dateTimePickerDeadline.MinDate = DateTime.Now;
            ShowTable();
        }

        public void ResetAll()
        {
            newOrderToolStripMenuItem.Enabled = true;
            groupBoxMain.Enabled = false;
            labelStatus.Text = "N/A";
            labelSORegNum.Text = "-";
            labelOpenedText.Text = "-";
            textBoxRespTech.Text = null;
            comboBoxDepartment.SelectedItem = null;
            comboBoxPriority.SelectedItem = null;
            labelExpCompletionDate.Text = null;
            richTextBoxDescription.Text = "Insert a description";
        }

        public void ShowTable()
        {
            SqlConnection conn = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\publicProjectsCS\simple-wms\Gatekeeper\OS-Main-DB.mdf;Integrated Security=True");

            try
            {
                conn.Open();
                string command = "SELECT * FROM ServiceOrders";
                SqlDataAdapter adapter = new SqlDataAdapter(command, conn);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn?.Close();
            }
        }

        //close through from menu
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //close through from window
        private void FormMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else e.Cancel = true;
        }
        // new order
        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxMain.Enabled = true;
            labelStatus.Text = "Open";
            //string readWriteOrder = File.ReadAllText(@"D:\GitHub\publicProjectsCS\SimpleWMS\Gatekeeper\orders.txt");
            //newOrder = int.Parse(readWriteOrder);
            newOrderToolStripMenuItem.Enabled = false;
            labelOpenedText.Text = DateTime.Now.ToString();
            order.ServiceNum = newOrder;
            order.Status = ClassSO.ServiceStatus.OPEN;

            SqlConnection conn = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\publicProjectsCS\simple-wms\Gatekeeper\OS-Main-DB.mdf;Integrated Security=True");
            string command = "SELECT COUNT(*) FROM ServiceOrders";

            try
            {
                conn.Open();
                using SqlCommand cmd = new(command, conn);
                newOrder = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                labelSORegNum.Text = newOrder.ToString("D4");

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn?.Close();
            }
        }
        // add order
        #region MAIN
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (richTextBoxDescription.Text.Equals("Insert a description") || richTextBoxDescription.Text is null)
            {
                MessageBox.Show("Please insert a valid description!");
                return;
            }
            else if (textBoxRespTech.Text is null)
            {
                MessageBox.Show("Please insert a responsible technician!");
                return;

            }
            else if (comboBoxDepartment is null)
            {
                MessageBox.Show("Please choose a department!"); return;

            }
            else if (comboBoxPriority is null)
            {
                MessageBox.Show("Please choose a priority!"); return;

            }
            else if (dateTimePickerDeadline is null)
            {
                MessageBox.Show("Please choose a deadline!"); return;

            }

            order.Description = richTextBoxDescription.Text.Trim();
            order.ResponsibleTech = textBoxRespTech.Text.Trim();
            order.Department = comboBoxDepartment.Text.Trim();
            order.OpenedDate = DateTime.Parse(labelOpenedText.Text);
            order.Status = ClassSO.ServiceStatus.IN_PROGRESS;
            order.Term = DateTime.Parse(dateTimePickerDeadline.Text);

            switch (comboBoxPriority.SelectedIndex)
            {
                case 0: order.Prior = ClassSO.Priority.VERY_HIGH; break;
                case 1: order.Prior = ClassSO.Priority.HIGH; break;
                case 2: order.Prior = ClassSO.Priority.MEDIUM; break;
                case 3: order.Prior = ClassSO.Priority.LOW; break;
                case 4: order.Prior = ClassSO.Priority.VERY_LOW; break;
            }

            orderList.Add(order);

            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\publicProjectsCS\simple-wms\Gatekeeper\OS-Main-DB.mdf;Integrated Security=True";
            string command = "INSERT INTO ServiceOrders (Description, ResponsibleTechnician, Department, Priority, OpenedDate, Status, Term) VALUES (@Description, @ResponsibleTechnician, @Department, @Priority, @OpenedDate, @Status, @Term)";

            SqlConnection? conn = new(connection);

            try
            {
                conn.Open();
                SqlCommand cmd = new(command, conn);

                //cmd.Parameters.AddWithValue("@ServiceNum", labelSORegNum.Text);
                cmd.Parameters.AddWithValue("@Description", order.Description);
                cmd.Parameters.AddWithValue("@ResponsibleTechnician", order.ResponsibleTech);
                cmd.Parameters.AddWithValue("@Department", order.Department);
                cmd.Parameters.AddWithValue("@Priority", order.Prior.ToString().Trim());
                cmd.Parameters.AddWithValue("@OpenedDate", order.OpenedDate);
                cmd.Parameters.AddWithValue("@Status", order.Status.ToString().Trim());
                cmd.Parameters.AddWithValue("@Term", order.Term);

                cmd.ExecuteNonQuery();

                MessageBox.Show("A new order has been started.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //File.WriteAllText(@"D:\GitHub\publicProjectsCS\SimpleWMS\Gatekeeper\orders.txt", newOrder.ToString());

                ResetAll();

                try
                {
                    command = "SELECT * FROM ServiceOrders";
                    SqlDataAdapter adapter = new SqlDataAdapter(command, conn);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    buttonRefreshList.Enabled = true;
                    //buttonFinishOrder.Enabled = true;
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("An error has occurred: " + ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn?.Close();
            }

        }
        #endregion
        //Reset
        private void buttonResetOrder_Click(object sender, EventArgs e)
        {
            DialogResult reset = MessageBox.Show("Are you sure? This will cancel the current order.", "Reset order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reset == DialogResult.Yes)
            {
                newOrder--;
                orderList.Remove(order);
                ResetAll();
            }
        }
        //Refresh
        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            ShowTable();
        }
        //Finish
        private void buttonFinishOrder_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\publicProjectsCS\simple-wms\Gatekeeper\OS-Main-DB.mdf;Integrated Security=True");
            string command = "UPDATE ServiceOrders SET Status=@Status, FinishedDate=@FinishedDate WHERE ServiceNum = @ServiceNum";

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to finish it."); return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int serviceNum = Convert.ToInt32(row.Cells["ServiceNum"].Value);
            string? status = row.Cells["Status"].Value.ToString().Trim();
            
            if (status != ClassSO.ServiceStatus.IN_PROGRESS.ToString().Trim())
            {
                MessageBox.Show("The selected status isn't in progress.\n"+status); return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new(command, conn);

                cmd.Parameters.AddWithValue("@Status", ClassSO.ServiceStatus.FINISHED.ToString());
                cmd.Parameters.AddWithValue("@FinishedDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@ServiceNum", serviceNum);
                cmd.ExecuteNonQuery();

                MessageBox.Show("The current order has been finished.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn?.Close();
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                buttonFinishOrder.Enabled = true;
            }
            else
            {
                buttonFinishOrder.Enabled = false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}
