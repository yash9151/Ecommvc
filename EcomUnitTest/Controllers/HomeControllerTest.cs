using Ecommvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcomUnitTest.Controllers
{
    [TestClass]
    internal class HomeControllerTest
    {
        [TestMethod]
        public void Privacy()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Privacy() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
