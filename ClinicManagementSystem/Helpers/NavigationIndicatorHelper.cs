using Microsoft.AspNetCore.Mvc;
using System;

namespace ClinicManagementSystem.Helpers {
    public static class NavigationIndicatorHelper {
        public static string MakeActive(this IUrlHelper urlHelper, string controller, string action) {
            try {
                string result = "active";

                var values = urlHelper.ActionContext.RouteData.Values;
                string controllerName = values["controller"].ToString();
                string methodName = values["action"].ToString();

                if (!string.IsNullOrEmpty(controllerName)) {
                    if (!controllerName.Equals(controller, StringComparison.OrdinalIgnoreCase)
                        || !methodName.Equals(action, StringComparison.OrdinalIgnoreCase)) {
                        return null;
                    } else {
                        return result;
                    }
                } else {
                    return null;
                }
            } catch (Exception e) {
                return null;
            }
        }
    }
}
