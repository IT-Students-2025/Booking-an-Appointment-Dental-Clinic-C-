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
    public partial class show : Form
    {
        public show()
        {
            InitializeComponent();
        }

        private void bntBack_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
