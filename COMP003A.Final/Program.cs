using System.Net.NetworkInformation;

namespace COMP003A.Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<GymMemberEnroll> records = new List<GymMemberEnroll>();

            SeedDemoRecords(records);

            bool running = true;

            do
            {
                DisplayMenu();

                int choice = ReadMenuChoice();

                switch (choice)
                {
                    case 1:
                        AddNewRecord(records);
                        break;

                    case 2:
                        ViewAllRecords(records);
                        break;

                    case 3:
                        SearchRecords(records);
                        break;

                    case 4:
                        ViewStatistics(records);
                        break;

                    case 5:
                        running = false;
                        Console.WriteLine("Bye!");
                        break;

                }
            } while (running);
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n Gym Membership Enrollment Intake");
            Console.WriteLine("1. Add New Record");
            Console.WriteLine("2. View All Records");
            Console.WriteLine("3. Search Records");
            Console.WriteLine("4. View Statistics");
            Console.WriteLine("5. Exit");
            Console.Write("Enter Choice (1-5): ");
        }

        static int ReadMenuChoice()
        {
            while (true)
            {
                string input = Console.ReadLine();

                try
                {
                    int choice = int.Parse(input);

                    if (choice >= 1 && choice <= 5)
                    {
                        return choice;
                    }

                    Console.Write("Invalid selection. Enter 1-5: ");
                }
                catch (FormatException)
                {
                    Console.Write("Invalid input. Enter a number 1-5:");
                }
            }
        }

        static string ReadNonEmpty(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }

                Console.WriteLine("Input Cannot be empty");
            }
        }

        static bool ReadYesNo(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "y" || input == "yes") return true;
                if (input == "n" || input == "no") return false;

                Console.WriteLine("enter Y/Yes or N/No");
            }
        }

        static int ReadInt(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                try
                {
                    int value = int.Parse(input);

                    if (value >= min && value <= max)
                    {
                        return value;
                    }

                    Console.WriteLine($"Enter a value betwwem {min} and {max}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid whole number entered.");
                }
            }
        }

        static double ReadDouble(string prompt, double min, double max)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                try
                {
                    double value = double.Parse(input);
                    if (value >= min && value <= max)
                    {
                        return value;
                    }

                    Console.WriteLine($"Enter a value between {min} and {max}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number entered");
                }
            }
        }

        static void AddNewRecord(List<GymMemberEnroll> records)
        {
            Console.WriteLine("\n Add New Gym Member Record ");

            string firstName = ReadNonEmpty("First Name: ");
            string lastName = ReadNonEmpty("Last Name: ");
            string phoneNumber = ReadNonEmpty("Phone Number: ");
            string email = ReadNonEmpty("Email: ");
            string address = ReadNonEmpty("Address: ");
            string city = ReadNonEmpty("City: ");
            string state = ReadNonEmpty("State: ");
            string postalCode = ReadNonEmpty("Postal Code: ");
            string emergencyContactName = ReadNonEmpty("Emergency Contact Name: ");
            string emergecncyContactNumber = ReadNonEmpty("Emergency Contact Number: ");

            string goals = ReadGoals();
            string memberships = ReadMemberships();
            string paymentMethods = ReadPaymentMethod();

            int age = ReadInt("Age (13-100: ", 14, 100);
            int height = ReadInt("Height (feet 4-7): ", 4, 7);
            int weight = ReadInt("Weight (lbs 70-500):", 70, 500);
            int visitPerWeek = ReadInt("Visits Per Week 0-20: ", 0, 20);
            int experienceLevel = ReadInt("Experience Level (0=Beginner, 1=Intermediate, 2=Expert): ", 0, 2);

            bool wantsPersonalTrainer = ReadYesNo("Wants personal trainer? (Y/N): ");
            bool wantsGroupClass = ReadYesNo("Wants group class? (Y/N): ");
            bool wantsHighIntensity = ReadYesNo("Wants High Intensity (Y/N): ");
            bool listMedicalConditions = ReadYesNo("Has Medical Conditions? (Y/N): ");
            bool hasSignedWaiver = ReadYesNo("Signed Waiver? (Y/N): ");
            bool wantsTextUpdates = ReadYesNo("Wants text updates? Y/N: ");

            double bmi = CalculateBmi(height, weight);
            string riskLevel = DetermineRiskLevel(age, listMedicalConditions, wantsHighIntensity, hasSignedWaiver);
            string onboardingTrack = DetermineOnboardingTrack(experienceLevel, wantsPersonalTrainer, wantsGroupClass);






        }

    }
}
