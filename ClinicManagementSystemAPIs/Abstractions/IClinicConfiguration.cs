using ClinicManagementSystemAPIs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementSystemAPIs.Abstractions {
    public interface IClinicConfiguration {
         ClinicType Clinic { get; set; }
    }
}
