using Site.Models;
using System.Collections.Generic;

namespace Site.Services
{
    public class MoqHeadModelRepository : IHeadModelRepository
    {
        public IEnumerable<HeadModel> HeadModels => heads;

        List<HeadModel> heads = new()
        {
            new HeadModel()
            {
                HeadId = new System.Guid(),
                PageId = 1,
                Title = "Сайт, посвященный Сергею Шевкуненко"
            },
            new HeadModel()
            {
                HeadId = new System.Guid(),
                PageId = 2,
                Title = "Сайт памяти Сергея Шевкуненко - главные страницы"
            },
            new HeadModel()
            {
                HeadId = new System.Guid(),
                PageId = 3,
                Title = "Поддержать сайт памяти Сергея Шевкуненко"
            },
            new HeadModel()
            {
                HeadId = new System.Guid(),
                PageId = 4,
                Title = "Запрашиваемая страница не найдена"
            }
        };
    }
}
