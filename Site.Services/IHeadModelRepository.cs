using Site.Models;
using System.Collections.Generic;

namespace Site.Services
{
    public interface IHeadModelRepository
    {
        public IEnumerable<HeadModel> HeadModels { get; }
    }
}
