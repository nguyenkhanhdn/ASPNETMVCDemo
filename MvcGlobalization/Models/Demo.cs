using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcGlobalization.Models
{
    public class Demo
    {
        [Display(Name = "Name", ResourceType = typeof(MvcGlobalization.Resource))]
        [Required(ErrorMessageResourceType = typeof(MvcGlobalization.Resource),ErrorMessageResourceName="NameRequiredError")]
        public string Name { get; set; }

        [Display(Name = "Age", ResourceType = typeof(MvcGlobalization.Resource))]
        [Required(ErrorMessageResourceType = typeof(MvcGlobalization.Resource), ErrorMessageResourceName = "AgeRequiredError")]
        public int Age { get; set; }
    }
}