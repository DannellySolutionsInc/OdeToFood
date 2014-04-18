﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace OdeToFood.Models
{
    public class OdeToFoodDb : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestauranReview> Review { get; set; }
    }
    
}