using Xunit;

namespace PingDong.Http
{
    public class JsonResponseBaseTests
    {
        [Fact]
        public void JsonResponseBase_Default()
        {
            var response = new JsonResponseBase();
            Assert.False(response.Success);
        }
        [Fact]
        public void JsonResponseBase_SetThenGet_ShouldBeSame()
        {
            var response = new JsonResponseBase {Success = true};

            Assert.True(response.Success);
        }
    }
}
