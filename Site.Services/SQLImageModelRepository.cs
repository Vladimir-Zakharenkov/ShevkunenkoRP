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
            ImageModel image = _siteContext.ImageModels.Find(imageToUpdate.ImageId);

            image.ImageName = imageToUpdate.ImageName;
            image.ImageName2 = imageToUpdate.ImageName2;
            image.ImageDescription = imageToUpdate.ImageDescription;
            image.ImageCaption = imageToUpdate.ImageCaption;
            image.ImageContentUrl = imageToUpdate.ImageContentUrl;
            image.ImageThumbnailUrl = imageToUpdate.ImageThumbnailUrl;
            image.ImageWidth = imageToUpdate.ImageWidth;
            image.ImageHeight = imageToUpdate.ImageHeight;
            image.ImageSrc = imageToUpdate.ImageSrc;
            image.ImageAlt = imageToUpdate.ImageAlt;
            image.ImageTitle = imageToUpdate.ImageTitle;
            image.ImageType = imageToUpdate.ImageType;

            //var entry = _siteContext.ImageModels.First(e => e.ImageId == imageToUpdate.ImageId);
            //_siteContext.Entry(entry).CurrentValues.SetValues(imageToUpdate);

            _siteContext.SaveChanges();
        }
    }
}