using DI;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;

namespace NUnitTestProject
{
    [SetUpFixture]
    public class Startup
    {
        internal static IServiceProvider ServiceProvider { get; set; }
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            ServiceProvider = ContainerBuilder();
        }
        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
            
        }
        public IServiceProvider ContainerBuilder()
        {
            IServiceCollection services = new ServiceCollection();
            services.BuildServiceContainer();
            return services.BuildServiceProvider();
        }

    }
}
