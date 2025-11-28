using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Booking_an_Appointment_Dental_Clinic
{
    public partial class Book_an_appointment2 : Form
    {
        public Book_an_appointment2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }




        private void btnOk_Click(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {















    }

        private void button3_Click(object sender, EventArgs e)
        {


            // 1. إنشاء مثيل (Instance) من Form1 (واجهة العرض/الشعار)
            // هذا يفتح الواجهة الأولى
            Book_an_appointment1 formMain = new Book_an_appointment1();

            // 2. إظهار Form1
            formMain.Show();

            // 3. إغلاق الواجهة الحالية (Form2 - واجهة الحجز)
            // نستخدم Close بدلاً من Hide لإنهاء عمل Form2 بشكل كامل
            this.Close();
        




    }
    }
}
    

