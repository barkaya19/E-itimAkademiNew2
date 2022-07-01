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
    public class LessonManager : ILessonService
    {
        ILessonDal _lessonDal;
        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }
        public void TAdd(Lesson t)
        {
            _lessonDal.Insert(t);
        }

        public void TDelete(Lesson t)
        {
            _lessonDal.Delete(t);
        }

        public Lesson TGetByID(int id)
        {
            var result = _lessonDal.GetById(id);
            return result;
        }

        public List<Lesson> TGetList()
        {
            return _lessonDal.GetList();
        }

        public void TUpdate(Lesson t)
        {
            _lessonDal.Update(t);
        }
    }
}
