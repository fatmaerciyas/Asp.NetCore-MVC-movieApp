using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class MovieRepository
    {
        private static List<Movie> _movies = null;
        
        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie()
                {Id = 1,
                 Name = "Name1",
                Description="<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis suscipit quisquam aliquam? Ea voluptatibus placeat, animi pariatur eius perspiciatis, sapiente eligendi velit molestias quibusdam veritatis minus natus asperiores ex ipsa.</p>",
                ShortDescription = " lorem ipsum dolor", 
                ImageUrl = "img1.jpg",
                CategoryId = 1
                },
                
                new Movie()
                {Id = 2,
                Name = "Name2", 
                Description = "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis suscipit quisquam aliquam? Ea voluptatibus placeat, animi pariatur eius perspiciatis, sapiente eligendi velit molestias quibusdam veritatis minus natus asperiores ex ipsa.</p>",
                ShortDescription = " sit amet",
                 ImageUrl = "img2.jpg",
                CategoryId = 2
                },

                new Movie()
                {Id = 3, 
                Name = "Name3", 
                Description="<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis suscipit quisquam aliquam? Ea voluptatibus placeat, animi pariatur eius perspiciatis, sapiente eligendi velit molestias quibusdam veritatis minus natus asperiores ex ipsa.</p>",
                ShortDescription = "acçıklama ", 
                ImageUrl = "img3.jpg",
                CategoryId = 2
                },

                new Movie()
                {Id = 4, 
                Name = "Name4",
                Description="<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis suscipit quisquam aliquam? Ea voluptatibus placeat, animi pariatur eius perspiciatis, sapiente eligendi velit molestias quibusdam veritatis minus natus asperiores ex ipsa.</p>",
                ShortDescription = " vdzbadnadgdgn", 
                ImageUrl = "img4.jpg",
                CategoryId = 3
                },

                new Movie()
                {Id = 5, 
                Name = "Name5",
                Description="<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis suscipit quisquam aliquam? Ea voluptatibus placeat, animi pariatur eius perspiciatis, sapiente eligendi velit molestias quibusdam veritatis minus natus asperiores ex ipsa.</p>",
                ShortDescription = " sşdknskldvnksvdn",
                ImageUrl = "img5.jpg",
                CategoryId = 3
                }
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie m)
        {
            _movies.Add(m);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}