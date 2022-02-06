using Site.Models;
using System;
using System.Collections.Generic;

namespace Site.Services
{
    public interface IImageModelRepository
    {
        public IEnumerable<ImageModel> Images { get; }

        void AddImage(ImageModel image);

        ImageModel GetImage(Guid? imageId);

        void UpdateImage(ImageModel image);

        void DeleteImage(Guid imageId);
    }
}