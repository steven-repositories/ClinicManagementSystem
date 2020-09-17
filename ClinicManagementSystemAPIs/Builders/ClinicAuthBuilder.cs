using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Configuration;
using ClinicManagementSystemAPIs.Entities;

namespace ClinicManagementSystemAPIs.Builders {
    public class ClinicAuthBuilder : ClinicBaseBuilder<ClinicAuthBuilder> {
        internal AuthType AuthType { get; private set; }
        internal PatientInformation PatientInfo { get; private set; }
        internal PatientTreatment PatientTreatmentInfo { get; private set; }

        internal ClinicAuthBuilder(AuthType type) => AuthType = type;

        public ClinicAuthBuilder WithPatientInfo(PatientInformation info) {
            PatientInfo = info;
            return this;
        }

        public ClinicAuthBuilder WithPatientTreatmentInfo(PatientTreatment treatment) {
            PatientTreatmentInfo = treatment;
            return this;
        }

        public IPatientResponse Execute() =>
            ClinicsContainer.GetClinicController()
            .ProcessTransaction(this);
    }
}
