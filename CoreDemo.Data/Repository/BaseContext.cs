using CoreDemo.Data.Common;
using CoreDemo.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDemo.Data.Repository
{
    public class BaseContext
    {
        public static DeveloperTestContext GetDbContext()
        {
            var dbOptions = new DbContextOptionsBuilder<DeveloperTestContext>();
            dbOptions.UseSqlServer(CommonHelper.ConnectionString);
            var dbContext = new DeveloperTestContext(dbOptions.Options);
            return dbContext;
        }
    }
}
