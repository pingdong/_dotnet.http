using System.Collections.Generic;
using Xunit;

namespace PingDong.Http
{
    public class JsonErrorTests
    {
        [Fact]
        public void JsonError_Default()
        {
            var response = new JsonError();

            Assert.Equal(default, response.Code);
            Assert.Null(response.Details);
            Assert.Null(response.Message);
            Assert.Null(response.Target);
            Assert.Null(response.RequestValue);
        }
        [Fact]
        public void JsonError_SetThenGet_ShouldBeSame()
        {
            const int code = 1;
            const string message = "message";
            const string target = "target";
            var requestValue = new { code };
            var details = new List<JsonError>();

            var response = new JsonError
            {
                Code = code,
                Details = details,
                Target = target,
                Message = message,
                RequestValue = requestValue
            };

            Assert.Equal(code, response.Code);
            Assert.Equal(message, response.Message);
            Assert.Equal(target, response.Target);
            Assert.Equal(requestValue, response.RequestValue);
            Assert.Empty(response.Details);
        }
    }
}
