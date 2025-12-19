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
            txtAge.Text = "";
            txtPhone.Text = "";
            cmbDisease.SelectedIndex = -1;
            cmbTime.SelectedIndex = -1;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            dtpDate.Value = DateTime.Now;



        }

     
        private void btnSave_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtName.Text) || !txtName.Text.All(char.IsLetter))
            {
                MessageBox.Show("يرجى إدخال اسم صحيح (حروف فقط).", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAge.Text.Trim(), out int age) ||  age <= 0  || txtAge.Text.Length > 3)
            {
                MessageBox.Show("يرجى إدخال عمر صحيح (رقم من 1 إلى 3 خانات).", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!txtPhone.Text.All(char.IsDigit) ||
                txtPhone.Text.Length != 9 ||
                txtPhone.Text == "000000000")
            {


                MessageBox.Show("يرجى إدخال رقم هاتف صالح مكون من 9 أرقام", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbDisease.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى اختيار نوع المرض.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTime.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى اختيار الوقت.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("يرجى اختيار الجنس.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        Gender = rdoMale.Checked ? "Male" : "Female",
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

                    txtName.Text = "";
                    txtAge.Text = "";
                    txtPhone.Text = "";
                    cmbDisease.SelectedIndex = -1;
                    cmbTime.SelectedIndex = -1;
                    rdoMale.Checked = false;
                    rdoFemale.Checked = false;
                    dtpDate.Value = DateTime.Now;

                    RefreshAppointmentsFormIfOpen();
                }
            }
            catch (Exception ex)
            {

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

        private void Book_an_appointment2_Load(object sender, EventArgs e)
        {

        }
    }
}