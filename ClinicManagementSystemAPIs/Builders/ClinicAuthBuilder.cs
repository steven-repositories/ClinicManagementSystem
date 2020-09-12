using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Configuration;
using ClinicManagementSystemAPIs.Entities;

namespace ClinicManagementSystemAPIs.Builders {
    public class ClinicAuthBuilder {
        internal AuthType AuthType { get; private set; }

        internal ClinicAuthBuilder(AuthType type) => AuthType = type;

        public IPatientResponse Execute() =>
            ClinicsContainer.GetClinicController()
            .ProcessTransaction(this);
    }
}
