using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_an_Appointment_Dental_Clinic
{
    public partial class Book_an_appointment1 : Form
    {
        public Book_an_appointment1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {

            // 1. إنشاء مثيل (Instance) من واجهة تسجيل الحجز (الواجهة الثانية)
            // * تأكد من تغيير "FormBookAppointment" إلى الاسم الحقيقي لواجهة الحجز لديك *
            Book_an_appointment2 appointmentForm = new Book_an_appointment2();

            // 2. إظهار واجهة تسجيل الحجز
            appointmentForm.Show();

            // 3. إخفاء الواجهة الحالية (واجهة الشعار)
            // هذا يسمح للمستخدم بالعودة إليها لاحقًا إذا لزم الأمر، لكنها لن تظهر في شريط المهام.
            this.Hide();

            // ملاحظة: إذا كنت تفضل إغلاق الواجهة الأولى تمامًا بدلاً من إخفائها، استخدم:
            // this.Close();
        


    }

        private void button2_Click(object sender, EventArgs e)
        {


            // 1. إنشاء مثيل (Instance) من واجهة تسجيل الحجز (الواجهة الثانية)
            // * تأكد من تغيير "FormBookAppointment" إلى الاسم الحقيقي لواجهة الحجز لديك *
            Book_an_appointment2 appointmentForm = new Book_an_appointment2();

            // 2. إظهار واجهة تسجيل الحجز
            appointmentForm.Show();

            // 3. إخفاء الواجهة الحالية (واجهة الشعار)
            // هذا يسمح للمستخدم بالعودة إليها لاحقًا إذا لزم الأمر، لكنها لن تظهر في شريط المهام.
            this.Hide();

            // ملاحظة: إذا كنت تفضل إغلاق الواجهة الأولى تمامًا بدلاً من إخفائها، استخدم:
            // this.Close();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {


            // 1. إنشاء مثيل (Instance) من Form1 (واجهة العرض/الشعار)
            // هذا يفتح الواجهة الأولى
            FromLogin formMain = new FromLogin();

            // 2. إظهار Form1
            formMain.Show();

            // 3. إغلاق الواجهة الحالية (Form2 - واجهة الحجز)
            // نستخدم Close بدلاً من Hide لإنهاء عمل Form2 بشكل كامل
            this.Close();


        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            show f = new show();
            f.Show();
            this.Hide();
        }
    }
    }









