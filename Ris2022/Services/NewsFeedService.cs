using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Ris2022.Data;
using Ris2022.Data.Models;
using Ris2022.Resources;
using System.Collections.Generic;
using System.Reflection;

namespace Ris2022.Services
{
    public class NewsFeedService
    {
        private readonly RisDBContext _context;
        public readonly List<News> news = null ;
        public NewsFeedService(RisDBContext context)
        {
            _context = context;
            news = _context.News.ToList();
        }

        //public async Task<ICollection<News>>  GetNews()
        //{
        //    var news = await _context.News.ToListAsync();
        //    return news;
        //}
    }
}