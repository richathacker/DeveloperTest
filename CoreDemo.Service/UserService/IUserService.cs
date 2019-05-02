using CoreDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Service.UserService
{
    public interface IUserService
    {
        IEnumerable<TblUserDetail> GetAll();
    }
}
