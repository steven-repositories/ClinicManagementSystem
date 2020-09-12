using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Configuration;
using ClinicManagementSystemAPIs.Entities;

namespace ClinicManagementSystemAPIs.Builders {
    public class ClinicManageBuilder {
        internal ManageType ManageType { get; private set; }

        internal ClinicManageBuilder(ManageType manageType) => ManageType = manageType;

        public IPatientResponse Execute() =>
            ClinicsContainer.GetClinicController()
            .ManageTransaction(this);
    }
}
