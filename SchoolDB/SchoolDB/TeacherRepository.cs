using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB
{

    interface ITeacherRepository : IRepository<Teacher>
    {

    }

    interface ICourseRepository : IRepository<Course>
    {

    }

    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        public TeacherRepository() : base(new SchoolDBEntities())
        {
        }
    }

    public class CourseRepository : Repository<Course>, ICourseRepository
    {

        public CourseRepository(): base(new SchoolDBEntities())
        {
        }
    }
}
