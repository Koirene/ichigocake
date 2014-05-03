using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ichigocake.common.Resources;
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
                CatId = Filter.CatId

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
    public class CakeDetailViewModel
    {
        public Cake Cake { get; set; }
        [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "NameAndSurnameRequired")]
        // [RegularExpression(@"^\s*([a-zA-ZığĞüÜşŞİöÖçÇ]{2,})+\s+([a-zA-ZığĞüÜşŞİöÖçÇ]{2,})+[a-zA-ZığĞüÜşŞİöÖçÇ\s]*$", ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "NameAndSurnameInvalid")]
        public string FullName { get; set; }
        [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "EmailRequired")]
        [EmailAddress(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "InvalidEmail", ErrorMessage = null)]
        public string Email { get; set; }
        [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "PhoneNumberRequired")]
        public string Phone { get; set; }
        [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "AddressRequired")]
        public string Address { get; set; }
        [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "RequestedDateTimeRequired")]
        public DateTime RequestedDate { get; set; }
        [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "RequestedDateTimeRequired")]
        public DateTime RequestedTime { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessageResourceType = typeof(ErrorStrings), ErrorMessageResourceName = "PersonAmountRequired")]
        public int PersonAmount { get; set; }
    }

}