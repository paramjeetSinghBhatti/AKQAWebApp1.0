using System;
using NUnit.Framework;
using Moq;
using AKQACodingTestApp.Models;
using AKQACodingTestApp.Controllers;
using System.Web.Http;
using System.Web.Http.Results;
using System.Net.Http;

namespace AKQAWebApiUnitTest
{
    [TestFixture]
    public class UserApiTest
    {
        private UserApiController sut;

        [SetUp]
        public void BeforeEachTest(){
            var mockNumberToWord = new Mock<INumberToWord>();
            sut = new UserApiController(mockNumberToWord.Object){
                Request=new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
        }

        [Test]
        public void ShouldReturnOKHttpResponseStatus()
        {   
            var objUser = new UserVM(){
            UserName = "John Smith",
            ConvertedToWordNumber = "One Dollar",
            UserNumber = 1
            };
            
            //Act
            IHttpActionResult actionResult = sut.Post(objUser);
            var result = actionResult as OkNegotiatedContentResult<UserVM>;

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void ShouldReturnBadRequestHttpResponseStatusIfUserIsNull()
        {
            UserVM objUser = null;

            //Act
            IHttpActionResult actionResult = sut.Post(objUser);
            var result = actionResult as NegotiatedContentResult<string>;

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
