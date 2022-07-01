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
    internal class StudentManager : IStudentService
    {
        IStudentDal _StudentDal;

        public StudentManager(IStudentDal StudentDal)
        {
            _StudentDal = StudentDal;
        }

        public void TAdd(Student t)
        {
            _StudentDal.Insert(t);
        }

        public void TDelete(Student t)
        {
            _StudentDal.Delete(t);
        }

        public Student TGetByID(int id)
        {
            var student = _StudentDal.GetById(id);
            return student;
        }

        public List<Student> TGetList()
        {
            return _StudentDal.GetList();
        }

        public void TUpdate(Student t)
        {
            _StudentDal.Update(t);
        }
    }
}
