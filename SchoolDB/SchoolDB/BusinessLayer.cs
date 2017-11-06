using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SchoolDB;

namespace BusinessLayer
{
    public interface IBusinessLayer
    {
        IList<Teacher> getAllTeachers();
        Teacher GetTeacherByID(int id);
        void addTeacher(Teacher t);
        void updateTeacher(Teacher t);
        void removeTeacher(Teacher t);
        IList<Course> getAllCourses();
        Course GetCourseByID(int id);
        void addCourse(Course c);
        void UpdateCourse(Course c);
        void RemoveCourse(Course c);
    }
    public class BusinessLayer : IBusinessLayer
    {
        private readonly ITeacherRepository teacherRepository;
        private readonly ICourseRepository courseRepository;
        public BusinessLayer()
        {
            teacherRepository = new TeacherRepository();
            courseRepository = new CourseRepository();
        }

        public void addCourse(Course c)
        {
            throw new NotImplementedException();
        }

        public void addTeacher(Teacher t)
        {
            throw new NotImplementedException();
        }

        public IList<Course> getAllCourses()
        {
            throw new NotImplementedException();
        }

        public IList<Teacher> getAllTeachers()
        {
            throw new NotImplementedException();
        }

        public Course GetCourseByID(int id)
        {
            throw new NotImplementedException();
        }

        public Teacher GetTeacherByID(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveCourse(Course c)
        {
            throw new NotImplementedException();
        }

        public void removeTeacher(Teacher t)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(Course c)
        {
            throw new NotImplementedException();
        }

        public void updateTeacher(Teacher t)
        {
            throw new NotImplementedException();
        }

        //Implement other methods

    }
}