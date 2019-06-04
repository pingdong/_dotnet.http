using Xunit;

namespace PingDong.Http
{
    public class JsonResponseTests
    {
        [Fact]
        public void JsonResponse_Default()
        {
            var response = new JsonResponse();

            Assert.False(response.Success);
            Assert.Null(response.Value);
            Assert.Null(response.Pagination);
        }
        [Fact]
        public void JsonResponse_SetThenGet_ShouldBeSame()
        {
            var page = new JsonPagination
            {
                TotalPages = 4,
                CurrentPageIndex = 1,
                Count = 10,
            };

            var value = new {Id = "string"};

            var response = new JsonResponse
            {
                Success = true,
                Pagination =  page,
                Value = value
            };

            Assert.True(response.Success);
        }
    }
}
