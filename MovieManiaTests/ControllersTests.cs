using NUnit.Framework;
using MovieMania.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MovieManiaTests
{
    [TestFixture]
    public class ControllersTests
    {
        [Test]
        public void TestHomeView()
        {
            var controller = new HomeController();

            var result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
