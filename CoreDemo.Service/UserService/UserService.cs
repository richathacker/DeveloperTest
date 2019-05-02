using CoreDemo.Data.Entity;
using CoreDemo.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Service.UserService
{
    public class UserService : IUserService
    {
        #region private Member
        private readonly IRepository<TblUserDetail> _repository;
        #endregion

        #region Constructor
        public UserService(IRepository<TblUserDetail> repository)
        {
            _repository = repository;
        }
        #endregion

        #region Methods

        /// <summary>
        /// User List 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TblUserDetail> GetAll()
        {
            var obj = _repository.GetAll();
            return obj;
        }
        #endregion

    }
}
