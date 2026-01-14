# Simple WMS - Service Order
A simple Warehouse Manager System for tests.<br>
_Before continuing, be sure to enter the current (or online) database in the connection field (`string connection`)._
_DISCLAIMER: ALL INFORMATION STORED IN THE DATABASE OR PROGRAM IS FALSE AND EXISTS ONLY FOR TESTING PURPOSES._

>Status: updating ♻️<br>
>Version: 1.0<br>
>Date released: 01/14/2026

**ABOUT EMPLOYEE MAKER**
---------------------------------------------------------------------------------------------------
**_Currently incomplete and unused._**

**ABOUT REGISTRATION SYSTEM**
---------------------------------------------------------------------------------------------------
<img width="822" height="382" alt="{468B5CC2-B027-43F3-BD71-8B5EBD8893D2}" src="https://github.com/user-attachments/assets/cd605cdd-43a6-45cf-8ced-1cdd44839331" />

## What does it do? - Purpose
Use this application to register, search for, and delete users from the system.

## Content
Save user to db button - it shows a MessageBox when adds him;<br>
Delete user button - it removes a user using a registration code.;<br>
Find user button - it finds a user using a reg code;<br>
Contains a clock (timer).<br>

## How does it work? - Behavior
When the user clicks the "validate" button, the system performs a brief search in a file called `employees.txt.` - which can be found inside the EmployeeMaker folder.<br>
When validated, the `groupBoxRegistration` control is activated so that all fields can be filled in.<br>
The "Find" and "Delete" buttons only work when there are records in the database.
* _You can use "find" window instead of the button._

**ABOUT LOGIN WINDOW - IMPORTANT**
---------------------------------------------------------------------------------------------------
<img width="353" height="311" alt="{E4C7BCF6-96B0-488A-8FE3-47D5F6D462F1}" src="https://github.com/user-attachments/assets/26d32f35-3abf-4498-b8be-9eceddc9bede" />

## What does it do? - Purpose
A standard gatekeeper to secure database records.

## How does it work? - Behavior
When a valid user clicks "Login", the system performs a quick search in the database for validation. There is a deliberate 1-second delay (`Thread.Sleep(1000)`) to simulate this search.<br>
**Remember that the main window will only open once validation has occurred in the gatekeeper.**

**ABOUT MAIN WINDOW**
---------------------------------------------------------------------------------------------------
<img width="1392" height="743" alt="{1125F54B-FDAD-4EC4-9570-69D410D7A97F}" src="https://github.com/user-attachments/assets/ecebf66d-a941-4a5b-88c6-a586042b0256" />

## What does it do? - Purpose
Allows you to register and complete tasks or work orders with persistence.<br>
There's not much to say here. He does what he sets out to do. Obviously the program needs optimization, but I don't intend to make any further changes, as most of the process involves constraints. Feel free to make any necessary modifications.

## Restrictions
* When an order is initiated, the entire groupBox is reset.
* The "Service Number" is generated based on an automatic query that is performed when the program starts using the ShowTable() method. Once the program loads, the dataGridView is populated with the collected data.:

      public void ShowTable()
      {
          SqlConnection conn = new(your_db_here);
          
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

*  The program finishes the registration based on the data displayed in the dataGridView. Therefore, ensure that this section of code is immutable:

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int serviceNum = Convert.ToInt32(row.Cells["ServiceNum"].Value);
            string? status = row.Cells["Status"].Value.ToString().Trim();
            
            if (status != ClassSO.ServiceStatus.IN_PROGRESS.ToString().Trim())
            {
                MessageBox.Show("The selected status isn't in progress.\n"+status); return;
            }

* Status is a property of type enum, as shown below. This part is very important because it's where the system validates whether an order can be completed or not, unless you want to use another method to store the information:

        public ServiceStatus Status {  get; set; }
  
        public enum ServiceStatus
        {
            OPEN,
            IN_PROGRESS,
            FINISHED
        }

## What was used? - Resources - ALL THEM
* Microsoft.Data.SqlClient<br>

GUI          | .NET  | SQL | Web
------------ | ----- | --- | ---
Windows Forms| v.8.0 | Local  | No
