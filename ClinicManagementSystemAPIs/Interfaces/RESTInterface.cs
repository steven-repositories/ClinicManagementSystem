using ClinicManagementSystemAPIs.Abstractions;
using ClinicManagementSystemAPIs.Layers;
using System;

namespace ClinicManagementSystemAPIs.Interfaces {
    public class RESTInterface : IClinicCommInterface {
        private DataAccess _db;

        public RESTInterface(DataAccess db) => _db = db;

        public object GetRequest(int id) {
            throw new NotImplementedException();
        }

        public object PostRequest(object body) {
            throw new NotImplementedException();
        }

        public object PutRequest(object body) {
            throw new NotImplementedException();
        }

        public bool DeleteRequest(object id) {
            throw new NotImplementedException();
        }
    }
}
