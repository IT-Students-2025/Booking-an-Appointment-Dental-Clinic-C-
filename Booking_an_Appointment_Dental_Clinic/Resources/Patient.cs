namespace YourProjectNamespace
{
    public class Patient
    {
        // بيانات المريض
        public int ID { get; set; }           // رقم المريض
        public string Name { get; set; }      // الاسم
        public int Age { get; set; }          // العمر
        public string Gender { get; set; }    // الجنس
        public string Phone { get; set; }     // الهاتف

        // كونستركتور لتسهيل إنشاء المريض
        public Patient(int id, string name, int age, string gender, string phone)
        {
            ID = id;
            Name = name;
            Age = age;
            Gender = gender;
            Phone = phone;
        }

        // كونستركتور فارغ
        public Patient() { }
    }
}