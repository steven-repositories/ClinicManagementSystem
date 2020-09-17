using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Builders;
using ClinicManagementSystemAPIs.Entities;
using ClinicManagementSystemAPIs.Interfaces;
using ClinicManagementSystemAPIs.Layers;
using ClinicManagementSystemAPIs.Subcontrollers;
using ClinicManagementSystemAPIs.Utilities;
using Microsoft.Extensions.Configuration;
using System;

namespace ClinicManagementSystemAPIs.Clinics.StevenClinic {
    public class StevenController : ClinicController {
        private readonly DataAccess _clinicAccess;

        public StevenController(IConfiguration config) {
            string connectionString = config.GetConnectionString("StevenClinic");
            _clinicAccess = new DataAccess(connectionString);
        }

        #region Override methods
        internal override IClinicCommInterface ConfigureConnector() => new RESTInterface(_clinicAccess);

        internal override IClinicInterface ConfigureInterface() {
            if (_interface == null) {
                _interface = new StevenInterface(this);
            }

            return _interface;
        }

        internal override IPatientResponse ManageTransaction(ClinicManageBuilder builder) {
            switch (builder.ManageType) {
                case ManageType.Pull:
                    break;
                case ManageType.Delete:
                    break;
                default:
                    throw new BuilderException("The manage type is not available in enum entities");
            }

            return new StevenPatientResponse(new PatientInformation());
        }

        internal override IPatientResponse ProcessTransaction(ClinicAuthBuilder builder) {
            throw new NotImplementedException();
        }

        internal override IReportResponse ReportTransaction(ClinicReportBuilder builder) {
            throw new NotImplementedException();
        }
        #endregion

        #region Builder methods
        //private 
        #endregion
    }
}
