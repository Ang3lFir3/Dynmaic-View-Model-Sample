using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Web.Mvc;

namespace DynamicViewModel.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult Index()
        {
            dynamic viewModel = new ExpandoObject();
            viewModel.Name = "We Named this thing";
            viewModel.SomeInts = new[]{1,2,3};
            viewModel.AMethod = (Func<string>) (() => "This is a sample function implementation");
            return View(viewModel);
        }
    }
}
