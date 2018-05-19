using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace AKQAWebApi.Helper_Classes
{
    /// <summary>
    /// This class is used to catch exception that are raised outside on controller action.
    /// </summary>
    public class GlobalExceptionHandler : ExceptionHandler
    {
        public async override Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)  
        {  
            // Access Exception using context.Exception;  
            const string errorMessage = "An unexpected error occured";  
            var response = context.Request.CreateResponse(HttpStatusCode.InternalServerError,  
                new  
                {  
                    Message = errorMessage  
                });  
            response.Headers.Add("X-Error", errorMessage);  
            context.Result = new ResponseMessageResult(response);  
        }  
    }
}