using Site.Models;
using System.Collections.Generic;

namespace Site.Services
{
    public class SQLHeadModelRepository : IHeadModelRepository
    {
        public SiteContext Context { get; }

        public SQLHeadModelRepository(SiteContext context)
        {
            Context = context;
        }

        public IEnumerable<HeadModel> HeadModels => Context.HeadModels;

    }
}
