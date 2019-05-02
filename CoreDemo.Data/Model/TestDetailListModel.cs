using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreDemo.Data.Model
{
    public class TestDetailListModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public int Distance { get; set; }

        public string Fitnessrating { get; set; }

        public DateTime Date { get; set; }

        public int TestId { get; set; }

        public string TestTypeName { get; set; }
    }

    public class TestDetailModel
    {
        public int TestId { get; set; }
        public string TestType { get; set; }
        public DateTime TestDate { get; set; }
        public List<TestDetailListModel> TestDetaillist { get; set; }
    }

    public class TestDetailCustomModel
    {
        public int Id { get; set; }

        [Display(Name = "User Name")]
        public int UserId { get; set; }

        [Display(Name = "Distance(meter)")]
        public int Distance { get; set; }
        public string Fitnessrating { get; set; }
        public int? TestId { get; set; }
    }

    public class TestDetailPartialModel
    {
        public int Id { get; set; }
        public int? TestId { get; set; }
    }
}
