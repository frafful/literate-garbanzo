using AcademiaWebApi.Common.Logger;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

namespace AcademiaWebApi.Web.Common.ErrorHandling
{
    public class SimpleExceptionLogger : ExceptionLogger
    {
        public SimpleExceptionLogger(ILogManager logManager)
        {
            _log = logManager.GetLog(typeof(SimpleExceptionLogger));
        }

        private readonly ILog _log;

        public override void Log(ExceptionLoggerContext context)
        {
            _log.Error("Exceção não tratada", context.Exception);
        }
    }
}
