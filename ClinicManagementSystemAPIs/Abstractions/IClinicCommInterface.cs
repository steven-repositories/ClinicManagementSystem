namespace ClinicManagementSystemAPIs.Abstractions {
    public interface IClinicCommInterface {
        object Get(string procedure, object request);
        object Post(string procedure, object body);
        object Patch(string procedure, object body);
        bool Delete(string procedure, object request);
    }
}
