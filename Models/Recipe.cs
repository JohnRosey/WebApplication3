using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Recipe
    {
        public int id {
            get;
            set;
        }
        [Display(Name="Nom du plat")]
        public string foodName { get; set; }
        public string Description { get; set; }
         
        public string Image { get; set; }

    }
}
