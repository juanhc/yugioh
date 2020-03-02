using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace YuGiOh.Api.Configuration
{
    public class HttpClientLoggingHandler : DelegatingHandler
    {
        private readonly ILogger<HttpClientLoggingHandler> _logger;

        public HttpClientLoggingHandler(ILogger<HttpClientLoggingHandler> logger)
            => _logger = logger;

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Outgoing request ---- URL {request.RequestUri} - METHOD {request.Method} - TIME {DateTime.UtcNow}");

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
