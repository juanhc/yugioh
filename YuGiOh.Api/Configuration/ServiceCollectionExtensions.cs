using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Http;
using Polly;

namespace YuGiOh.Api.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<HttpClientLoggingHandler>();

            services.AddHttpClient<YuGiOhApiClient>()
                .AddHttpMessageHandler<HttpClientLoggingHandler>()
                .AddTransientHttpErrorPolicy(
                p => p.WaitAndRetryAsync(3, _ => TimeSpan.FromMilliseconds(600)));

            return services;
        }
    }
}
