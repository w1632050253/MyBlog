﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Model
{
    public class BlogNews:  BaseId
    {
        [Column(TypeName = "nvarchar(30)")]
        public string Title { get; set; }

        [Column(TypeName ="text")]
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }

        public int ViewsCounts { get; set; }

        public int LikedCounts { get; set; }

        [NotMapped]
        public int TypeId { get; set; }
        [NotMapped]
        public int AuthorId { get; set; }
    }
}