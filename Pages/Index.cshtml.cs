using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public List<Recipe>Recipes {
            get;
            set;
        }
        
        public void OnGet()
        {
             String myStr = "Allo UQTR";
            Recipes = new List<Recipe>()
            {
                new Recipe {id = 1, foodName = "Poutine", Description = "Un repas du Quebec", Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/La_Banquise_Poutine.jpg/280px-La_Banquise_Poutine.jpg"},
                new Recipe {id = 2, foodName = "Pizza", Description = "Un repas de l' Amerique", Image = "https://www.hervecuisine.com/wp-content/uploads/2020/03/recette-tarte-pizza-730x520.jpg.webp"},
            };

        }
    }
}
