using Booking_an_Appointment_Dental_Clinic.Data;
using Booking_an_Appointment_Dental_Clinic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Booking_an_Appointment_Dental_Clinic
{
    internal static class Program
    {
        [STAThread]


            static void Main()
            {
                string folderPath = @"C:\ClinicSecurity";
                string filePath = Path.Combine(folderPath, "admin_pass.txt");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string plainPassword = "D3nt@Cl!nic_Power#78";

                string hashedPassword = PasswordHelper.HashPassword(plainPassword);

                File.WriteAllText(filePath, hashedPassword);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FromLogin());
            }
        }
    

}
    
    