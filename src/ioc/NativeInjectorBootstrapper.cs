namespace ioc
{
    using domain.Interfaces;
    using Microsoft.Extensions.DependencyInjection;
    using services;
    public static class NativeInjectorBootstrapper
    {   
        static void Main() {}
        public static ServiceProvider GetProvider(IServiceCollection services)
        {
            RegistrarServices(services);
            return services.BuildServiceProvider();
        }

        public static void RegistrarServices(IServiceCollection services)
        {
            services.AddTransient<IDividerService, DividerService>();
        }
    }
}