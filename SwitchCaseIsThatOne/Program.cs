using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseIsThatOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLEASE TAKE A MOMENT TO USE THE HAND SANITIZER TO THE RIGHT...THANK YOU.\n\n" +
                " Welcome To The Law Office Virtual Reception Area.\n\n" +
                " The Pandemic Crisis continues to introduce challenges that must be addressed," +
                " especially when it comes to dealing\n" +
                " with interpersonal communication between support staff and business patrons (or customers).\n" +
                " We feel it is our duty and responsibility to protect the privacy, health, and safety" +
                " of both our clients and our staff.\n" +
                " We are proud to offer the services of the Virtual Receptionist" +
                " and are able to take comfort in the knowlege that\n" +
                " we doing our part to help you feel more safe and secure during these unpresidented times. \n\n");

            Console.WriteLine("Please Enter Your Name: ");
            string clientName = Console.ReadLine();
            string checkInDate = DateTime.Now.ToString("MM/dd/yyyy"); // date for daily log of visitors
            string checkInTime = DateTime.Now.ToString("hh:mm");// time for daily log of visitors

            Console.WriteLine("\nDo you have a scheduled appointment for today? ( Press 1 for \"Yes\", Press 2 for \"No\" ) ");
            int appointment = Convert.ToInt32(Console.ReadLine());
            if (appointment == 2)
            {
                Console.WriteLine("Hello, " + clientName + ". \nThank you for coming in today. Our PANDEMIC Policy and Procedures Declaration states that ALL VISITORS ( whether potential client or existing client) schedule an appointment. We DO NOT TAKE WALK-INs.We are unable to address your concerns today and apologize for any inconvenience this may have caused. " +
                                "Please Grab  A  Pamphlet &  A New Client Packet  As You Exit The Lobby.\n" +
                                "READ ALL LITERATURE and FOLLOW THE INSTRUCTIONS provided in the New Client Packet.\n" +
                                "We look forward to your next visit where we will start discussing all available options.\n \"Uninformed and hasty decisions lead to quick and long lasting pain\"- Dr.Mick Muianga \n" +
                                "So, Fill out the New Client Form and Call to schedule that appointment!\n " +
                                "And Remember: \"He who lives by the crystal ball will eat shattered glass.\" - Ray Dalio\n Don't Let That Be True for You! \nHave a Great Day, God Bless You, and Goodbye!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Pick The Option That Best Describes The Reason For Your Visit Today:\n\n Press 1 for Criminal\n Press 2 for Divorce\n Press 3 for Family\n Press 4 for Bankruptcy\n Press 6 for Personal Injury\n Press 7 for Business\n Press 8 for Environmental\n Press 9 for Intellectual Property Matters\n Press 10 for None of the Above");
                int typeOfAppt = Convert.ToInt32(Console.ReadLine());
                {
                    switch (typeOfAppt)
                    {
                        case 1:
                            Console.WriteLine("Mr. Peterson, and team, handle all Criminal Matters. Please be seated and someone will be with you shortly. ");
                            break;
                        case 2:
                            Console.WriteLine("Mr. Jackson, and team, handle all Divorse Matters. Please be seated and someone will be with you shortly.");
                            break;
                        case 3:
                            Console.WriteLine("Mrs. Stevens, and team, handle all Family Matters. Please be seated and someone will be with you shortly.");
                            break;
                        case 4:
                            Console.WriteLine("Mr. Jones, and team, handle all Bankruptcyt Matters. Please be seated and someone will be with you shortly.");
                            break;
                        case 5:
                            Console.WriteLine("Mrs. Ji, and team, handle all Personal Injury Matters. Please be seated and someone will be with you shortly.");
                            break;
                        case 6:
                            Console.WriteLine("Mr. Chapa, and team, handle all Business Matters. Please be seated and someone will be with you shortly.");
                            break;
                        case 7:
                            Console.WriteLine("Mr. Ledington, and team, handle all Environmental Matters. Please be seated and someone will be with you shortly.");
                            break;
                        case 8:
                            Console.WriteLine("Ms. Elam, and team,  handle all Immigration Matters. Please be seated and someone will be with you shortly.");
                            break;
                        case 9:
                            Console.WriteLine("Mr. Brackett, and team, handle all Intellectual Property Matters. Please be seated and someone will be with you shortly.");
                            break;
                        default:
                            Console.WriteLine("Please be seated and someone will be with you shortly.");
                            break;
                    }
                            Console.ReadLine();

                    }
                }
            }
        }
    }



