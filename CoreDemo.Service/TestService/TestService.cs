using AutoMapper;
using CoreDemo.Data.Entity;
using CoreDemo.Data.Model;
using CoreDemo.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreDemo.Service.TestService
{
    public class TestService : ITestService
    {
        #region Privcate Member
        private readonly IRepository<TblTest> _repository;

        private IMapper _mapper { get; }

        private TestModel Map(TblTest unit)
        {
            return _mapper.Map<TestModel>(unit);
        }
        #endregion

        #region Constructor
        public TestService(IRepository<TblTest> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Get Test List By stored Procedure
        /// </summary>
        /// <returns></returns>
        public List<TestListModel> GetTestList()
        {
            IList<TestListModel> dataList;

            using (DeveloperTestContext dbContext = BaseContext.GetDbContext())
            {
                dataList = dbContext.LoadStoredProc("GetTest")
                    .ExecuteStoredProc<TestListModel>();
            }

            return dataList.ToList();
        }

        /// <summary>
        /// Get Test Detail By test id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TestModel GetById(int id)
        {
            TblTest obj = _repository.GetById(id);

            return obj == null ? new TestModel() : Map(obj);
        }

        /// <summary>
        /// Insert New Test
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Insert(TestModel entity)
        {
            TblTest obj = _mapper.Map<TestModel, TblTest>(entity);
            _repository.Insert(obj);
            return obj.TestId;
        }

        /// <summary>
        /// Delete Test
        /// </summary>
        /// <param name="key"></param>
        public void Delete(int key)
        {
            _repository.Delete(key);
        }
        #endregion
    }
}
