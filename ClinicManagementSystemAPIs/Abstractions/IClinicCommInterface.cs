using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementSystemAPIs.Abstractions {
    public interface IClinicCommInterface {
        object GetRequest(int id);
        object PostRequest(object body);
        object PutRequest(object body);
        bool DeleteRequest(object id);
    }
}
