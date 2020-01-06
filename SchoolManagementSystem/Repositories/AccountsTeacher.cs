using SchoolManagementSystem.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Repositories
{
    public interface IAccountTeacherRepository : IBaseRepository<AccountsTeacher>
    {

    }
    public class AccountTeacherRepository : BaseRepository<AccountsTeacher>, IAccountTeacherRepository
    {
        public AccountTeacherRepository(SchoolDBContext Context) : base(Context)
        {


        }
    }
}