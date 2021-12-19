using Site.Models;
using System.Collections.Generic;

namespace Site.Services
{
    public interface IImageModelRepository
    {
        IEnumerable<ImageModel> GetAllImages();
    }
}
