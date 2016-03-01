using AcademiaWebApi.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace AcademiaWebApi.MaintenanceProcessing
{
    public class MuscleCreatedActionResult : IHttpActionResult
    {
        public MuscleCreatedActionResult(HttpRequestMessage requestMessage, Muscle createdMuscle)
        {
            _requestMessage = requestMessage;
            _createdMuscle = createdMuscle;
        }

        private readonly Muscle _createdMuscle;
        private readonly HttpRequestMessage _requestMessage;

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute());
        }

        public HttpResponseMessage Execute()
        {
            var responseMessage = _requestMessage.CreateResponse(System.Net.HttpStatusCode.Created, _createdMuscle);

            //Todo:Load headers with link info

            return responseMessage;
        }
    }
}