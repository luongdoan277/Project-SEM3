using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PageAdmin.Models.ViewModels
{
    public class ShopListViewModel
    {
        //public IEnumerable<Category> Categories { get; set; }
        //public IEnumerable<Shop> Shops { get; set; }
        public virtual Category Categories { get; set; }
        public virtual Shop Shops { get; set; }
        //[Display(Name = "Image")]
        //public IFormFile Image { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
