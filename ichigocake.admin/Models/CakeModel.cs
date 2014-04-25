using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ichigocake.domain;
using ichigocake.domain.Content;

namespace ichigocake.admin.Models
{
    public class CakeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public virtual Image CakeImage { get; set; }
        public string ImageDescription { get; set; }
        public bool IsDecorative { get; set; }
        public double PiePrice { get; set; }
    }
}