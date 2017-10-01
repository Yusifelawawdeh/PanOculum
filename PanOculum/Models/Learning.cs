using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PanOculum.Models
{
    public class Learning
    {
        public int Id { get; set; }
        public string CurriculumTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public string[] Courses { get; set; }
        public bool Favorate { get; set; }
    }
}