using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Builders;
using ClinicManagementSystemAPIs.Interfaces;
using ClinicManagementSystemAPIs.Layers;
using ClinicManagementSystemAPIs.Subcontrollers;
using System;

namespace ClinicManagementSystemAPIs.Clinics.StevenClinic {
    public class StevenController : ClinicController {
        private readonly DataAccess _clinicAccess;

        public StevenController(string connectionString) {
            _clinicAccess = new DataAccess(connectionString);
        }

        internal override IClinicCommInterface ConfigureConnector() => new RESTInterface(_clinicAccess);

        internal override IClinicInterface ConfigureInterface() {
            if (_interface == null) {
                _interface = new StevenInterface(this);
            }

            return _interface;
        }

        internal override IPatientResponse ManageTransaction(ClinicManageBuilder builder) {
            throw new NotImplementedException();
        }

        internal override IPatientResponse ProcessTransaction(ClinicAuthBuilder builder) {
            throw new NotImplementedException();
        }

        internal override IReportResponse ReportTransaction(ClinicReportBuilder builder) {
            throw new NotImplementedException();
        }
    }
}
