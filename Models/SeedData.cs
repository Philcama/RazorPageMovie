using Microsoft.EntityFrameworkCore;
using RazorPageMovie.Data;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPageMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPageMovieContext>>()))
            {
                if (context == null || context.movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

              
                if (context.movie.Any())
                {
                    return;  
                }

                context.movie.AddRange(
           
                );
                context.SaveChanges();
            }
        }
    }
}