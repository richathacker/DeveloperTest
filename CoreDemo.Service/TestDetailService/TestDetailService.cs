using AutoMapper;
using CoreDemo.Data.Entity;
using CoreDemo.Data.Model;
using CoreDemo.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreDemo.Service.TestDetailService
{
    public class TestDetailService : ITestDetailService
    {
        #region Private Member
        private readonly IRepository<TblTestDetail> _repository;

        private IMapper _mapper { get; }

        private TestDetailCustomModel Map(TblTestDetail unit)
        {
            return _mapper.Map<TestDetailCustomModel>(unit);
        }
        #endregion

        #region Constructor
        public TestDetailService(IRepository<TblTestDetail> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Gets test details by test id using stored procedure
        /// </summary>
        /// <param name="TestId"></param>
        /// <returns></returns>
        public List<TestDetailListModel> GetTestDetailList(int TestId)
        {
            IList<TestDetailListModel> dataList;

            using (DeveloperTestContext dbContext = BaseContext.GetDbContext())
            {
                dataList = dbContext.LoadStoredProc("GetTestDetail")
                    .WithSqlParam("TestId", TestId)
                    .ExecuteStoredProc<TestDetailListModel>();
            }

            return dataList.ToList();
        }

        /// <summary>
        /// Insert Athlete to test
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Insert(TestDetailCustomModel entity)
        {
            TblTestDetail obj = _mapper.Map<TestDetailCustomModel, TblTestDetail>(entity);
            _repository.Insert(obj);
            return obj.Id;
        }

        /// <summary>
        /// Get Test detail by test detail Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TestDetailCustomModel GetById(int id)
        {
            TblTestDetail obj = _repository.GetById(id);

            return obj == null ? new TestDetailCustomModel() : Map(obj);
        }

        /// <summary>
        /// Update test detail
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Update(TestDetailCustomModel entity)
        {
            TblTestDetail obj = _mapper.Map<TestDetailCustomModel, TblTestDetail>(entity);
            _repository.Update(obj);
            return obj.Id;
        }

        /// <summary>
        /// delete test detail - athelete from test
        /// </summary>
        /// <param name="key"></param>
        public void Delete(int key)
        {
            _repository.Delete(key);
        }

        #endregion
    }
}
