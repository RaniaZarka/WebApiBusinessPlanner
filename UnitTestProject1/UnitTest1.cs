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
        private readonly sub_qualificationController sqcontroler = new sub_qualificationController();
        private readonly languageController lcontroler = new languageController();

        [TestMethod]
        public void TestGetAllQualificationMethod()
        {
            IEnumerable<qualification> list = controler.Get();
            Assert.AreEqual(5, list.Count());
        }

        [TestMethod]
        public void TestGetAllSubQualificationMethod()
        {
            IEnumerable<sub_qualification> list = sqcontroler.Get();
            Assert.AreEqual(24, list.Count());
        }

        [TestMethod]
        public void TestGetSubQualificationForBusinessMethod()
        {
            IEnumerable<sub_qualification> list = sqcontroler.GetSubBusiness(1);
            Assert.AreEqual(4, list.Count());
        }

        [TestMethod]
        public void TestGetSubQualificationForLawMethod()
        {
            IEnumerable<sub_qualification> list = sqcontroler.GetSubBusiness(2);
            Assert.AreEqual(5, list.Count());
        }

        [TestMethod]
        public void TestGetSubQualificationForMarketingMethod()
        {
            IEnumerable<sub_qualification> list = sqcontroler.GetSubBusiness(3);
            Assert.AreEqual(7, list.Count());
        }

        [TestMethod]
        public void TestGetSubQualificationForEconomyMethod()
        {
            IEnumerable<sub_qualification> list = sqcontroler.GetSubBusiness(4);
            Assert.AreEqual(3, list.Count());
        }

        [TestMethod]
        public void TestGetSubQualificationForSalesMethod()
        {
            IEnumerable<sub_qualification> list = sqcontroler.GetSubBusiness(5);
            Assert.AreEqual(5, list.Count());
        }

        [TestMethod]
        public void TestGetAllLanguageMethod()
        {
            IEnumerable<language> list = lcontroler.Get();
            Assert.AreEqual(2, list.Count());
        }
    }
}
