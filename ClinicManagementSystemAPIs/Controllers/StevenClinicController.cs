using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Configuration;
using ClinicManagementSystemAPIs.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace ClinicManagementSystemAPIs.Controllers {
    [Route("api/steven")]
    [ApiController]
    public class StevenClinicController : ControllerBase {
        private IClinicInterface _clinic;

        public StevenClinicController(IConfiguration config) =>
            _clinic = ClinicService.Create(new ClinicConfiguration() {
                Config = config,
                Clinic = ClinicType.StevenClinic
            });

        [HttpGet, Route("patients")]
        public async Task<IPatientResponse> GetAllPatients() =>
            _clinic.ManagePatient(ManageType.Pull)
                .Execute();

        [HttpGet, Route("patient/{id}")]
        public IPatientResponse GetPatientById(int id) =>
            _clinic.ManagePatient(ManageType.Pull)
                .Execute();

        [HttpPost, Route("newpatient")]
        public async Task<IPatientResponse> AddNewPaitent([FromBody] object body) =>
            _clinic.AuthPatient(AuthType.New)
                .Execute();

        [HttpPost, Route("updatepatient")]
        public async Task<IPatientResponse> UpdatePatient([FromBody] object body) =>
            _clinic.AuthPatient(AuthType.Optimization)
                .Execute();

        [HttpDelete, Route("deletepatient/{id}")]
        public IPatientResponse DeletePatientById(int id) =>
            _clinic.ManagePatient(ManageType.Delete)
                .Execute();

        [HttpDelete, Route("deletepatients")]
        public async Task<IPatientResponse> BulkDeletePatients([FromBody] int[] id) =>
            _clinic.ManagePatient(ManageType.Delete)
                .Execute();

        [HttpPost, Route("newtreatment")]
        public async Task<IPatientResponse> AddNewTreatment([FromBody] object body) =>
            _clinic.AuthTreatment(AuthType.New)
                .Execute();

        [HttpPost, Route("updatetreatment")]
        public async Task<IPatientResponse> UpdateTreatment([FromBody] object body) =>
            _clinic.AuthTreatment(AuthType.Optimization)
                .Execute();

        [HttpGet, Route("treatment/{id}")]
        public IPatientResponse GetPatientTretmentById(int id) =>
            _clinic.ManageTreatment(ManageType.Pull)
                .Execute();

        [HttpDelete, Route("deletetreatment/{id}")]
        public IPatientResponse DeleteTreatmentById(int id) =>
            _clinic.ManageTreatment(ManageType.Delete)
                .Execute();

        [HttpGet, Route("certificate/{id}")]
        public IReportResponse GetMedicalCertificateById(int id) =>
            _clinic.Pull(PullType.MedicalCertificate)
                .Excecute();
    }
}