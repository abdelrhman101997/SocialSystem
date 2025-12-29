namespace Social.PL.API.Configration
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddAPIService(this IServiceCollection services) 
        {
            return services;
        }
        public static WebApplication AddAPIWeb(this WebApplication app) 
        {
            return app;
        }
    }
}
