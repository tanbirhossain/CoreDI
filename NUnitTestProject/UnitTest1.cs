using DAL.Interface;
using NUnit.Framework;
using Microsoft.Extensions.DependencyInjection;
using CoreDI.Controllers;

namespace NUnitTestProject
{
    public class Tests
    {
        private IValueRepository _valueRepository;
        private ValuesController _valuesController;

        [SetUp]
        public void Setup()
        {
            var serviceProvider = Startup.ServiceProvider;
            if (serviceProvider != null)
            {
                _valueRepository = serviceProvider.GetService<IValueRepository>();
                _valuesController = new ValuesController(_valueRepository);

            }
        }

        [Test]
        public void ValueRepository_Test()
        {
            var actualResult = _valueRepository.GetValues();
            var expectedResult = new string[] { "valueFromRepository1", "valueFromRepository2" };
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void ValuesController_test()
        {
            var actualResult = _valuesController.ChillMethod().Value;
            var expectedResult = new string[] { "valueFromRepository1", "valueFromRepository2" };
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}