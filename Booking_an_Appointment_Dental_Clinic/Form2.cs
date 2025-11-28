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

        private void Book_an_appointment2_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {

              // 1) التحقق من تعبئة البيانات
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                cmbDisease.SelectedIndex == -1 ||
                (!rdoMale.Checked && !rdoFemale.Checked))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2) قراءة البيانات
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            string phone = txtPhone.Text;
            string disease = cmbDisease.SelectedItem.ToString();
            string gender = rdoMale.Checked ? "Male" : "Female";
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string time = cmbTime.SelectedItem.ToString();
            // 3) الاتصال بقاعدة البيانات (عدّلي connection string لو لزم)
            string conString = @"Data Source=DESKTOP-H6G38FO;Initial Catalog=BookingAppointment;Integrated Security=True;";
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();

                // 4) أمر الإدخال لقاعدة البيانات
                string query = "INSERT INTO Booking (Name, Age, Phone, Disease, Date, Time, Gender) " +
                               "VALUES (@Name, @Age, @Phone, @Disease, @Date, @Time, @Gender)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Disease", disease);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Time", time);
                cmd.Parameters.AddWithValue("@Gender", gender);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Booking saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5) فتح الواجهة الثانية (عرض الحجوزات)
                show frm = new show();
                frm.Show();
                this.Hide();  // إخفاء واجهة الحجز

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
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

        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTime_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
    

