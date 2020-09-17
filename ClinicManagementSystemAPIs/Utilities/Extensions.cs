namespace ClinicManagementSystemAPIs.Utilities {
    public static class Extensions {
        public static bool IsNullOrEmpty(this object value) => string.IsNullOrEmpty(value.ToString());
        public static string FormatWith(this string pattern, params object[] values) => string.Format(pattern, values);
    }
}
