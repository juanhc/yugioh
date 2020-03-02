using Microsoft.Extensions.DependencyInjection;
using System;
using Polly;
using MediatR;

namespace YuGiOh.Api.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(Startup).Assembly);

            services.AddTransient<HttpClientLoggingHandler>();

            services.AddHttpClient<YuGiOhApiClient>()
                .AddHttpMessageHandler<HttpClientLoggingHandler>()
                .AddTransientHttpErrorPolicy(
                p => p.WaitAndRetryAsync(3, _ => TimeSpan.FromMilliseconds(600)));

            return services;
        }
    }
}
