using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOD.SOMATO.BL.Logger
{
    public interface ILogger
    {
        void WriteInformation(string message);
        void WriteException(Exception ex);
        void WriteExceptionWithType(string detail, Exception ex);
    }

    public class WindowsEventLogger : ILogger
    {
        private const string source = "FOOD.SOMATO";
        private const int eventId = 555;
        public void WriteInformation(string message)
        {
            try
            {
                Trace.TraceInformation(message);
                using (EventLog eventLog = new EventLog())
                {
                    eventLog.Source = source;
                    eventLog.WriteEntry(message, EventLogEntryType.Information, eventId);
                }
            }
            catch (Exception e)
            {
                WriteExceptionMessage(e);
            }
        }

        
        private static void WriteExceptionMessage(Exception e)
        {
            Trace.TraceError(e.Message.ToString());
        }

        public void WriteExceptionWithType(string detail, Exception ex)
        {
            try
            {
                string innerException = ex.InnerException != null ? Environment.NewLine + "Inner Exception" + ex.InnerException.Message : string.Empty;
                string message = string.Format("Exception Details: {0} Message: {1} Stacktrace: {2}", detail, Environment.NewLine + ex.Message + innerException + Environment.NewLine, ex.StackTrace);
                using (EventLog eventLog = new EventLog())
                {
                    eventLog.Source = source;
                    eventLog.WriteEntry(message, EventLogEntryType.Error, eventId);
                }
            }
            catch (Exception e)
            {
                WriteExceptionMessage(e);

            }
        }

        public void WriteException(Exception ex)
        {
            try
            {
                string message = "Message:" + ex.Message + Environment.NewLine + "Stacktrace:" + ex.StackTrace;
                Trace.TraceError(message);
                using (EventLog eventLog = new EventLog())
                {
                    eventLog.Source = source;
                    eventLog.WriteEntry(message, EventLogEntryType.Error, eventId);
                }
            }
            catch (Exception e)
            {
                WriteExceptionMessage(e);

            }
        }
    }
}
