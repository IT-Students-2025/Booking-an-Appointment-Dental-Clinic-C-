using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_an_Appointment_Dental_Clinic.Resources
{
     internal class Booking
    {


            public int Booking_no { get; set; }   // سيكون Identity تلقائياً
            public string Name { get; set; }
            public int Age { get; set; }
            public string Phone { get; set; }
            public string Disease { get; set; }
            public DateTime Date { get; set; }
            public string Time { get; set; }
            public string Gender { get; set; }
        }

    }

