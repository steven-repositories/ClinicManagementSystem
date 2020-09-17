using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Configuration;
using ClinicManagementSystemAPIs.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace ClinicManagementSystemAPIs.Controllers {
    [Route("api/patient-management")]
    [ApiController, Produces("application/json")]
    public class PatientController : ControllerBase {
        private IClinicInterface _clinic;

        public PatientController(IConfiguration config) =>
            _clinic = ClinicService.Create(new ClinicConfiguration() {
                Config = config,
                Clinic = ClinicType.StevenClinic
            });

        /// <summary>
        /// Get all the information of all patients
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("patients")]
        public string GetAllPatients() =>
            _clinic.ManagePatient(ManageType.Pull)
                .Execute()
                .Json();

        /// <summary>
        /// Get all the informayion of an specific patient
        /// </summary>
        /// <param name="id">Patient Id</param>
        /// <returns></returns>
        [HttpGet, Route("patient/{id}")]
        public string GetPatientById(int id) =>
            _clinic.ManagePatient(ManageType.Pull)
                .WithPatientId(id)
                .Execute()
                .Json();

        /// <summary>
        /// Add new patient to the patient management
        /// </summary>
        /// <param name="info">Patient Information</param>
        /// <returns></returns>
        [HttpPost, Route("patient")]
        public string AddNewPaitent([FromBody] PatientInformation info) =>
            _clinic.AuthPatient(AuthType.New)
                .WithPatientInfo(info)
                .Execute()
                .Json();

        /// <summary>
        /// Update the information of an specific patient
        /// </summary>
        /// <param name="info">Patient Information</param>
        /// <returns></returns>
        [HttpPatch, Route("patient")]
        public string UpdatePatient([FromBody] PatientInformation info) =>
            _clinic.AuthPatient(AuthType.Optimization)
                .WithPatientInfo(info)
                .Execute()
                .Json();

        /// <summary>
        /// Delete all the information of an specific patient
        /// </summary>
        /// <param name="id">Patient Id</param>
        /// <returns></returns>
        [HttpDelete, Route("patient/{id}")]
        public string DeletePatientById(int id) =>
            _clinic.ManagePatient(ManageType.Delete)
                .WithPatientId(id)
                .Execute()
                .Json();

        /// <summary>
        /// Delete all the information of every selected patients
        /// </summary>
        /// <param name="id">Patient Ids</param>
        /// <returns></returns>
        [HttpDelete, Route("patients")]
        public string BulkDeletePatients([FromBody] int[] id) =>
            _clinic.ManagePatient(ManageType.Delete)
                .WithPatientId(id)
                .Execute()
                .Json();

        /// <summary>
        /// Add new treatment for an specific patient
        /// </summary>
        /// <param name="treatment">Treatment Information</param>
        /// <returns></returns>
        [HttpPost, Route("treatment")]
        public string AddNewTreatment([FromBody] PatientTreatment treatment) =>
            _clinic.AuthTreatment(AuthType.New)
                .WithPatientTreatmentInfo(treatment)
                .Execute()
                .Json();

        /// <summary>
        /// Update the treatment information of an specific patient
        /// </summary>
        /// <param name="treatment">Treatment Information</param>
        /// <returns></returns>
        [HttpPatch, Route("treatment")]
        public string UpdateTreatment([FromBody] PatientTreatment treatment) =>
            _clinic.AuthTreatment(AuthType.Optimization)
                .WithPatientTreatmentInfo(treatment)
                .Execute()
                .Json();

        /// <summary>
        /// Get all the treatment information of every appointment an specific patient has
        /// </summary>
        /// <param name="id">Patient Id</param>
        /// <returns></returns>
        [HttpGet, Route("all-treatment/{id}")]
        public string GetAllTreatmentByPatientId(int id) =>
            _clinic.ManagePatient(ManageType.Pull)
                .WithPatientId(id)
                .Execute()
                .Json();

        /// <summary>
        /// Get all the information of a single treatment of an specific patient
        /// </summary>
        /// <param name="id">Treatment Id</param>
        /// <returns></returns>
        [HttpGet, Route("treatment/{id}")]
        public string GetTretmentInfoByPatientId(int id) =>
            _clinic.ManageTreatment(ManageType.Pull)
                .WithTreatmentId(id)
                .Execute()
                .Json();

        /// <summary>
        /// Delete all the information of a single treatment of an specific patient
        /// </summary>
        /// <param name="id">Treatment Id</param>
        /// <returns></returns>
        [HttpDelete, Route("treatment/{id}")]
        public string DeleteTreatmentById(int id) =>
            _clinic.ManageTreatment(ManageType.Delete)
                .WithTreatmentId(id)
                .Execute()
                .Json();

        /// <summary>
        /// Get all the information of an specific patient for medical certificate
        /// </summary>
        /// <param name="id">Patient Id</param>
        /// <returns></returns>
        [HttpGet, Route("certificate/{id}")]
        public string GetMedicalCertificateByPatientId(int id) =>
            _clinic.Pull(PullType.MedicalCertificate)
                .WithPatientId(id)
                .Excecute()
                .Json();

        /// <summary>
        /// Get the prescription of an specific patient by its appointment's treatment
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("prescription/{id}")]
        public string GetPrescriptionByAppointmenttId(int id) =>
            _clinic.Pull(PullType.Prescription)
                .WithAppointmentId(id)
                .Excecute()
                .Json();
    }
}