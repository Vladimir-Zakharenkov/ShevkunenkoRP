using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Sitemaps
{
    public class sitemapModel : PageModel
    {
        // StringBuilder sb = new StringBuilder();
        // method which returns sitemap formatted xml string from db
        // sb.Append(XmlGeneratedStringFromDataBase());

        public string sb { get; set; }
        public IActionResult OnGet()
        {
            sb = @"<?xml version=""1.0"" encoding=""UTF-8"" ?>
                    <urlset xmlns=""http://www.sitemaps.org/schemas/sitemap/0.9""
                        xmlns:xsi = ""http://www.w3.org/2001/XMLSchema-instance""
                        xsi:schemaLocation = ""http://www.sitemaps.org/schemas/sitemap/0.9
                            http://www.sitemaps.org/schemas/sitemap/0.9/sitemap.xsd"">
                        <url>
                            <loc>Index</loc>
                            <lastmod>2022-01-25T17:28:47+00:00</lastmod>
                            <priority>0.5</priority>
                        </url>
                    </urlset>
                    ";

            return new ContentResult
            {
                ContentType = "application/xml",
                Content = sb.ToString(),
                StatusCode = 200
            };

        }
    }
}
