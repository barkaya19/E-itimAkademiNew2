using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TotalLessonManager : ITotalLessonService
    {
        ITotalLessonDal _totalLessonDal;
        public TotalLessonManager(ITotalLessonDal totalLessonDal)
        {
            _totalLessonDal = totalLessonDal;
        }
        public void TAdd(TotalLesson t)
        {
            _totalLessonDal.Insert(t);
        }

        public void TDelete(TotalLesson t)
        {
            _totalLessonDal.Delete(t);
        }

        public TotalLesson TGetByID(int id)
        {
            var tlesson = _totalLessonDal.GetById(id);
            return tlesson;
        }

        public List<TotalLesson> TGetList()
        {
            return _totalLessonDal.GetList();
        }

        public void TUpdate(TotalLesson t)
        {
            _totalLessonDal.Update(t);
        }
    }
}
