using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using WebServicesBusinessPlanner.Controllers;
using WebServicesBusinessPlanner.Model;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly qualificationController controler = new qualificationController();
        [TestMethod]
        public void TestGetAllQualificationMethod()
        {
            IEnumerable<qualification> list = controler.Get();
            Assert.AreEqual(5, list.Count());


        }
    }
}
