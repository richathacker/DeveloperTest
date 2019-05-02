using System;
using System.Collections.Generic;

namespace CoreDemo.Data.Entity
{
    public partial class TblTestType
    {
        public TblTestType()
        {
            TblTest = new HashSet<TblTest>();
        }

        public int TypeId { get; set; }
        public string TestTypeName { get; set; }

        public virtual ICollection<TblTest> TblTest { get; set; }
    }
}
