using CoreDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Service.TestTypeService
{
    public interface ITestTypeService
    {
        IEnumerable<TblTestType> GetAll();
        TblTestType GetById(int id);
    }
}
