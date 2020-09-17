using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Builders;

namespace ClinicManagementSystemAPIs.Subcontrollers {
    public abstract class ClinicController {
        protected IClinicInterface _interface;
        protected IClinicCommInterface _connector;

        internal ClinicController() => _connector = ConfigureConnector();

        internal abstract IClinicInterface ConfigureInterface();
        internal abstract IClinicCommInterface ConfigureConnector();

        internal abstract IPatientResponse ProcessTransaction(ClinicAuthBuilder builder);
        internal abstract IPatientResponse ManageTransaction(ClinicManageBuilder builder);
        internal abstract IReportResponse ReportTransaction(ClinicReportBuilder builder);

        public object Get(string procedure, object request) => _connector?.Get(procedure, request);
        public object Post(string procedure, object body) => _connector?.Post(procedure, body);
        public object Patch(string procedure, object body) => _connector?.Patch(procedure, body);
        public bool? Delete(string procedure, object request) => _connector?.Delete(procedure, request);
    }
}
