﻿using Product.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Product.Models
{
    public class Database
    {
        public Products Products { get; set; }
        public Database()
        {
            string connString = @"Server=DESKTOP-U1M0RMC;Database=Product;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            Products = new Products(conn);
        }
    }
}