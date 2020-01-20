using SchoolManagementSystem.BaseRepository;
using SchoolManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Repositories
{
    public interface IAccountStudentRepository : IBaseRepository<AccountsStudent>
    {

    }
    public class AccountsStudentRepository : BaseRepository<AccountsStudent>, IAccountStudentRepository
    {
        public AccountsStudentRepository(SchoolDBContext Context) : base(Context)
        {


        }
    }
}