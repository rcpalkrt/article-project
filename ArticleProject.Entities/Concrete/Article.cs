using ArticleProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Entities.Concrete
{
    public class Article : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Abstract { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
