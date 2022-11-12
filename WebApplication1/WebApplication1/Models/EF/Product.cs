using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.EF
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Code { get; set; }
        public DateTime Created { get; set; }
    }
}