using Booking_an_Appointment_Dental_Clinic.Resources;
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
//using Microsoft.EntityFromwore;


namespace Booking_an_Appointment_Dental_Clinic
{
    public partial class FromLogin : Form
    {
        public FromLogin()
        {
            InitializeComponent();
        }


        // حدث الضغط على زر Log In
        private void btnLogIn_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    {
            //        string username = txtName.Text;
            //        string password = textPassword.Text;

            //        // التحقق أن الاسم يحتوي حروف فقط
            //        if (!Regex.IsMatch(username, @"^[a-zA-Z]+$"))
            //        {
            //            MessageBox.Show("الاسم يجب أن يحتوي حروف فقط");
            //            txtName.Focus();
            //            return;
            //        }

            //        // التحقق أن الباسورد يحتوي أرقام فقط
            //        if (!Regex.IsMatch(password, @"^\d+$"))
            //        {
            //            MessageBox.Show("الباسورد يجب أن يحتوي أرقام فقط");
            //            textPassword.Focus();
            //            return;
            //        }

            //        // ⭐⭐ التحقق الحقيقي من بيانات الدخول
            //        if (username != "admin" || password != "1234")
            //        {
            //            MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة");
            //            return;
            //        }

            //        // إذا كل شيء صحيح → نفتح الواجهة الثانية
            //        Book_an_appointment1 form2 = new Book_an_appointment1();

            //        //this.Hide();
            //        form2.ShowDialog();
            //        this.Show();
            //    }
            //}

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
    }
}

    

