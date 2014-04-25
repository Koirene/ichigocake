using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ichigocake.domain;
using ichigocake.domain.Content;

namespace ichigocake.admin.Models
{
    public class CakeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public virtual List<Image> CakeImages { get; set; }
        public bool IsDecorative { get; set; }
        public double PiePrice { get; set; }
    }

    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Image Image { get; set; }
        public int MaxDaytoOrder { get; set; }
    }
}