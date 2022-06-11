using Site.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Site.Services
{
    public interface IImageModelRepository
    {
        public IAsyncEnumerable<ImageModel> Images { get; }

        Task AddImageAsync(ImageModel image);

        Task UpdateImageAsync(ImageModel image);

        Task DeleteImageAsync(Guid imageId);

        Task<ImageModel> GetImageAsync(Guid? imageId);
    }
}