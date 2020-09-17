using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Builders;
using ClinicManagementSystemAPIs.Entities;
using ClinicManagementSystemAPIs.Subcontrollers;

namespace ClinicManagementSystemAPIs.Substructures {
    public abstract class ClinicInterface<T> : IClinicInterface where T : ClinicController {
        protected T _controller;

        internal ClinicInterface(T controller) => _controller = controller;

        #region Clinic Auth Builder
        public virtual ClinicAuthBuilder AuthPatient(AuthType type) =>
            new ClinicAuthBuilder(type);

        public virtual ClinicAuthBuilder AuthTreatment(AuthType type) =>
            new ClinicAuthBuilder(type);
        #endregion

        #region Clinic Manage Builder
        public virtual ClinicManageBuilder ManagePatient(ManageType type) =>
            new ClinicManageBuilder(type);

        public virtual ClinicManageBuilder ManageTreatment(ManageType type) =>
            new ClinicManageBuilder(type);
        #endregion

        #region Clinic Report Builder
        public virtual ClinicReportBuilder Pull(PullType type) =>
            new ClinicReportBuilder(type);
        #endregion
    }
}
