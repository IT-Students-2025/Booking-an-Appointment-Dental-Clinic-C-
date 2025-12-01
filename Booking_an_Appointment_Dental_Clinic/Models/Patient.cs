using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Booking_an_Appointment_Dental_Clinic.Models
{
    public class Patient
    {
        [Key]
        public int ID { get; set; }             
        public string Name { get; set; }     
        public int Age { get; set; }          
        public string Gender { get; set; }    

        public string Phone { get; set; }     

        public virtual List<Appointment> Appointments { get; set; }

        public Patient(int id, string name, int age, string gender, string phone)
        {
            ID = id;
            Name = name;
            Age = age;
            Gender = gender;
            Phone = phone;
            Appointments = new List<Appointment>();
        }

        public Patient()
        {
            Appointments = new List<Appointment>();
        }
    }
}