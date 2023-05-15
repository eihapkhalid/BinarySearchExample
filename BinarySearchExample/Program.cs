using BinarySearchExample.Utlities;
using Bl.Interfaces;
using Bl.Services;
using Domains;
using BinarySearchExample.Utlities;
using Microsoft.Extensions.DependencyInjection;

namespace BinarySearchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region dependency injection
            // Create a new instance of the ServiceCollection class
            var services = new ServiceCollection();

            // Register the required services and their implementations
            services.AddScoped<Bl.Interfaces.IBusinessLayer<TbNumber>, NumberService>();
            // Build the service provider
            var serviceProvider = services.BuildServiceProvider();
            #endregion

            #region instance of UiHelper 
            UiHelper uiHelper = new UiHelper
                (
                    serviceProvider.GetService<IBusinessLayer<TbNumber>>(),
                    new TbNumber()

                 );
            #endregion
        }
    }
}