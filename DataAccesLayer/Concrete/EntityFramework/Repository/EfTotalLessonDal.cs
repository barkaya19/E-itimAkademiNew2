﻿using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.EntityFramework
{
    public class EfTotalLessonDal:GenericRepository<TotalLesson>,ITotalLessonDal
    {
    }
}
