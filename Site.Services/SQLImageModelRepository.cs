using Site.Models;
using System;
using System.Collections.Generic;

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

        public void AddImage(ImageModel image)
        {
            _siteContext.ImageModels.Add(image);
            _siteContext.SaveChanges();
        }

        public ImageModel GetImage(Guid imageId)
        {
            return _siteContext.ImageModels.Find(imageId);
        }

        public void UpdateImage(ImageModel image)
        {
            _siteContext.ImageModels.Update(image);
            _siteContext.SaveChanges();
        }
    }
}