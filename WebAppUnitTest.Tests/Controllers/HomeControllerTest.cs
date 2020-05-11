using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppUnitTest;
using WebAppUnitTest.Controllers;

namespace WebAppUnitTest.Tests.Controllers
{
  
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Test_AddMethod()
        {
              HomeController bm= new HomeController();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {
              HomeController bm= new HomeController();
            double res = bm.Substract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
              HomeController bm= new HomeController();
            double res = bm.divide(10, 5);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
              HomeController bm= new HomeController();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }
}
