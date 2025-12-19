using Booking_an_Appointment_Dental_Clinic.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        public void LoadAppointments()
        {
            using (var context = new BookingContext())
            {
                var list = context.Appointments

                  .Include(a => a.Patient)
                  .OrderBy(a => a.AppointmentID)
                  .ToList()
                  .Select((a, index) => new
                  {
                      RowNumber = index + 1,
                      a.AppointmentID,
                      PatientName = a.Patient.Name,
                      PatientAge = a.Patient.Age,
                      PatientPhone = a.Patient.Phone,
                      PatientGender = a.Patient.Gender,
                      a.Date,
                      a.Time,
                      a.TreatmentType
                  })
                  .ToList();

                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
            }
        }

        private void bntBack_Click(object sender, EventArgs e)
        {

            Book_an_appointment1 formMain = new Book_an_appointment1();

            formMain.Show();

            this.Close();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void show_Load(object sender, EventArgs e)
        {
            LoadAppointments();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("اختاري موعدًا للحذف أولاً.");

                return;
            }

            int appointmentId = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells["AppointmentID"].Value);

            DialogResult result = MessageBox.Show(
                "هل أنتِ متأكدة من حذف هذا الموعد؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var context = new BookingContext())
                {
                    var appointment = context.Appointments.Find(appointmentId);

                    if (appointment != null)
                    {
                        context.Appointments.Remove(appointment);

                        context.SaveChanges();

                        MessageBox.Show("✅ تم حذف الموعد بنجاح");

                        LoadAppointments();
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadAppointments();
                return;
            }

            using (var context = new BookingContext())
            {
                var allAppointments = context.Appointments
    .Include(a => a.Patient)
    .ToList();

                var result = allAppointments
                    .Where(a => a.Patient.Name.Contains(keyword)
                             || a.Patient.Phone.Contains(keyword)
                             || a.Patient.Age.ToString().Contains(keyword)
|| a.Patient.Gender.Contains(keyword)
                             || a.AppointmentID.ToString().Contains(keyword)
                             || a.TreatmentType.Contains(keyword)
                             || a.Date.ToString("yyyy-MM-dd").Contains(keyword)
                             || a.Time.Contains(keyword))
                    .Select(a => new
                    {
                        a.AppointmentID,
                        PatientName = a.Patient.Name,
                        PatientAge = a.Patient.Age,
                        PatientPhone = a.Patient.Phone,
                        PatientGender = a.Patient.Gender,
                        a.Date,
                        a.Time,
                        a.TreatmentType
                    })
                    .ToList();

                dataGridView1.DataSource = result;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            btnSearch.PerformClick();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
