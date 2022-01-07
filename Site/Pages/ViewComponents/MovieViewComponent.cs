﻿using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.ViewComponents
{
    public class Movie : ViewComponent
    {
        private readonly IMovieModelRepository _movieContext;

        public Movie(IMovieModelRepository context)
        {
            _movieContext = context;
        }

        public IViewComponentResult Invoke(string movieName)
        {
            MovieModel movie = _movieContext.GettAllMovies().FirstOrDefault(x => x.MovieName == movieName);

            return View(movie);
        }
    }
}