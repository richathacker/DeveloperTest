using CoreDemo.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Service.TestService
{
    public interface ITestService
    {
        int Insert(TestModel entity);
        List<TestListModel> GetTestList();
        TestModel GetById(int id);
        void Delete(int key);
    }
}
