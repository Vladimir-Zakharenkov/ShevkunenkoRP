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
            if (movie.Director == null) movie.Director = string.Empty;
            if (movie.MusicBy == null) movie.MusicBy = string.Empty;
            if (movie.Actor01 == null) movie.Actor01 = string.Empty;
            if (movie.Actor02 == null) movie.Actor02 = string.Empty;
            if (movie.Actor03 == null) movie.Actor03 = string.Empty;
            if (movie.Actor04 == null) movie.Actor04 = string.Empty;
            if (movie.Actor05 == null) movie.Actor05 = string.Empty;
            if (movie.Actor06 == null) movie.Actor06 = string.Empty;
            if (movie.Actor07 == null) movie.Actor07 = string.Empty;
            if (movie.Actor08 == null) movie.Actor08 = string.Empty;
            if (movie.Actor09 == null) movie.Actor09 = string.Empty;
            if (movie.Actor10 == null) movie.Actor10 = string.Empty;
            if (movie.Note == null) movie.Note = string.Empty;

            await _siteContext.MovieModels.AddAsync(movie);
            await _siteContext.SaveChangesAsync();
        }

        public async Task DeleteMovieAsync(Guid movieId)
        {
            MovieModel movieToDelete = await _siteContext.MovieModels.FindAsync(movieId);

            _siteContext.MovieModels.Remove(movieToDelete);
            await _siteContext.SaveChangesAsync();
        }

        public async Task UpdateMovieAsync(MovieModel movieToUpdate)
        {
            if (movieToUpdate.Director == null) movieToUpdate.Director = string.Empty;
            if (movieToUpdate.MusicBy == null) movieToUpdate.MusicBy = string.Empty;
            if (movieToUpdate.Actor01 == null) movieToUpdate.Actor01 = string.Empty;
            if (movieToUpdate.Actor02 == null) movieToUpdate.Actor02 = string.Empty;
            if (movieToUpdate.Actor03 == null) movieToUpdate.Actor03 = string.Empty;
            if (movieToUpdate.Actor04 == null) movieToUpdate.Actor04 = string.Empty;
            if (movieToUpdate.Actor05 == null) movieToUpdate.Actor05 = string.Empty;
            if (movieToUpdate.Actor06 == null) movieToUpdate.Actor06 = string.Empty;
            if (movieToUpdate.Actor07 == null) movieToUpdate.Actor07 = string.Empty;
            if (movieToUpdate.Actor08 == null) movieToUpdate.Actor08 = string.Empty;
            if (movieToUpdate.Actor09 == null) movieToUpdate.Actor09 = string.Empty;
            if (movieToUpdate.Actor10 == null) movieToUpdate.Actor10 = string.Empty;
            if (movieToUpdate.Note == null) movieToUpdate.Note = string.Empty;

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
            movie.Note = movieToUpdate.Note;

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