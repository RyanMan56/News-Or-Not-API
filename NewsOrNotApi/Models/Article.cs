using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsOrNotApi.Models
{
    public class Article
    {
        public int Id { get; set; }
        public bool News { get; set; }
        public string Content { get; set; }
    }
}
