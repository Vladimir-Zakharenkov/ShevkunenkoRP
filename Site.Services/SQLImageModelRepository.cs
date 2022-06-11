using Microsoft.EntityFrameworkCore;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Site.Services
{
    public class SQLImageModelRepository : IImageModelRepository
    {
        private readonly SiteContext _siteContext;
        public SQLImageModelRepository(SiteContext siteContext) => _siteContext = siteContext;

        public IAsyncEnumerable<ImageModel> Images => _siteContext.ImageModels;

        public async Task<ImageModel> GetImageAsync(Guid? imageId)
        {
            return await _siteContext.ImageModels.FirstOrDefaultAsync(i => i.ImageId == imageId);
        }

        public async Task AddImageAsync(ImageModel image)
        {
            await _siteContext.ImageModels.AddAsync(image);
            await _siteContext.SaveChangesAsync();
        }

        public async Task DeleteImageAsync(Guid imageId)
        {
            var imageToDelete = await _siteContext.ImageModels.FindAsync(imageId);

            _siteContext.ImageModels.Remove(imageToDelete);
            await _siteContext.SaveChangesAsync();
        }

        public async Task UpdateImageAsync(ImageModel imageToUpdate)
        {
            ImageModel image = await _siteContext.ImageModels.FindAsync(imageToUpdate.ImageId);

            image.ImageDescription = imageToUpdate.ImageDescription;
            image.ImageCaption = imageToUpdate.ImageCaption;
            image.ImageContentUrl = imageToUpdate.ImageContentUrl;
            image.ImageWidth = imageToUpdate.ImageWidth;
            image.ImageHeight = imageToUpdate.ImageHeight;
            image.ImageThumbnailUrl = imageToUpdate.ImageThumbnailUrl;
            image.ImageThumbnailWidth = imageToUpdate.ImageThumbnailWidth;
            image.ImageThumbnailHeight = imageToUpdate.ImageThumbnailHeight;
            image.ImageAlt = imageToUpdate.ImageAlt;

            //var entry = _siteContext.ImageModels.First(e => e.ImageId == imageToUpdate.ImageId);
            //_siteContext.Entry(entry).CurrentValues.SetValues(imageToUpdate);

            await _siteContext.SaveChangesAsync();
        }
    }
}