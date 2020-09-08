using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Clinics.StevenClinic;
using ClinicManagementSystemAPIs.Configuration;
using ClinicManagementSystemAPIs.Entities;

namespace ClinicManagementSystemAPIs {
    public class ClinicConfiguration : AConfiguration, IClinicConfiguration {
        public ClinicType Clinic { get ; set; }

        internal override void ConfigureContainer(ConfiguredServices services) {
            switch (Clinic) {
                case ClinicType.StevenClinic:
                    services.ClinicController = new StevenController(ConstantsConnection.StevenClinicConnection);
                    break;
                default:
                    break;
            }
        }

    }
}
