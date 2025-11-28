using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_an_Appointment_Dental_Clinic.Resources
{
    internal class Appointment
    {
            // بيانات الموعد
            public int AppointmentID { get; set; } // رقم الموعد
            public int PatientID { get; set; }     // رقم المريض (لعمل الترابط)
            public DateTime Date { get; set; }     // تاريخ الموعد
            public string Time { get; set; }       // وقت الموعد
            public string TreatmentType { get; set; } // نوع العلاج

            // كونستركتور لتسهيل إنشاء الموعد
            public Appointment(int appointmentID, int patientID, DateTime date, string time, string treatmentType)
            {
                AppointmentID = appointmentID;
                PatientID = patientID;
                Date = date;
                Time = time;
                TreatmentType = treatmentType;
            }

            // كونستركتور فارغ
            public Appointment() { }
        }
    }
