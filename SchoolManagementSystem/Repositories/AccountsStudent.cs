using SchoolManagementSystem.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Repositories
{
    public interface IAccountStudentRepository : IBaseRepository<AccountsStudent>
    {

    }
    public class AccountStudentRepository : BaseRepository<AccountsStudent>, IAccountStudentRepository
    {
        public AccountStudentRepository(SchoolDBContext Context) : base(Context)
        {


        }
    }
}