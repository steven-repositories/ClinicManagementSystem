using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Entities;
using ClinicManagementSystemAPIs.Substructures;
using Newtonsoft.Json;

namespace ClinicManagementSystemAPIs.Clinics.StevenClinic {
    public class StevenBaseResponse : ClinicResponse {
        private object _response;

        public StevenBaseResponse(object response) => _response = response;

        public override string Json() => JsonConvert.SerializeObject(_response);
    }

    public class StevenPatientResponse : StevenBaseResponse, IPatientResponse {
        public StevenPatientResponse(object response) : base(response) { }

        public string FullName { get; set; }
        public PatientInformation PatientInfo { get; set; }
        public PatientTreatment PatientTreatmentInfo { get; set; }
    }
}
