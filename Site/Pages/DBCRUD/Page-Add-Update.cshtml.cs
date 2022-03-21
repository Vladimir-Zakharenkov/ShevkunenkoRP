using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class Page_Add_UpdateModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly IImageModelRepository _imageContext;
        public Page_Add_UpdateModel(ISitemapModelRepository sitemapContext, IImageModelRepository imageContext)
        {
            _sitemapContext = sitemapContext;
            _imageContext = imageContext;
        }

        public uint PageNumber { get; set; }

        public SitemapModel SitemapItem { get; set; }

        public IFormFile ImageFile { get; set; }

        public IActionResult OnGet(Guid? sitemapModelId)
        {
            PageNumber = 81;

            if (sitemapModelId.HasValue)
            {
                ViewData["Action"] = "Edit";

                SitemapItem = _sitemapContext.Sitemaps.FirstOrDefault(p => p.SitemapModelId == sitemapModelId);

                return Page();
            }
            else
            {
                ViewData["Action"] = "Add";

                SitemapItem = new();

                return Page();
            }
        }

        public IActionResult OnPost()
        {
            PageNumber = 81;

            if (SitemapItem.SitemapModelId != Guid.Empty)
            {
                ViewData["Action"] = "Edit";
            }
            else
            {
                ViewData["Action"] = "Add";
            }

            if (SitemapItem.SitemapModelId == Guid.Empty)
            {
                if (_sitemapContext.Sitemaps.FirstOrDefault(x => x.PageNumber == 0) == null)
                {
                    SitemapItem.PageNumber = 0;
                }
                else
                {
                    SitemapItem.PageNumber = _sitemapContext.Sitemaps.Max(y => y.PageNumber) + 1;
                }

                if (_sitemapContext.Sitemaps.FirstOrDefault(x => x.Loc == SitemapItem.Loc) != null)
                {
                    ModelState.AddModelError("SitemapItem.Loc", "����� �������� ��� ����������");

                    return Page();
                }
            }

            // ���� ���� �� ������
            if (ImageFile == null)
            {
                if (SitemapItem.ImageModelImageId == Guid.Empty)
                {
                    ModelState.AddModelError("ImageFile", "�������� ����");

                    return Page();
                }
            }
            else
            {
                if (_imageContext.Images.FirstOrDefault(x => x.ImageContentUrl.Segments.Last() == ImageFile.FileName) == null)
                {
                    ModelState.AddModelError("ImageFile", "������ ����� ��� � ���� ������");

                    return Page();
                }
                else
                {
                    SitemapItem.ImageModelImageId = (_imageContext.Images.FirstOrDefault(x => x.ImageContentUrl.Segments.Last() == ImageFile.FileName).ImageId);
                }

            }

            if (ModelState.IsValid)
            {
                if (SitemapItem.SitemapModelId == Guid.Empty)
                {
                    _sitemapContext.AddSitemapItem(SitemapItem);
                }
                else
                {
                    _sitemapContext.UpdatePage(SitemapItem);
                }

                return RedirectToPage("/DBCRUD/Page-List");
            }
            else
            {
                return Page();
            }
        }
    }
}