using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementSystemAPIs.Entities {
    public enum ClinicType {
        StevenClinic
    }

    public enum AuthType {
        New,
        Continuation,
        Optimization
    }

    public enum ManageType {
        Pull,
        Delete
    }

    public enum PullType {
        MedicalCertificate,
        Prescription
    }
}
