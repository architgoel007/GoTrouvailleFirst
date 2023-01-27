using GoTrouvailleFirst.BL.InterfaceBL;
using GoTrouvailleFirst.BL.ServiceBL;
using GoTrouvailleFirst.DL;
using GoTrouvailleFirst.DL.InterfaceDL;

namespace GoTrouvailleFirst.API
{
    public static class Registration
    {
        public static IServiceCollection Register(this IServiceCollection services) 
        {
            services.AddTransient<IDLUserService, DLUserService>();
            services.AddTransient<IBLUserService, BLUserService>();
            return services;
        }
    }
}
