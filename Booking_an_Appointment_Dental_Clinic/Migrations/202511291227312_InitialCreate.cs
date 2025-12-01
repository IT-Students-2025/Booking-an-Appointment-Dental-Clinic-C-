namespace Booking_an_Appointment_Dental_Clinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    { 
                        AppointmentID = c.Int(nullable: false, identity: true),
                        PatientID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Time = c.String(),
                        TreatmentType = c.String(),
                    })
                .PrimaryKey(t => t.AppointmentID)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.PatientID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "PatientID", "dbo.Patients");
            DropIndex("dbo.Appointments", new[] { "PatientID" });
            DropTable("dbo.Patients");
            DropTable("dbo.Appointments");
        }
    }
}
