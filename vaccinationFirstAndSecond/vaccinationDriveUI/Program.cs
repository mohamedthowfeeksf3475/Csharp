using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaccinationDriveUI
{
    class Program
    {
        public static List<benificiaryDetails> UserDetails = new List<benificiaryDetails>();
        static void Main(string[] args)
        {
            

            
            // vaccineDetails vaccineInformation = new vaccineDetails();


            UserDetails.Add(new benificiaryDetails("thowfeek", 1234567890, "Kanyakumari", 23, "male", 998));
            UserDetails.Add(new benificiaryDetails("jagan", 9087654321, "vellor", 22, "male", 999));
            UserDetails.Add(new benificiaryDetails("manoj", 9123456780, "erode", 21, "male", 1000));

            int registrationNumber = 1001;
            string choice;
            Program vaccinatedDetails = new Program();
            do
            {
                Console.WriteLine("1.Beneficiary Registration\n2.Vaccination\n3.Exit");
                int menuChoice = int.Parse(Console.ReadLine());
                switch (menuChoice)
                {
                    case 1:

                        Console.WriteLine("Enter the benificiary name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the Age");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Gender");
                        string gender = Console.ReadLine();
                        Console.WriteLine("Enter the Mobile Number");
                        long mobileNumber = long.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the City");
                        string address = Console.ReadLine();
                        Console.WriteLine($"Your registration completed. Your registration number is {registrationNumber}");
                        benificiaryDetails information = new benificiaryDetails(name, mobileNumber, address, age, gender, registrationNumber);
                        UserDetails.Add(information);
                        registrationNumber += 1;
                        break;
                    case 2:
                        vaccinatedDetails.Information();
                        break;
                    case 3:
                        Environment.Exit(-1);
                        break;
                        
                }
                Console.WriteLine("Do you want continue (yes/no)? ");
                choice = Console.ReadLine();
            } while (choice == "yes");
            Console.ReadKey();
        }

        public void Information()
        {
            string choice;
            Console.WriteLine("Enter the Registratin number:");
            int idnumber = int.Parse(Console.ReadLine());

            foreach (benificiaryDetails infos in UserDetails)
            {
                if (idnumber == infos.registrationNumber)
                {
                    do
                    {

                        Console.WriteLine("1.Take Vaccination \n2.Vaccination History \n3.Next vaccination Date \n4.Exit");
                        Console.Write("Choose option");

                        int option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("1.Covid-Shield \n2.Covaccin \n3.sputnic");
                                Console.WriteLine("Which Dose you want?");
                                vaccineTypes vacType = (vaccineTypes)int.Parse(Console.ReadLine());

                                vaccineDetails user = new vaccineDetails(vacType, DateTime.Now);
                                if (infos.vaccinationDetails == null)
                                {

                                    infos.vaccinationDetails = new List<vaccineDetails>();
                                }
                                infos.vaccinationDetails.Add(user);

                                Console.WriteLine("Successfully vaccinated");

                                break;
                            case 2:
                                foreach (benificiaryDetails history in UserDetails)
                                {
                                    if (history.vaccinationDetails != null)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine($"RegisterNo: {history.registrationNumber} \nName: {history.name} \nVaccinated Dose: {history.vaccinationDetails[0].vaccineType}");
                                    }
                                }

                                break;
                            case 3:
                                foreach (benificiaryDetails Duedate in UserDetails)
                                {
                                    if (Duedate.vaccinationDetails != null)
                                    {
                                        if (Duedate.vaccinationDetails.Count == 1)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("You are vaccinated by " + Duedate.vaccinationDetails[0].vaccineType);
                                            Console.WriteLine("Your next Due Date: " + Duedate.vaccinationDetails[0].vaccinatedDate.AddDays(30));
                                        }
                                        else if (Duedate.vaccinationDetails.Count == 2)
                                        {
                                            Console.WriteLine("You have completed your vaccination course");
                                        }
                                    }

                                }
                                break;
                            case 4:

                                Environment.Exit(-1);
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;

                        }
                        Console.WriteLine("Do you want continue (yes/no)? ");
                        choice = Console.ReadLine();
                    } while (choice == "yes");
                }
            }
        }
    }
}
        


        

