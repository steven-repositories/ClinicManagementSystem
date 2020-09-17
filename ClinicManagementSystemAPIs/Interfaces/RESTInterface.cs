using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Layers;
using System;

namespace ClinicManagementSystemAPIs.Interfaces {
    public class RESTInterface : IClinicCommInterface {
        private DataAccess _db;

        public RESTInterface(DataAccess db) => _db = db;

        public object Get(string procedure, object request) {
            throw new NotImplementedException();
        }

        public object Post(string procedure, object body) {
            throw new NotImplementedException();
        }

        public object Patch(string procedure, object body) {
            throw new NotImplementedException();
        }

        public bool Delete(string procedure, object request) {
            throw new NotImplementedException();
        }
    }
}
