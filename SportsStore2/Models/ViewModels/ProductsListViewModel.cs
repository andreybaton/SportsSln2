﻿using System.Collections.Generic;
using SportsStore2.Models;

namespace SportsStore2.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
