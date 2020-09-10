using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Configuration;
using ClinicManagementSystemAPIs.Entities;
using ClinicManagementSystemAPIs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicManagementSystemAPIs.Controllers {
    [Route("api/steven")]
    [ApiController]
    public class StevenClinicController : ControllerBase {
        private IClinicInterface _clinic;

        public StevenClinicController() =>
            _clinic = ClinicService.Create(new ClinicConfiguration() {
                Clinic = ClinicType.StevenClinic
            });

        [HttpPost]
        [Route("testpost")]
        public IPatientResponse TestPost([FromBody] StevenExampleBody body) => null;
    }
}