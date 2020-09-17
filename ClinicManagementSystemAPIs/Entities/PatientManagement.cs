using System;
using System.Collections.Generic;

namespace ClinicManagementSystemAPIs.Entities {
    public class PatientManagement {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeModified { get; set; }
    }

    public class PatientInformation : PatientManagement {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Height { get; set; }
        public int Weight { get; set; }
        public int Gender { get; set; }
        public int Age { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    public class PatientTreatment : PatientManagement {
        public int AppointmentId { get; set; }
        public int TreatmentDrugId { get; set; }
        public string TreamentDescription { get; set; }
    }

    //public class PatientHistory : PatientManagement {
        //public Dictionary<int, History> History { get; set; }
    //}

    //public class History {
    //    public AppointmentInformation[] AppointmentsInfo { get; set; }
    //    public Treatment[] TreamentsInfo { get; set; }
    //}

    //public class Treatment {
        
    //}
}