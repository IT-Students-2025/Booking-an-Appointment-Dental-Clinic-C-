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


namespace Booking_an_Appointment_Dental_Clinic
{
    public partial class FromLogin : Form
    {
        public FromLogin()
        {
            InitializeComponent();
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            User user = new User();
            if (user.Login(txtName.Text, textPassword.Text))
            {
                Book_an_appointment1 mainForm = new Book_an_appointment1();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة!");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FromLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

    

