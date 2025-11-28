using Booking_an_Appointment_Dental_Clinic;
using Booking_an_Appointment_Dental_Clinic.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_an_Appointment_Dental_Clinic.Resources
{
    internal class User 
    {
            // هنا نخزن اسم المستخدم وكلمة المرور الثابتة
            private string username = "Admin";
            private string password = "1234";

            // دالة للتحقق من صحة البيانات المدخلة
            public bool Login(string inputUsername, string inputPassword)
            {
                if (inputUsername == username && inputPassword == password)
                {
                    return true; // تسجيل الدخول صحيح
                }
                else
                {
                    return false; // تسجيل الدخول خطأ
                }
            }
        }
    }
