using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Application.Profiles;
using System.Reflection;

namespace SocialNetwork.Application;

public static class ApplicationServicesRegistration
{
    public static void ConfigureApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}
