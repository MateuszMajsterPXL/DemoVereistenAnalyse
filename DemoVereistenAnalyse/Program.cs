namespace DemoVereistenAnalyse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string user = "Admin", password = "P@sswoord123";
            int tries = 0;

            while (tries < 3)
            {
                Console.Write("Gebruikersnaam: ");
                string inputUser = Console.ReadLine();
                Console.Write("Wachtwoord: ");
                string inputPassword = Console.ReadLine();

                if (inputUser == user && inputPassword == password)

                tries++;
                Console.WriteLine($"Foutieve login. \n{3 - tries} pogingen over. ");
            }
            Console.WriteLine("Te veel pogingen. Toegang geweigerd.");

        }
    }
}
