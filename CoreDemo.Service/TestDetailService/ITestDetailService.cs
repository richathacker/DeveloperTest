using CoreDemo.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Service.TestDetailService
{
    public interface ITestDetailService
    {
        List<TestDetailListModel> GetTestDetailList(int TestId);
        int Insert(TestDetailCustomModel entity);
        TestDetailCustomModel GetById(int id);
        int Update(TestDetailCustomModel entity);
        void Delete(int key);
    }
}
