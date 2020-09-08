using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Substructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementSystemAPIs.Clinics.StevenClinic {
    public class StevenInterface : ClinicInterface<StevenController>, IClinicInterface {
        internal StevenInterface(StevenController controller) : base(controller) { }
    }
}
