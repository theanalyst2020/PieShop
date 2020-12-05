using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class CategoryRepository : ICategory
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category {CategoryId=1, CategoryName="Cupcakes", Description="20 pieces of cupcakes"},
            new Category {CategoryId=2, CategoryName="Cheese Cakes", Description="Cheesy all the way"},
            new Category {CategoryId=1, CategoryName="Fruit pies", Description="All-fruity pies"}

        };
    }
}
