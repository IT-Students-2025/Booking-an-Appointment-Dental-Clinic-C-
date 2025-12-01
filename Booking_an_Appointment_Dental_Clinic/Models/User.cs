using Booking_an_Appointment_Dental_Clinic;
using Booking_an_Appointment_Dental_Clinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_an_Appointment_Dental_Clinic.Models
{
    internal class User 
    {
            private string username = "Admin";
            private string password = "1234";

            public bool Login(string inputUsername, string inputPassword)
            {
                if (inputUsername == username && inputPassword == password)
                {
                    return true; 
                }
                else
                {
                    return false; 
                }
            }
        }
    }
