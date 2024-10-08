using System;

namespace BTCPayServer.Abstractions.Models
{
    public class StatusMessageModel
    {
        public StatusMessageModel()
        {
        }
        public string Message { get; set; }
        public string Html { get; set; }
        public StatusSeverity Severity { get; set; }
        public bool AllowDismiss { get; set; } = true;

        public string SeverityCSS => ToString(Severity);

        public static string ToString(StatusSeverity severity)
        {
            switch (severity)
            {
                case StatusSeverity.Info:
                    return "info";
                case StatusSeverity.Error:
                    return "danger";
                case StatusSeverity.Success:
                    return "success";
                case StatusSeverity.Warning:
                    return "warning";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public enum StatusSeverity
        {
            Info,
            Error,
            Success,
            Warning
        }
    }
}
