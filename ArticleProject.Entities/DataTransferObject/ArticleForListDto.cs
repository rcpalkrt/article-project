﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Entities.DataTransferObject
{
    public class ArticleForListDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ReleaseDate { get; set; }
    }
}
