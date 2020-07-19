using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspnetAjaxDemo.Models
{
    public class StutenstGroupsView
    {
        public List<Student> Students { get; set; }
        public List<Group> Groups { get; set; }
    }
}