using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            int choice;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add doctor");
                Console.WriteLine("2. View all doctors");
                Console.WriteLine("3. Schedule appointment");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter doctor's name: ");
                        string doctorName = Console.ReadLine();
                        hospital.AddDoctor(doctorName);
                        break;
                    case 2:
                        hospital.ViewAllDoctors();
                        break;
                    case 3:
                        Console.Write("Enter appointment date (yyyy-mm-dd hh:mm): ");
                        DateTime appointmentDate = Convert.ToDateTime(Console.ReadLine());
                        hospital.ScheduleAppointment(appointmentDate);
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            } while (choice != 4);
        }
    }
}