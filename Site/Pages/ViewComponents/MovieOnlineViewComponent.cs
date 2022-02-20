using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;

namespace Site.Pages.ViewComponents
{
    public class MovieOnline : ViewComponent
    {
        private readonly IMovieModelRepository _movieContext;
        public MovieOnline(IMovieModelRepository movieContext)
        {
            _movieContext = movieContext;
        }

        public IViewComponentResult Invoke(string movieCaption, string videoProvider)
        {
            MovieModel movie = _movieContext.GetMovieByMovieCaption(movieCaption);

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