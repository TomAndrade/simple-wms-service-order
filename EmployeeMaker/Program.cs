using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EmployeeMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string alphabet = "ACMOS";
            List<string> employees = new List<string>();
            StreamWriter writer = new StreamWriter("employees.txt");
            StringBuilder employee = new StringBuilder();

            for (int i = 0; i < 50; i++)
            {
                employee.Append(alphabet[random.Next(alphabet.Length)]);
                employee.Append(i+random.Next(100000,999999));
                employees.Add(employee.ToString());
                employee.Clear();
            }
            // Connection chain. It gives access to local DB. You must create one within your project.
            string ofConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\publicProjectsCS\RegistrationSys\localDB.mdf;Integrated Security=True";

            foreach (var employ in employees)
            {
                writer.WriteLine(employ);
            }
            writer.Close();
        }
    }
}
