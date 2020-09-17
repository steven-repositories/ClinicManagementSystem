using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Builders;
using ClinicManagementSystemAPIs.Entities;
using ClinicManagementSystemAPIs.Substructures;

namespace ClinicManagementSystemAPIs.Clinics.StevenClinic {
    public class StevenInterface : ClinicInterface<StevenController>, IClinicInterface {
        internal StevenInterface(StevenController controller) : base(controller) { }

        #region Clinic Auth Builder
        public new ClinicAuthBuilder AuthPatient(AuthType type) => base.AuthPatient(type);
        public new ClinicAuthBuilder AuthTreatment(AuthType type) => base.AuthTreatment(type);
        #endregion

        #region Clinic Manage Builder
        public new ClinicManageBuilder ManagePatient(ManageType type) => base.ManagePatient(type);
        public  new ClinicManageBuilder ManageTreatment(ManageType type) => base.ManagePatient(type);
        #endregion

        #region Clinic Report Builder
        public new ClinicReportBuilder Pull(PullType type) => base.Pull(type);
        #endregion
    }
}
