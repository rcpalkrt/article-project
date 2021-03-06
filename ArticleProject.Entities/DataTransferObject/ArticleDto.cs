﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Entities.DataTransferObject
{
    public class ArticleDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Abstract { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string ReleaseDate { get; set; }
    }
}
