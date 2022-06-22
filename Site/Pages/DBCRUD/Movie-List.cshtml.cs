using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class Movie_ListModel : PageModel
    {
        private readonly IMovieModelRepository _movieContext;
        public Movie_ListModel(IMovieModelRepository movieContext) => _movieContext = movieContext;

        public uint PageNumber { get; set; }

        public IList<MovieModel> AllMovies { get; set; }

        public string MovieCaptionSearchString { get; set; }

        public string ActorSearchString { get; set; } = null;

        public async Task OnGetAsync()
        {
            PageNumber = 91;

            var allmovies = from m in _movieContext.Movies
                            select m;

            if (!string.IsNullOrEmpty(MovieCaptionSearchString))
            {
                allmovies = allmovies.Where(s => s.MovieCaption.Contains(MovieCaptionSearchString));
            }

            if (!string.IsNullOrEmpty(ActorSearchString))
            {
                allmovies = allmovies.Where(s => s.Actor01.Contains(ActorSearchString)
                                                || s.Actor02.Contains(ActorSearchString)
                                                || s.Actor03.Contains(ActorSearchString)
                                                || s.Actor04.Contains(ActorSearchString)
                                                || s.Actor05.Contains(ActorSearchString)
                                                || s.Actor06.Contains(ActorSearchString)
                                                || s.Actor07.Contains(ActorSearchString)
                                                || s.Actor08.Contains(ActorSearchString)
                                                || s.Actor09.Contains(ActorSearchString)
                                                || s.Actor10.Contains(ActorSearchString)
                                                );
            }

            AllMovies = await allmovies.ToListAsync();
        }
    }
}