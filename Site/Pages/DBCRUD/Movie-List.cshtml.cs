using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Collections.Generic;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class Movie_ListModel : PageModel
    {
        private readonly IMovieModelRepository _movieContext;
        public Movie_ListModel(IMovieModelRepository movieContext) => _movieContext = movieContext;

        public uint PageNumber { get; set; }

        public IEnumerable<MovieModel> AllMovies { get; set; }

        public void OnGet()
        {
            PageNumber = 91;

            AllMovies = _movieContext.Movies.ToArray();
        }
    }
}