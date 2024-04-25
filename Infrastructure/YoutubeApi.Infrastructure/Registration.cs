using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Infrastructure.Token;

namespace YoutubeApi.Infrastructure
{
    public static class Registration
    {
        public static void AddInfrastructure(this IServiceCollection services , IConfiguration configuration)
        {
            services.Configure<TokenSettings>(configuration.GetSection("JWT"));

            
        }

    }

}
