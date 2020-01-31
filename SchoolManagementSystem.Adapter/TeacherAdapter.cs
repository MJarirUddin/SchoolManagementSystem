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
        public TeacherViewModel GetTeacherById(int id)
        {
            var teacher = teacherRepository.GetByID(id);
            TeacherViewModel viewModel = new TeacherViewModel
            {
                EName = teacher.EName,
                Address = teacher.Address,
                CNIC = teacher.CNIC,
                Contact = teacher.Contact,
                Email = teacher.Email,
                EMP_ID = teacher.EMP_ID,
                F_ID = teacher.F_ID,
                Salary = teacher.F_ID,
                Qualification =teacher.Qualification
            };
            return viewModel;
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
                    Qualification = teachermodel.Qualification,
                    Salary = teachermodel.Salary,
                    Address= teachermodel.Address,
                    CNIC = teachermodel.CNIC,
                    Email = teachermodel.Email,
                    Contact = teachermodel.Contact,
                    EMP_ID = teachermodel.EMP_ID,

                     
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
