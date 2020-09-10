using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Subcontrollers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementSystemAPIs.Substructures {
    public abstract class ClinicInterface<T> : IClinicInterface where T: ClinicController {
        protected T _controller;

        internal ClinicInterface(T controller) => _controller = controller;
    }
}
