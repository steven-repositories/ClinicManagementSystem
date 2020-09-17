using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Configuration;
using ClinicManagementSystemAPIs.Entities;

namespace ClinicManagementSystemAPIs.Builders {
    public class ClinicManageBuilder : ClinicBaseBuilder<ClinicManageBuilder> {
        internal ManageType ManageType { get; private set; }
        internal int[] PatientIds { get; private set; }

        internal ClinicManageBuilder(ManageType manageType) => ManageType = manageType;

        public ClinicManageBuilder WithPatientId(int[] id) {
            PatientIds = id;
            return this;
        }

        public IPatientResponse Execute() =>
            ClinicsContainer.GetClinicController()
            .ManageTransaction(this);
    }
}
