using ClinicManagementSystemAPIs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementSystemAPIs.Configuration {
    public class ClinicService {
        public static IClinicInterface Create(ClinicConfiguration config) {
            ClinicsContainer.ConfigureService(config);
            return ClinicsContainer.GetClinicInterface();
        }
    }
}
