using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Site.Models;

namespace Site.Services
{
    public class SQLMovieModelRepository : IMovieModelRepository
    {
        private readonly SiteContext _siteContext;
        public SQLMovieModelRepository(SiteContext siteContext) => _siteContext = siteContext;

        public IAsyncEnumerable<MovieModel> Movies => _siteContext.MovieModels.Include(p => p.ImageModel).AsAsyncEnumerable();

        public async Task AddMovieAsync(MovieModel movie)
        {
            await _siteContext.MovieModels.AddAsync(movie);
            await _siteContext.SaveChangesAsync();
        }

        public async Task DeleteMovieAsync(Guid movieId)
        {
            var movieToDelete = await _siteContext.MovieModels.FindAsync(movieId);

            _siteContext.MovieModels.Remove(movieToDelete);
            await _siteContext.SaveChangesAsync();
        }

        public async Task UpdateMovieAsync(MovieModel movieToUpdate)
        {
            MovieModel movie = await _siteContext.MovieModels.FindAsync(movieToUpdate.MovieId);

            movie.MovieCaption = movieToUpdate.MovieCaption;
            movie.Duration = movieToUpdate.Duration;
            movie.DatePublished = movieToUpdate.DatePublished;
            movie.DateCreated = movieToUpdate.DateCreated;
            movie.UploadDate = movieToUpdate.UploadDate;
            movie.IsFamilyFriendly = movieToUpdate.IsFamilyFriendly;
            movie.InLanguage = movieToUpdate.InLanguage;
            movie.РroductionCompany = movieToUpdate.РroductionCompany;
            movie.Director = movieToUpdate.Director;
            movie.MusicBy = movieToUpdate.MusicBy;
            movie.Genre = movieToUpdate.Genre;
            movie.Description = movieToUpdate.Description;
            movie.DescriptionForSchemaOrg = movieToUpdate.DescriptionForSchemaOrg;
            movie.Actor01 = movieToUpdate.Actor01;
            movie.Actor02 = movieToUpdate.Actor02;
            movie.Actor03 = movieToUpdate.Actor03;
            movie.Actor04 = movieToUpdate.Actor04;
            movie.Actor05 = movieToUpdate.Actor05;
            movie.Actor06 = movieToUpdate.Actor06;
            movie.Actor07 = movieToUpdate.Actor07;
            movie.Actor08 = movieToUpdate.Actor08;
            movie.Actor09 = movieToUpdate.Actor09;
            movie.Actor10 = movieToUpdate.Actor10;
            movie.ContentUrl = movieToUpdate.ContentUrl;
            movie.CaptionForOnline = movieToUpdate.CaptionForOnline;
            movie.YouTube = movieToUpdate.YouTube;
            movie.VkVideo = movieToUpdate.VkVideo;
            movie.MailRuVideo = movieToUpdate.MailRuVideo;
            movie.OkVideo = movieToUpdate.OkVideo;
            movie.YandexDiskVideo = movieToUpdate.YandexDiskVideo;
            movie.KinoTeatrRu = movieToUpdate.KinoTeatrRu;
            movie.AspPage = movieToUpdate.AspPage;
            movie.ScreenFormat = movieToUpdate.ScreenFormat;
            movie.ImageModelImageId = movieToUpdate.ImageModelImageId;

            //var entry = _siteContext.MovieModels.First(e => e.MovieId == movieToUpdate.MovieId);
            //_siteContext.Entry(entry).CurrentValues.SetValues(movieToUpdate);

            await _siteContext.SaveChangesAsync();
        }

        public async Task<MovieModel> GetMovieAsync(Guid? movieId)
        {
            MovieModel movie = await _siteContext.MovieModels.Include(p => p.ImageModel).FirstOrDefaultAsync(m => m.MovieId == movieId);

            if (movie == null)
            {
                return null;
            }

            return movie;
        }

        public async Task<MovieModel> GetMovieByMovieCaptionAsync(string movieCaption)
        {
            MovieModel movie = await _siteContext.MovieModels.Include(p => p.ImageModel).FirstOrDefaultAsync(x => x.MovieCaption == movieCaption);

            if (movie == null)
            {
                return null;
            }

            return movie;
        }
    }
}