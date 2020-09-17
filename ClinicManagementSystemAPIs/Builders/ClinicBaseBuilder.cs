namespace ClinicManagementSystemAPIs.Builders {
    public class ClinicBaseBuilder<T> where T : ClinicBaseBuilder<T> {
        internal int PatientId { get; private set; }
        internal int AppointmentId { get; private set; }
        internal int TreatmentId { get; private set; }

        public T WithPatientId(int id) {
            PatientId = id;
            return this as T;
        }

        public T WithAppointmentId(int id) {
            AppointmentId = id;
            return this as T;
        }

        public T WithTreatmentId(int id) {
            TreatmentId = id;
            return this as T;
        }
    }
}
