﻿using Entities.Concrete;
using Entities.DTOs.Category;
using Entities.DTOs.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Blog
{
    public class GetBlogDetailDto
    {
        public int Id { get; set; }
        public GetCategoryDto Category { get; set; }
        public string Topic { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public string CoverImage { get; set; }
        public string Content { get; set; }

        public List<Tag> Tags { get; set; }
        public List<GetCommentDto> Comments { get; set; }
    }
}
