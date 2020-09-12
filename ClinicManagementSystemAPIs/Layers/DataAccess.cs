using Microsoft.Data.SqlClient;

namespace ClinicManagementSystemAPIs.Layers {
    public class DataAccess {
        private SqlConnection _connection;

        public DataAccess(string connectionString) {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }
    }
}
