using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Repositories;
using SchoolManagementSystem.UnitOfWork;
using SchoolManagementSystem.View_Models;

namespace SchoolManagementSystem.Adapter
{
   public class AccountsTeacherAdapter
    {
        UnitofWork unitOfWork;
        AccountsTeacherRepository accountsTeacherRepository;
        TeacherRepository teacherRepository;
        public AccountsTeacherAdapter()
        {
            unitOfWork = new UnitofWork();
            accountsTeacherRepository = new AccountsTeacherRepository(unitOfWork.context);
        }

        public List<AccountsTeacherViewModel> GetAllAccountsTeacher()
        {
            IEnumerable<AccountsTeacher> accounts = accountsTeacherRepository.Get();
            List<AccountsTeacherViewModel> accountsList = new List<AccountsTeacherViewModel>();
            foreach (var account in accounts)
            {
                AccountsTeacherViewModel model = new AccountsTeacherViewModel
                {
                    F_ID = account.F_ID,
                    Month = account.Month,
                    Date = account.Date,
                    Status = account.Status,
                    TeacherName = teacherRepository.GetByID(account.F_ID).EName,
                };
                accountsList.Add(model);

            }
            return accountsList;

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
        public AccountsTeacherViewModel GetAccountsTeacherById(int id)
        {
            var account = accountsTeacherRepository.GetByID(id);
            AccountsTeacherViewModel model = new AccountsTeacherViewModel
            {
                F_ID = account.F_ID,
                Month = account.Month,
                Date = account.Date,
                Status = account.Status,
                TeacherName = teacherRepository.GetByID(account.F_ID).EName,
            };
            return model;

        }
        public bool Delete(int id)
        {
            try
            {
                accountsTeacherRepository.Delete(id);
                unitOfWork.Save();
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }
        public bool Update(AccountsTeacherViewModel model)
        {
            try
            {
                AccountsTeacher account = new AccountsTeacher
                {
                    F_ID = model.F_ID,
                    Date = model.Date,
                    Status = model.Status,
                    Month = model.Month,
                    
                };
                accountsTeacherRepository.Update(account);
                unitOfWork.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Create(AccountsTeacherViewModel model)
        {
            try
            {
                AccountsTeacher account = new AccountsTeacher
                {
                    F_ID = model.F_ID,
                    Date = model.Date,
                    Status = model.Status,
                    Month = model.Month,

                };
                accountsTeacherRepository.Insert(account);
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
