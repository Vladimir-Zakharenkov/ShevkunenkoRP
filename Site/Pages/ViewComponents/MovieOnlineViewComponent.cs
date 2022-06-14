using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Site.Models;
using Site.Services;

namespace Site.Pages.ViewComponents
{
    public class MovieOnline : ViewComponent
    {
        private readonly IMovieModelRepository _movieContext;
        private readonly ISitemapModelRepository _pagenumberContext;

        public MovieOnline(IMovieModelRepository movieContext, ISitemapModelRepository pagenumberContext)
        {
            _movieContext = movieContext;
            _pagenumberContext = pagenumberContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(uint pageNumber, string videoProvider)
        {
            MovieModel movie = await _movieContext.GetMovieAsync(_pagenumberContext.GetPage(pageNumber).MovieModelMovieId);


            if (movie == null)
            {
                // обработать исключение
            }

            ViewData["VideoProvider"] = movie.YouTube;
            ViewData["youtubeBorder"] = "videoBorder";
            ViewData["vkvideoBorder"] = null;
            ViewData["mailruvideoBorder"] = null;
            ViewData["okvideoBorder"] = null;

            if (videoProvider == "youtube")
            {
                ViewData["VideoProvider"] = movie.YouTube;
                ViewData["youtubeBorder"] = "videoBorder";
            }

            if (videoProvider == "vkvideo")
            {
                ViewData["VideoProvider"] = movie.VkVideo;
                ViewData["vkvideoBorder"] = "videoBorder";
                ViewData["youtubeBorder"] = null;
            }

            if (videoProvider == "mailruvideo")
            {
                ViewData["VideoProvider"] = movie.MailRuVideo;
                ViewData["mailruvideoBorder"] = "videoBorder";
                ViewData["youtubeBorder"] = null;
            }

            if (videoProvider == "okvideo")
            {
                ViewData["VideoProvider"] = movie.OkVideo;
                ViewData["okvideoBorder"] = "videoBorder";
                ViewData["youtubeBorder"] = null;
            }

            return View(movie);
        }
    }
}