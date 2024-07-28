using System;
namespace Task3
{
   public class Doctor
    {
        public string Name { get;set;}
        public string Surname { get;set;}
        public int Age { get;set;}
        public List<Appointment> Appointments { get; set; }

        public Doctor(string name,string surname,int age) 
        {
            Name = name; Surname = surname; Age = age;
            Appointments = new List<Appointment>();
        }
     
    }
}
