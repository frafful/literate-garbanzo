using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace AcademiaWebApi.Web.Common.ErrorHandling
{
    public class SimpleErrorResult : IHttpActionResult
    {
        public SimpleErrorResult(string errorMessage, HttpRequestMessage requestMessage, HttpStatusCode httpStatusCode)
        {
            _errorMessage = errorMessage;
            _requestMessage = requestMessage;
            _httpStatusCode = httpStatusCode;
        }

        private readonly string _errorMessage;
        private readonly HttpRequestMessage _requestMessage;
        private readonly HttpStatusCode _httpStatusCode;

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(_requestMessage.CreateErrorResponse(_httpStatusCode, _errorMessage));
        }
    }
}
