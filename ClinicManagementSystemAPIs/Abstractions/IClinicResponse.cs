using Microsoft.AspNetCore.Mvc;

namespace ClinicManagementSystemAPIs.Abstractions {
    public interface IClinicResponse {
        JsonResult Json();
    }

    public interface IPatientResponse : IClinicResponse {
        int MyProperty { get; set; }
        int MyProperty2 { get; set; }
    }

    public interface IReportResponse : IClinicResponse {

    }
}
