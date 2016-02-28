using AcademiaWebApi.Data.Exceptions;
using System.Net;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace AcademiaWebApi.Web.Common.ErrorHandling
{
    public class GlobalExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            var exception = context.Exception;
            var httpException = exception as HttpException;

            if (httpException != null)
            {
                context.Result = new SimpleErrorResult(httpException.Message, context.Request, (HttpStatusCode)httpException.GetHttpCode());
                return;
            }

            if(exception is RootObjectNotFoundException)
            {
                context.Result = new SimpleErrorResult(exception.Message, context.Request, HttpStatusCode.NotFound);
                return;
            }

            if (exception is ChildObjectNotFoundException)
            {
                context.Result = new SimpleErrorResult(exception.Message, context.Request, HttpStatusCode.Conflict);
                return;
            }

            context.Result = new SimpleErrorResult(exception.Message, context.Request, HttpStatusCode.InternalServerError);

        }
    }
}
