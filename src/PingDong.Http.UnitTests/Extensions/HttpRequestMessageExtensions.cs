using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using PingDong.Testing;
using Xunit;

namespace PingDong.Http.Extensions
{
    public class HttpRequestMessageExtensionTests
    {
        [Fact]
        public async Task Null_ShouldThrow_ArgumentNullException()
        {
            HttpRequestMessage message = null;
            await Assert.ThrowsAsync<ArgumentNullException>(async () => await message.CloneAsync());
        }

        [Fact]
        public async Task Message_ShouldClone_Success()
        {
            var message = new HttpRequestMessage(HttpMethod.Post, "http://www.azure.com/api")
            {
                Content = new StringContent("Hello")
                {
                    Headers = { ContentLength = 5 }
                }
            };
            message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "abcdefg");

            var clonedMessage = await message.CloneAsync();

            Assert.False(clonedMessage.Equals(message));
            Assert.Equal(clonedMessage, message, new PropertiesComparer<HttpRequestMessage>());
        }
    }
}
