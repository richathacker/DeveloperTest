using CoreDemo.Data.Entity;
using CoreDemo.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Service.TestTypeService
{
    public class TestTypeService : ITestTypeService
    {
        #region private Member
        private readonly IRepository<TblTestType> _repository;
        #endregion

        #region Constructor
        public TestTypeService(IRepository<TblTestType> repository)
        {
            _repository = repository;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Get all Test Type List
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TblTestType> GetAll()
        {
            var obj = _repository.GetAll();
            return obj;
        }

        /// <summary>
        /// Get Test Type by Test Type Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TblTestType GetById(int id)
        {
            TblTestType obj = _repository.GetById(id);
            return obj;
        }
        #endregion
    }
}
