using System;
using System.Collections.Generic;

namespace CoreDemo.Data.Entity
{
    public partial class TblTest
    {
        public TblTest()
        {
            TblTestDetail = new HashSet<TblTestDetail>();
        }

        public int TestId { get; set; }
        public DateTime Date { get; set; }
        public int TypeId { get; set; }

        public virtual TblTestType Type { get; set; }
        public virtual ICollection<TblTestDetail> TblTestDetail { get; set; }
    }
}
