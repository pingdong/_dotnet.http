using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace PingDong.Http.Extensions
{
    public static class HttpRequestMessageExtensions
    {
        public static async Task<HttpRequestMessage> CloneAsync(this HttpRequestMessage request)  
        {  
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var clone = new HttpRequestMessage(request.Method, request.RequestUri);

            // Copy the request's content (via a MemoryStream) into the cloned object
            var ms = new MemoryStream();
            if (request.Content != null)
            {
                await request.Content.CopyToAsync(ms).ConfigureAwait(false);

                ms.Position = 0;
                clone.Content = new StreamContent(ms);

                // Copy the content headers
                if (request.Content.Headers != null)
                {
                    foreach (var header in request.Content.Headers)
                    {
                        clone.Content.Headers.Add(header.Key, header.Value);
                    }
                }
            }

            clone.Version = request.Version;

            foreach (var prop in request.Properties)
                clone.Properties.Add(prop);

            foreach (var header in request.Headers)
                clone.Headers.TryAddWithoutValidation(header.Key, header.Value);

            return clone;
        }
    }
}
