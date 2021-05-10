using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace CategoryApp.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;
        
        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category(){Id = 1,Name = "Komedi"},
                new Category(){Id = 2,Name = "Korku"},
                new Category(){Id = 3,Name = "Romantik"},
                new Category(){Id = 4,Name = "Dram"},
                new Category(){Id = 5,Name = "Animasyon"}
            };
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category m)
        {
            _categories.Add(m);
        }

        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}