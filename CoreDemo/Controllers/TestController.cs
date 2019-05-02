using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Data.Model;
using CoreDemo.Service.TestService;
using CoreDemo.Service.TestTypeService;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class TestController : Controller
    {
        #region Private Member
        private readonly ITestService _service;
        private readonly ITestTypeService _typeService;
        #endregion

        #region Constructor

        public TestController(ITestService service, ITestTypeService typeService)
        {
            _service = service;
            _typeService = typeService;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Defult View for Test List
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            List<TestListModel> list = new List<TestListModel>();
            list = _service.GetTestList();
            return View(list);
        }

        /// <summary>
        /// Create New Test - Get Partial View 
        /// </summary>
        /// <returns></returns>
        public PartialViewResult CreateNewTest()
        {
            ViewBag.TestTypeName = _typeService.GetAll();
            TestModel model = new TestModel();
            model.Date = DateTime.Now.Date;
            return PartialView("_NewTest", model);
        }

        /// <summary>
        /// Save New Test
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SaveNewTest(TestModel obj)
        {
            int result = _service.Insert(obj);
            return RedirectToAction("Index", "Test");
        }

        /// <summary>
        /// Delete Whole Test
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DeleteTest(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index", "Test");
        }
        #endregion
    }
}