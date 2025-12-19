using Booking_an_Appointment_Dental_Clinic.Data;
using Booking_an_Appointment_Dental_Clinic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Booking_an_Appointment_Dental_Clinic
{
    public partial class FromLogin : Form
    {
        public FromLogin()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {




        }



        internal void btnLogin_Click(object sender, EventArgs e)
        {


            string inputPassword = textPassword.Text; 

            string path = @"C:\ClinicSecurity\admin_pass.txt";

            string storedHash = File.ReadAllText(path);

            MessageBox.Show($"Password entered: {inputPassword}\nStored hash: {storedHash}");

            if (PasswordHelper.VerifyPassword(inputPassword, storedHash))
            {
                MessageBox.Show("تم تسجيل الدخول بنجاح");

                Book_an_appointment1 mainForm = new Book_an_appointment1();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("كلمة المرور غير صحيحة");
            }
        }


        private void FromLogin_Load(object sender, EventArgs e)
        {


        }
    }
}


    

