using ClinicManagementSystemAPIs.Builders;
using ClinicManagementSystemAPIs.Entities;

namespace ClinicManagementSystemAPIs.Abstractions {
    public interface IClinicInterface {
        ClinicAuthBuilder AuthPatient(AuthType type);
        ClinicManageBuilder ManagePatient(ManageType type);
        ClinicAuthBuilder AuthTreatment(AuthType type);
        ClinicManageBuilder ManageTreatment(ManageType type);

        ClinicReportBuilder Pull(PullType type);
    }
}
