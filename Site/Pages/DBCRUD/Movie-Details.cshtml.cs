using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class Movie_DetailsModel : PageModel
    {
        private readonly IMovieModelRepository _movieContext;
        public Movie_DetailsModel(IMovieModelRepository movieContext) => _movieContext = movieContext;

        public uint PageNumber { get; set; }

        public MovieModel Movie { get; set; }

        public async Task OnGetAsync()
        {
            PageNumber = 92;

            Movie = await _movieContext.GetMovieAsync(Movie.MovieId);

            if (Movie == null)
            {
                RedirectToPage("/DBCRUD/Movie-List");
            }
        }
    }
}