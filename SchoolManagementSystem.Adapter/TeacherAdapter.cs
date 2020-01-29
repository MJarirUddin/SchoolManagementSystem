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
    public class TeacherAdapter
    {
        UnitofWork unitOfWork;
        TeacherRepository teacherRepository;
        public TeacherAdapter()
        {
            unitOfWork = new UnitofWork();
            teacherRepository = new TeacherRepository(unitOfWork.context);
        }
        public List<TeacherViewModel> GetAllTeachers()
        {
            IEnumerable<Teacher> teachers = teacherRepository.Get();
            List<TeacherViewModel> teachersList = new List<TeacherViewModel>();
            foreach (var teacher in teachers)
            {
                TeacherViewModel model = new TeacherViewModel
                {
                    EName = teacher.EName,
                    CNIC = teacher.CNIC,
                    Qualification = teacher.Qualification,
                    Address = teacher.Address,
                    Contact = teacher.Contact,
                    Email = teacher.Email,
                    Salary = teacher.Salary, 
                    EMP_ID = teacher.EMP_ID,
                    F_ID = teacher.F_ID
                };
                teachersList.Add(model);

            }
            return teachersList;
        }
        public Teacher GetTeacherById(int id)
        {
            var teacher = teacherRepository.GetByID(id);
            return teacher;
        }
        public bool Delete(int id)
        {
            try
            {
                teacherRepository.Delete(id);
                unitOfWork.Save();
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }
        public bool Update(TeacherViewModel teachermodel)
        {
            try
            {
                Teacher tea = new Teacher 
                {
                    CNIC = teachermodel.CNIC,
                    Qualification = teachermodel.Qualification,
                    Address = teachermodel.Address,
                    Contact = teachermodel.Contact,
                    Email = teachermodel.Email,
                    Salary = teachermodel.Salary,
                    EMP_ID = teachermodel.EMP_ID,
                    //F_ID = teachermodel.F_ID
                };
                teacherRepository.Update(tea);
                unitOfWork.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Create(TeacherViewModel teachermodel)
        {
            try
            {
                Teacher tea = new Teacher 
                {
                    EName = teachermodel.EName,
                     
                };
                teacherRepository.Insert(tea);
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
