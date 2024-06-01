using System;
namespace Task3
{
    public class Hospital
    {
        private List<Doctor> doctors;
        private List<DateTime> appointments;

        public Hospital()
        {
            doctors = new List<Doctor>();
            appointments = new List<DateTime>();
        }

        public void AddDoctor(string name)
        {
            doctors.Add(new Doctor { Name = name });
        }

        public void ViewAllDoctors()
        {
            Console.WriteLine("List of Doctors:");
            foreach (var doctor in doctors)
            {
                Console.WriteLine(doctor.Name);
            }
        }

        public void ScheduleAppointment(DateTime date)
        {
            if (appointments.Contains(date))
            {
                Console.WriteLine("Appointment already taken");
                return;
            }

            appointments.Add(date);
            Console.WriteLine("Appointment scheduled");
        }
    }
}
