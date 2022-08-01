﻿using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.GenericRepository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(BlogContext context) : base(context)
        {
        }
    }
}
