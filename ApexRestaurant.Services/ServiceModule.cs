using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Services.SCustomer;
using ApexRestaurant.Services.SMenu;
using ApexRestaurant.Services.SStaff;
namespace ApexRestaurant.Services
{
    public class ServicesModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<IStaffService, StaffService>();
        }
        
    }
}