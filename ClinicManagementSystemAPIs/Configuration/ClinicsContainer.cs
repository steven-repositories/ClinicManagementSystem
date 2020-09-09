using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Subcontrollers;

namespace ClinicManagementSystemAPIs.Configuration {
    public class ConfiguredServices {
        internal IClinicInterface ClinicInterface { get; private set; }
        private ClinicController _clinicController;
        internal ClinicController ClinicController {
            get {
                return _clinicController;
            }

            set {
                _clinicController = value;
                ClinicInterface = value.ConfigureInterface();
            }
        }
    }

    public class ClinicsContainer {
        private static ConfiguredServices _configurations;

        public static void ConfigureService<T>(T config) where T : AConfiguration {
            var conf = GetConfiguration();
            config.ConfigureContainer(conf);
        }

        private static ConfiguredServices GetConfiguration() => _configurations = new ConfiguredServices();

        internal static IClinicInterface GetClinicInterface() => _configurations.ClinicInterface;
        internal static ClinicController GetClinicController() => _configurations.ClinicController;
    }
}
