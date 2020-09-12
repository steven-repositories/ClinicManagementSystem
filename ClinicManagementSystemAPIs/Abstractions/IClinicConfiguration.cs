using ClinicManagementSystemAPIs.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementSystemAPIs.Abstractions {
    public interface IClinicConfiguration {
        IConfiguration Config { get; set; }
        ClinicType Clinic { get; set; }
    }
}
