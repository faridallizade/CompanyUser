

namespace Company_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            bool exit = false;
            do
            {

                Console.WriteLine("   ---------------MENU---------------");
                Console.WriteLine("   |1. Register a user (to company)  |");
                Console.WriteLine("   |2. Login a user (to company)     |");
                Console.WriteLine("   |3. See all users in a company    |");
                Console.WriteLine("   |4. Get one user by username      |");
                Console.WriteLine("   |5. Update user's data            |");
                Console.WriteLine("   |   a. Update name                |");
                Console.WriteLine("   |   b. Update surname             |");
                Console.WriteLine("   |   c. Update username            |");
                Console.WriteLine("   |   d. Update email               |");
                Console.WriteLine("   |6. Delete user from company      |");
                Console.WriteLine("   |7. Exit                          |");
                Console.WriteLine("   ----------------------------------\n\n");
                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the name : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the surname : ");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Enter the password : ");
                        string password = Console.ReadLine();
                        company.Register(name, surname, password);
                        Console.WriteLine("User registered succesfully.\n");
                        string Email = $"{name}.{surname}@gmail.com";
                        string Username = $"{name}.{surname}";
                        Console.WriteLine(Email + "\n" + Username);
                        break;
                    case "2":
                        Console.WriteLine("Enter the username : ");
                        string loginUsername = Console.ReadLine();
                        Console.WriteLine("Enter the password : ");
                        string loginPassword = Console.ReadLine();
                        company.Login(loginUsername, loginPassword);

                        break;
                    case "3":
                        company.GetAll();
                        break;
                    case "4":
                        Console.WriteLine("Enter the username : ");
                        string enteredUsername = Console.ReadLine();
                        company.GetByUsername(enteredUsername);
                        break;
                    case "5":
                        Console.WriteLine("Enter the username : ");
                        string updateUsername = Console.ReadLine();
                        Console.WriteLine("    Choose what to update : ");
                        Console.WriteLine("    | a. Update name         |");
                        Console.WriteLine("    | b. Update surname      |");
                        Console.WriteLine("    | c. Update username     |");
                        Console.WriteLine("    | d. Update email        |");
                        Console.WriteLine("Enter your choise : ");
                        string choise = Console.ReadLine();
                        company.UpdateByUsername(updateUsername);
                        break;
                    case "6":
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choise. Please choose just between 1-8");
                        break;
                }

            } while (!exit);
        }
    }
}