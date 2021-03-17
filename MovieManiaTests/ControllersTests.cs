using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
