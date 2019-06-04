using System.Collections.Generic;
using Xunit;

namespace PingDong.Http
{
    public class JsonErrorResponseTests
    {
        [Fact]
        public void JsonErrorResponse_Default()
        {
            var response = new JsonErrorResponse();

            Assert.Null(response.Error);
            Assert.False(response.Success);
        }

        [Fact]
        public void JsonErrorResponse_SetThenGet_ShouldBeSame()
        {
            const int code = 1;
            const string message = "message";
            const string target = "target";
            var requestValue = new { code };
            var details = new List<JsonError>();

            var error = new JsonError
            {
                Code = code,
                Details = details,
                Target = target,
                Message = message,
                RequestValue = requestValue
            };

            var response = new JsonErrorResponse();
            response.Error = error;

            Assert.Equal(error, response.Error);
        }

        [Fact]
        public void JsonErrorResponse_Success_ShouldAlwaysBeFalse()
        {
            var response = new JsonErrorResponse();
            Assert.False(response.Success);

            response.Success = true;
            Assert.False(response.Success);
        }
    }
}
