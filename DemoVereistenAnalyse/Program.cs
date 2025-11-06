namespace DemoVereistenAnalyse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string user = "Admin", password = "P@sswoord123";
            int tries = 0;

            Console.Write("Gebruikersnaam: ");
            string inputUser = Console.ReadLine();
            Console.Write("Wachtwoord: ");
            string inputPassword = Console.ReadLine();

            if (inputUser == user && inputPassword == password) { }
        }
    }
}
