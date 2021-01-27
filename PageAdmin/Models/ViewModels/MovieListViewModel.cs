using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageAdmin.Models.ViewModels
{
    public class MovieListViewModel
    {
        public virtual Movie Movie { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
