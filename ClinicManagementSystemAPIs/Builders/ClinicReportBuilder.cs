using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Configuration;
using ClinicManagementSystemAPIs.Entities;

namespace ClinicManagementSystemAPIs.Builders {
    public class ClinicReportBuilder {
        internal PullType PullType { get; private set; }
        internal ClinicReportBuilder(PullType pullType) => PullType = pullType;

        public IReportResponse Excecute() =>
            ClinicsContainer.GetClinicController()
            .ReportTransaction(this);
    }
}
