using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ichigocake.domain;

namespace ichigocake.web.Models
{
    public class CategoryViewModel
    {
        public IList<Category> Categories { get; set; }
    }
}