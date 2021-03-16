using Microsoft.AspNetCore.Mvc;
using MovieMania.Controllers;
using MovieMania.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieManiaTests
{
    [TestFixture]
    public class ViewsTests
    {
        [Test]
        public void TestHomeControllerIndex()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
