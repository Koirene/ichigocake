using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ichigocake.domain;
using PagedList;

namespace ichigocake.web.Models
{
    public class CakeViewModel
    {
        public CakeFilter Filter { get; set; }
        public IPagedList<Cake> CakeResults { get; set; }
        public RouteValueDictionary GetRouteValues(int pageNumber)
        {
            return new RouteValueDictionary(new
            {
                PageNumber = pageNumber.ToString(),
                CatId=Filter.CatId
            
            });
        }
        public int? Page { get; set; }
    }

    public class CakeFilter
    {
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
        public int? CatId { get; set; }
    }
}