using System;
using System.Dynamic;
using System.Web.Mvc;
using DynamicViewModel.Controllers;
using NUnit.Framework;

namespace DynamicViewModel.Tests
{
    [TestFixture]
    public class preseneters_with_dynamic_viewdata
    {
        [Test]
        public void make_sure_you_can_test_them()
        {
            var controller = new SampleController();
            var result = controller.Index() as ViewResult;

            dynamic dynamicModel = result.ViewData.Model;

            Assert.AreEqual("We Named this thing",dynamicModel.Name);
            Assert.AreEqual(3,dynamicModel.SomeInts.Length);
            Assert.AreEqual("This is a sample function implementation",((Func<string>)dynamicModel.AMethod)());
        }
    }
}
