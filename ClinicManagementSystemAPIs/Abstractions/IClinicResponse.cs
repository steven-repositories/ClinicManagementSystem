using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementSystemAPIs.Abstractions {
    public interface IClinicResponse {

    }

    public interface IPatientResponse : IClinicResponse {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
    }

    public interface IReportResponse : IClinicResponse {

    }
}
