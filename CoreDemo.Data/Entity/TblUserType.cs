using System;
using System.Collections.Generic;

namespace CoreDemo.Data.Entity
{
    public partial class TblUserType
    {
        public TblUserType()
        {
            TblUserDetail = new HashSet<TblUserDetail>();
        }

        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }

        public virtual ICollection<TblUserDetail> TblUserDetail { get; set; }
    }
}
