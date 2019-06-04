using Xunit;

namespace PingDong.Http
{
    public class JsonPaginationTests
    {
        [Fact]
        public void JsonPagination_Default()
        {
            var page = new JsonPagination();

            Assert.Equal(default, page.Count);
            Assert.Equal(default, page.CurrentPageIndex);
            Assert.Equal(default, page.TotalPages);
        }
        [Fact]
        public void JsonPagination_SetThenGet_ShouldBeSame()
        {
            const int count = 1;
            const int index = 1;
            const int total = 1;

            var page = new JsonPagination
            {
                Count = count,
                CurrentPageIndex = index,
                TotalPages = total
            };

            Assert.Equal(count, page.Count);
            Assert.Equal(index, page.CurrentPageIndex);
            Assert.Equal(total, page.TotalPages);
        }
    }
}
