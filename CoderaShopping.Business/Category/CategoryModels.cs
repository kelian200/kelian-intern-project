﻿using System;

namespace CoderaShopping.Business.Models
{

    public class CategoryViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class CategoryCreateViewModel
    {
        public string Name { get; set; }
    }
}
