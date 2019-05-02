using System;
using System.Collections.Generic;

namespace CoreDemo.Data.Entity
{
    public partial class TblTestDetail
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Distance { get; set; }
        public string Fitnessrating { get; set; }
        public int? TestId { get; set; }

        public virtual TblTest Test { get; set; }
        public virtual TblUserDetail User { get; set; }
    }
}
