    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsOrNotApi.Models;

namespace NewsOrNotApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly NewsOrNotContext _context;

        public ArticlesController(NewsOrNotContext context)
        {
            _context = context;

            if (_context.Articles.Count() == 0)
            {
                _context.Articles.Add(new Article
                {
                    Id = 0,
                    News = false,
                    Content = "Fake news",
                });
                _context.SaveChanges();
            }
        }
    }
}