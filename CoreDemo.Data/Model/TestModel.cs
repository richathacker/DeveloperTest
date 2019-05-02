using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreDemo.Data.Model
{
    public class TestModel
    {
        public int TestId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Test Type")]
        [Required]
        public int TypeId { get; set; }
    }

    public class TestListModel
    {
        public int TestId { get; set; }
        public DateTime Date { get; set; }
        public int? NoOfParticipants { get; set; }
        public string TestTypeName { get; set; }
    }
}
