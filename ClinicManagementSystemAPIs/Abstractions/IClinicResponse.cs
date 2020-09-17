using ClinicManagementSystemAPIs.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace ClinicManagementSystemAPIs.Abstractions {
    public interface IClinicResponse {
        string Json();
    }

    public interface IPatientResponse : IClinicResponse {
        string FullName { get; set; }
        //PatientInformation PatientInfo { get; set; }
        //PatientHistory PatientHistoryInfo { get; set; }
        //PatientTreatment PatientTreatmentInfo { get; set; }
    }

    public interface IReportResponse : IClinicResponse {

    }
}
