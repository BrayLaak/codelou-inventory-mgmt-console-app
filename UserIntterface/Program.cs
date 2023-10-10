using IMTest.BL.Interfaces;
using IMTest.BL.Logic;
using IMTest.UI.Logic;
using Microsoft.Extensions.DependencyInjection;

namespace IMTest.UI
{
    internal class Program
    {
        private static IServiceProvider CreateServiceCollection()
        {
            // Create and configure the service collection
            return new ServiceCollection()
                .AddTransient<IProductLogic, ProductLogic>() // Add ProductLogic as a transient service
                .BuildServiceProvider();
        }

        private static void Main(string[] args)
        {
            // Create and configure the service provider
            IServiceProvider serviceProvider = CreateServiceCollection();

            // Resolve the IProductLogic service
            var productLogic = serviceProvider.GetService<IProductLogic>();

            // Pass the productLogic instance to the UserInterface constructor
            var userInterface = new UserInterface(productLogic);

            userInterface.Run();
        }
    }

}

