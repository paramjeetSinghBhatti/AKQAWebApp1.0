using AKQAWebApi.Helper_Classes;
using AKQACodingTestApp.Models;
using System;
using System.Net;
using System.Web.Http;


namespace AKQAWebAPi.Controllers
{
    //Custom Exception Filter class to handle Internal Errors from action methods.
    [CustomExceptionFilter]
    public class UserApiController : ApiController
    {
        private INumberToWord _objNumberToWord;

        //Injecting Dependency into Constructor. This is done to make sure our controller is testable.
        public UserApiController(INumberToWord objNumberToWord)
        {
            this._objNumberToWord = objNumberToWord;
        }

        /// <summary>
        /// Return User with Number converted to Word.
        /// </summary>
        /// <param name="user">User object</param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult Post(UserVM user)
        {
            if (user == null)
            {
                string message = "Please provide valid User data.";
                return Content(HttpStatusCode.BadRequest, message);
            }
            user.ConvertedToWordNumber = _objNumberToWord.NumberToCurrencyText(Convert.ToDecimal(user.UserNumber)); ;
            return Ok(user);
        }
    }
}
