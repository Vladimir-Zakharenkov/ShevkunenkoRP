using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class ViewPagesModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        public ViewPagesModel(ISitemapModelRepository sitemapContext) => _sitemapContext = sitemapContext;

        public uint PageNumber { get; set; } = 12;

        public IList<SitemapModel> AllPages { get; set; }

        public uint? PageNumberSearchString { get; set; }

        public string LocSearchString { get; set; }

        public string LastmodSearchString { get; set; }

        public string ChangefreqSearchString { get; set; }

        public string PrioritySearchString { get; set; }

        public string LeftBackgroundSearchString { get; set; }

        public string RightBackgroundSearchString { get; set; }

        public string TitleSearchString { get; set; }

        public string DescriptionSearchString { get; set; }

        public async Task OnGetAsync()
        {
            var allpages = from page in _sitemapContext.Sitemaps
                           select page;

            if (PageNumberSearchString != null)
            {
                allpages = allpages.Where(s => s.PageNumber == PageNumberSearchString);
            }

            if (!string.IsNullOrEmpty(LocSearchString))
            {
                allpages = allpages.Where(s => s.Loc.ToString().Contains(LocSearchString));
            }

            if (!string.IsNullOrEmpty(LastmodSearchString))
            {
                allpages = allpages.Where(s => s.Lastmod.ToString().Contains(LastmodSearchString));
            }

            if (!string.IsNullOrEmpty(ChangefreqSearchString) & ChangefreqSearchString != "All")
            {
                allpages = allpages.Where(s => s.Changefreq.Contains(ChangefreqSearchString));
            }

            if (!string.IsNullOrEmpty(PrioritySearchString) & PrioritySearchString != "All")
            {
                allpages = allpages.Where(s => s.Priority.Contains(PrioritySearchString));
            }

            if (!string.IsNullOrEmpty(LeftBackgroundSearchString))
            {
                allpages = allpages.Where(s => s.LeftBackground.Contains(LeftBackgroundSearchString, StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrEmpty(RightBackgroundSearchString))
            {
                allpages = allpages.Where(s => s.RightBackground.Contains(RightBackgroundSearchString, StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrEmpty(TitleSearchString))
            {
                allpages = allpages.Where(s => s.Title.Contains(TitleSearchString, StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrEmpty(DescriptionSearchString))
            {
                allpages = allpages.Where(s => s.Description.Contains(DescriptionSearchString, StringComparison.CurrentCultureIgnoreCase));
            }

            AllPages = await allpages.ToArrayAsync();
        }
    }
}