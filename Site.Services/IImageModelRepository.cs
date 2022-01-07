using Site.Models;
using System.Collections.Generic;

namespace Site.Services
{
    public interface IImageModelRepository
    {
        public IEnumerable<ImageModel> Images { get; }

        void AddImage(ImageModel image);
    }
}