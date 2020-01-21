using SchoolManagementSystem.Data;
using SchoolManagementSystem.Repositories;
using SchoolManagementSystem.UnitOfWork;
using SchoolManagementSystem.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Adapter
{
    public class StudentAdapter
    {
        UnitofWork unitOfWork;
        StudentRepository studentRepository;
        public StudentAdapter()
        {
            unitOfWork = new UnitofWork();
            studentRepository = new StudentRepository(unitOfWork.context);
        }
        public List<StudentViewModel> GetAllStudents()
        {
            IEnumerable<Student> students = studentRepository.Get();
            List<StudentViewModel> studentsList = new List<StudentViewModel>();
            foreach (var student in students)
            {
                StudentViewModel model = new StudentViewModel
                {
                    SName = student.SName,
                    FName = student.FName,
                    Class = student.Class,
                    Contact = student.Contact,
                    Fee = student.Fee,
                    GR_NO = student.GR_NO,
                    S_ID = student.S_ID,
                };
                studentsList.Add(model);

            }
            return studentsList;

            //students.Select<Student,StudentViewModel>(x => 
            //{
            //   // List<StudentViewModel> studentList = new List<StudentViewModel>();
            //    StudentViewModel std = new StudentViewModel //
            //    {
            //        SName = x.SName,
            //        FName = x.FName,
            //        Class = x.Class,
            //        Contact = x.Contact,
            //        Fee = x.Fee,
            //        GR_NO = x.GR_NO,
            //        S_ID = x.S_ID,
            //    };
            //    studentList.Add(std);
            //}

            //);

        }
        public Student GetStudentById(int id)
        {
            var student = studentRepository.GetByID(id);
            return student;
        } 
        public bool Delete(int id)
        {
            try
            {
                studentRepository.Delete(id);
                unitOfWork.Save();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           

        }
        public bool Update(StudentViewModel studentmodel)
        {
            try
            {
                Student std = new Student
                {
                    SName = studentmodel.SName,
                    FName = studentmodel.FName,
                    Class = studentmodel.Class,
                    Contact = studentmodel.Contact,
                    Fee = studentmodel.Fee,
                    GR_NO = studentmodel.GR_NO,
                    //S_ID = studentmodel.S_ID,
                };
                studentRepository.Update(std);
                unitOfWork.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }          
          
        }
        public bool Create(StudentViewModel studentmodel)
        {
            try
            {
                Student std = new Student
                {
                    SName = studentmodel.SName,
                    FName = studentmodel.FName,
                    Class = studentmodel.Class,
                    Contact = studentmodel.Contact,
                    Fee = studentmodel.Fee,
                    GR_NO = studentmodel.GR_NO,
                    //S_ID = studentmodel.S_ID,
                };
                studentRepository.Insert(std);
                unitOfWork.Save();
                return true;


            }
            catch (Exception)
            {
                //ex.Message();
                return false;
            }
        }

    }
}
