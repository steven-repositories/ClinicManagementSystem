using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementSystemAPIs.Utilities {
    /// <summary>
    /// General error occured.
    /// </summary>
    public class ApiException : Exception {
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public ApiException(string message = null, Exception innerException = null) : base(message, innerException) { }
    }

    /// <summary>
    /// Builder error occured against the builder.
    /// </summary>
    public class BuilderException : Exception {
        /// <param name="message">Exception message</param>
        public BuilderException(string message = null) : base(message) { }
    }

    /// <summary>
    /// Configuration error occured against the clinic configuration.
    /// </summary>
    public class ConfigurationException : ApiException {
        /// <param name="message">Exception message</param>
        public ConfigurationException(string message) : base(message) { }
    }

}
