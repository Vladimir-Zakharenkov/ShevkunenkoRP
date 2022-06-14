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
    public class DeleteMovieModel : PageModel
    {
        private readonly IMovieModelRepository _movieContext;
        public DeleteMovieModel(IMovieModelRepository movieContext) => _movieContext = movieContext;

        public uint PageNumber { get; set; }

        public MovieModel Movie{ get; set; }

        public async Task OnGetAsync()
        {
            PageNumber = 20;

            Movie = await _movieContext.GetMovieAsync(Movie.MovieId);

            if (Movie == null)
            {
                RedirectToPage("/DBCRUD/Movie-List");
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            PageNumber = 20;

            await _movieContext.DeleteMovieAsync(Movie.MovieId);

            return RedirectToPage("/DBCRUD/Movie-List");
        }
    }
}