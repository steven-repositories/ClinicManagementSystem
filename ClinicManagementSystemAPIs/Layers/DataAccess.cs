using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementSystemAPIs.Layers {
    public class DataAccess {
        protected string _connectionString;

        public DataAccess(string connectionString) => _connectionString = connectionString;
    }
}
