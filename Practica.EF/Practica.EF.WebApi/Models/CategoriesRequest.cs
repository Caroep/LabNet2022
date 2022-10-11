using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Practica.EF.WebApi.Models
{
    public class CategoriesRequest
    {
        public int idCategory { get; set; }
        public string categoryName { get; set; }
        public String Description   { get; set; }
    }
}