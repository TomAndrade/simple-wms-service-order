
namespace RegistrationSys
{
#pragma warning disable CS8618 // Conversão de literal nula ou possível valor nulo em tipo não anulável


    internal class User
    {
        public enum Departments
        {
            /*
            Expedition
            Customs warehouse
            Management
            Temporary access
            */
            EXPEDITION = 0,
            CUSTOMS_WAREHOUSE = 1,
            MANAGEMENT = 2,
            TEMPORARY_ACCESS = 3
        }

        public static Random randomNum = new Random();
        readonly string alphabet = "abcdefghijklmnopqrstuvwxyz";
        DateTime randomDatetime = new DateTime(randomNum.Next(2026,2099), randomNum.Next(1,12), randomNum.Next(1,28));

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Department {  get; set; }
        public DateTime Expires { get; set; }
        public string Code { get; set; }

        public static void autoGenerate()
        {

        }
    }
}
