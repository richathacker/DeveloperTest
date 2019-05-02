using System;
using System.Collections.Generic;

namespace CoreDemo.Data.Entity
{
    public partial class TblUserDetail
    {
        public TblUserDetail()
        {
            TblTestDetail = new HashSet<TblTestDetail>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public int UserTypeId { get; set; }

        public virtual TblUserType UserType { get; set; }
        public virtual ICollection<TblTestDetail> TblTestDetail { get; set; }
    }
}
