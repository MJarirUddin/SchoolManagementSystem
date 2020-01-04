using SchoolManagementSystem.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Repositories
{
    public interface ITeacherRepository : IBaseRepository<Teacher>
    {

    }
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(SchoolDBContext Context) : base(Context)
        {


        }

    }

}