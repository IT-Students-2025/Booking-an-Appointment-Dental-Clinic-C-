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

          
            Book_an_appointment2 appointmentForm = new Book_an_appointment2();

            appointmentForm.Show();


            this.Hide();


        


    }

        private void button2_Click(object sender, EventArgs e)
        {


            Book_an_appointment2 appointmentForm = new Book_an_appointment2();


            appointmentForm.Show();


            this.Hide();



        }

        private void btnBack_Click(object sender, EventArgs e)
        {


         
            FromLogin formMain = new FromLogin();


            formMain.Show();


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









