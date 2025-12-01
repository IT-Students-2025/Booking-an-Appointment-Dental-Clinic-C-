using Booking_an_Appointment_Dental_Clinic.Data;
using Booking_an_Appointment_Dental_Clinic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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


     
    
        private void button3_Click(object sender, EventArgs e)
        {


            Book_an_appointment1 formMain = new Book_an_appointment1();

            formMain.Show();

            
            this.Close();
        
    }

       

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAge.Text=""; 
            txtPhone.Text="";
            cmbDisease.SelectedIndex=-1;
            cmbTime.SelectedIndex=-1;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            dtpDate.Value = DateTime.Now;



        }

    

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(groupBox1.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(cmbDisease.Text) ||
                string.IsNullOrWhiteSpace(cmbTime.Text))
            {
                MessageBox.Show("يرجى ملء جميع الحقول.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAge.Text.Trim(), out int age) || age <= 0)
            {
                MessageBox.Show("ادخلي عمر صحيح (رقم أكبر من صفر).", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                using (var context = new BookingContext())
                {
                    var patient = new Patient
                    {
                        Name = txtName.Text.Trim(),
                        Age = age,
                        Gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "",
                        Phone = txtPhone.Text.Trim()
                    };

                    context.Patients.Add(patient);
                    context.SaveChanges(); 

                    var appointment = new Appointment
                    {
                        PatientID = patient.ID,
                        Date = dtpDate.Value.Date,
                        Time = cmbTime.Text.Trim(),
                        TreatmentType = cmbDisease.Text.Trim()
                    };

                    context.Appointments.Add(appointment);
                    context.SaveChanges(); 


                    MessageBox.Show($"✅ تم الحجز بنجاح.\nرقم موعدك: {appointment.AppointmentID}", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshAppointmentsFormIfOpen();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ أثناء الحفظ:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshAppointmentsFormIfOpen()
        {

            var openForm = Application.OpenForms.OfType<show>().FirstOrDefault();
            if (openForm != null)
            {
                openForm.LoadAppointments();
            }
        }

    }
    }

    

