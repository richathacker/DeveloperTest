using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Data.Model;
using CoreDemo.Service.TestDetailService;
using CoreDemo.Service.TestService;
using CoreDemo.Service.TestTypeService;
using CoreDemo.Service.UserService;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class TestDetailsController : Controller
    {
        #region Private Member
        private readonly ITestDetailService _service;
        private readonly ITestService _TestService;
        private readonly ITestTypeService _TestTypeService;
        private readonly IUserService _UserService;
        #endregion

        #region Constructor
        public TestDetailsController(ITestDetailService service, ITestService testService, ITestTypeService testTypeService, IUserService userService)
        {
            _service = service;
            _TestService = testService;
            _TestTypeService = testTypeService;
            _UserService = userService;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Get Test Details By Test Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Index(int id)
        {

            TestModel model = _TestService.GetById(id);
            string TypeName = _TestTypeService.GetById(model.TypeId).TestTypeName;
            List<TestDetailListModel>  list = _service.GetTestDetailList(id);

            TestDetailModel obj = new TestDetailModel();
            obj.TestDate = model.Date;
            obj.TestType = TypeName;
            obj.TestId = model.TestId;

            if (list.Count >0)
            {
                obj.TestDetaillist = list;
            }
            else
            {
                obj.TestDetaillist = new List<TestDetailListModel>();
            }
            return View(obj);
        }

        /// <summary>
        /// Returns Patial View - Edit / Create Athlete to Test
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public PartialViewResult CreateNewTestDetail(TestDetailPartialModel obj)
        {
            TestDetailCustomModel model = new TestDetailCustomModel();
            model.TestId = obj.TestId;

            if(obj.Id > 0)
            {
                TestDetailCustomModel currentObj = _service.GetById(obj.Id);
                model.Id = obj.Id;
                model.UserId = currentObj.UserId;
                model.Distance = currentObj.Distance;
            }

            ViewBag.UserList = _UserService.GetAll().Where(m=>m.UserTypeId == 2);
            return PartialView("_TestDetail", model);
        }

        /// <summary>
        /// Save Athlete to Test
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SaveNewTestDetail(TestDetailCustomModel obj)
        {

            if (obj.Distance <= 1000)
            {
                obj.Fitnessrating = "Below Average";
            }
            else if (obj.Distance > 1000 && obj.Distance <= 2000)
            {
                obj.Fitnessrating = "Average";
            }
            else if (obj.Distance > 2000 && obj.Distance <= 3500)
            {
                obj.Fitnessrating = "Good";
            }
            else if (obj.Distance > 3500)
            {
                obj.Fitnessrating = "Very Good";
            }

            int result = obj.Id > 0 ? _service.Update(obj) :_service.Insert(obj);
            return RedirectToAction("Index", "TestDetails", new { id = obj.TestId});
        }

        /// <summary>
        /// Delete Test Detail - delete athelete from test
        /// </summary>
        /// <param name="id"></param>
        /// <param name="testId"></param>
        /// <returns></returns>
        public ActionResult DeleteTestDetail(int id, int testId)
        {
            _service.Delete(id);
            return RedirectToAction("Index", "TestDetails", new { id = testId });
        }
        #endregion
    }
}