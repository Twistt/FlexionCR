using NUnit.Framework;
using FlexUnits.Controllers;
using System.Linq;

namespace ConversionTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        #region APITests
        [Test]
        public void TestStaticDataLoadAPI()
        {
            var staticDataController = new FlexUnits.Controllers.StaticDataController();
            var results = staticDataController.Get();
            if (results != null && results.ToList().Count > 1) Assert.Pass();
            else Assert.Fail();
        }
        public void TestConversionAPI()
        {

            Assert.Pass();
        }
        #endregion
    }
}