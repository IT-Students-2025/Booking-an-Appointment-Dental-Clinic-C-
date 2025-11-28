using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_an_Appointment_Dental_Clinic.Resources
{
    internal class Doctor : Person
    {

            public string Specialty { get; set; } // التخصص

            public Doctor(int id, string name, int age, string gender, string phone, string specialty)
                : base(id, name, age, gender, phone)
            {
                Specialty = specialty;
            }

            public Doctor() { }

            //// تطبيق الدالة المجردة
            //public override void DisplayInfo()
            //{
            //    Console.WriteLine($"Doctor: {Name}, Age: {Age}, Gender: {Gender}, Phone: {Phone}, Specialty: {Specialty}");
            //}
        }
    }