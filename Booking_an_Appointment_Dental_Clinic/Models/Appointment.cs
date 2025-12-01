using System;
using System.ComponentModel.DataAnnotations;

namespace Booking_an_Appointment_Dental_Clinic.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; } 

        public int PatientID { get; set; }     

      
        public virtual Patient Patient { get; set; }

        public DateTime Date { get; set; }     
        public string Time { get; set; }       
        public string TreatmentType { get; set; } 

        
        public Appointment(int appointmentID, int patientID, DateTime date, string time, string treatmentType)
        {
            AppointmentID = appointmentID;
            PatientID = patientID;
            Date = date;
            Time = time;
            TreatmentType = treatmentType;
        }

        public Appointment() { }
    }
}