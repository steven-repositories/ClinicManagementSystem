using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Clinics.StevenClinic;
using ClinicManagementSystemAPIs.Configuration;
using ClinicManagementSystemAPIs.Entities;
using ClinicManagementSystemAPIs.Utilities;
using Microsoft.Extensions.Configuration;

namespace ClinicManagementSystemAPIs {
    public class ClinicConfiguration : AConfiguration, IClinicConfiguration {
        public IConfiguration Config { get; set; }
        public ClinicType Clinic { get ; set; }
        
        internal override void ConfigureContainer(ConfiguredServices services) {
            switch (Clinic) {
                case ClinicType.StevenClinic:
                    services.ClinicController = new StevenController(Config);
                    break;
                default:
                    throw new ConfigurationException("The type of clinic is not available in enum entities");
            }
        }

    }
}
