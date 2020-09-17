using System;

namespace ClinicManagementSystemAPIs.Entities {
    public class AppointmentManagement {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeModified { get; set; }
    }

    public class AppointmentInformation : AppointmentManagement {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime DateTimeSchedule { get; set; }
        public int ChiefComplaintId { get; set; }
        public string ComplaintFreeText { get; set; }
    }
}
