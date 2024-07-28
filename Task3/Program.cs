using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Task3
{
    class Program
    {
    static void Main()
    {
        Hospital hospital = new Hospital();

        while (true)
        {
            Console.WriteLine("---Menu---");
            Console.WriteLine("1. Add doctor");
            Console.WriteLine("2. View doctors");
            Console.WriteLine("3. Schedule appointment");
            Console.WriteLine("4. Show appointments of doctor");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose one");

            int lastChoice;
            string choice = Console.ReadLine();
            bool isTrue = int.TryParse(choice, out lastChoice);

            switch (lastChoice)
            {
                case 1:
                    AddDoctor(hospital);
                    break;
                case 2:
                    ViewAllDoctors(hospital);
                    break;
                case 3:
                    ScheduleAppointment(hospital);
                    break;
                case 4:
                    ViewAppointmentsOfDoctor(hospital);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void AddDoctor(Hospital hospital)
    {
        Console.WriteLine("Enter name");
        string name = Console.ReadLine();

        hospital.AddDoctor(new Doctor { Name = name });
        Console.WriteLine("Added successfully.");
    }

    static void ViewAllDoctors(Hospital hospital)
    {

        
        foreach (var doctor in hospital.Doctors)
        {
            Console.WriteLine(doctor.Name);
        }
    }

    static void ScheduleAppointment(Hospital hospital)
    {
        Console.WriteLine("Enter doctor's name:");
        string doctorName = Console.ReadLine();
        var doctor = hospital.Doctors.FirstOrDefault(d => d.Name == doctorName);

        if (doctor == null)
        {
            Console.WriteLine("There are No doctor named like this");
            return;
        }

        Console.WriteLine("Enter patient name ");
        string patientName = Console.ReadLine();

        Console.WriteLine("Enter appointment date (yyyy-mm-dd)");
        DateTime appointmentDate;
        if (!DateTime.TryParse(Console.ReadLine(), out appointmentDate))
        {
            Console.WriteLine("Invalid input");
            return;
        }
        TimeSpan appointmentDuration = TimeSpan.FromHours(1);
        if (doctor.Appointments.Any(a => a.Date < appointmentDate + appointmentDuration && a.Date + appointmentDuration > appointmentDate))
        {
            Console.WriteLine("This time is unavailable");
            return;
        }
        

        doctor.Appointments.Add(new Appointment { PatientName = patientName, Date = appointmentDate });
        Console.WriteLine("Appointment selected.");
    }

    static void ViewAppointmentsOfDoctor(Hospital hospital)
    {
        Console.WriteLine("Enter doctor's name:");
        string doctorName = Console.ReadLine();
        var doctor = hospital.Doctors.FirstOrDefault(d => d.Name == doctorName);

        if (doctor == null)
        {
            return;
        }

        foreach (var appointment in doctor.Appointments)
        {
            Console.WriteLine($" {appointment.PatientName} , {appointment.Date}");
        }
    }
    }
}
