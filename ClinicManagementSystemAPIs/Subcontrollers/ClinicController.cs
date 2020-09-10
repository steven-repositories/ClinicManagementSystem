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

        public object GetRequest(int id) => _connector?.GetRequest(id);
        public object PostRequest(object body) => _connector?.PostRequest(body);
        public object PutRequest(object body) => _connector?.PutRequest(body);
        public bool? DeleteRequest(object id) => _connector?.DeleteRequest(id);
    }
}
