using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Site.Services
{
    public class SQLImageModelRepository : IImageModelRepository
    {
        private readonly SiteContext _siteContext;
        public SQLImageModelRepository(SiteContext siteContext)
        {
            _siteContext = siteContext;
        }

        public IEnumerable<ImageModel> Images => _siteContext.ImageModels;

        public ImageModel GetImage(Guid? imageId)
        {
            return _siteContext.ImageModels.Find(imageId);
        }

        public void AddImage(ImageModel image)
        {
            _siteContext.ImageModels.Add(image);
            _siteContext.SaveChanges();
        }

        public void DeleteImage(Guid imageId)
        {
            var imageToDelete = _siteContext.ImageModels.Find(imageId);

            _siteContext.ImageModels.Remove(imageToDelete);
            _siteContext.SaveChanges();
        }

        public void UpdateImage(ImageModel imageToUpdate)
        {
            var entry = _siteContext.ImageModels.First(e => e.ImageId == imageToUpdate.ImageId);
            _siteContext.Entry(entry).CurrentValues.SetValues(imageToUpdate);
            _siteContext.SaveChanges();
        }
    }
}