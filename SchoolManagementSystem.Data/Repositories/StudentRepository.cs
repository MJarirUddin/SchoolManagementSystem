using SchoolManagementSystem.BaseRepository;
using SchoolManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Repositories
{
    public interface IStudentRepository:IBaseRepository<Student>
    {    
    }
    public class StudentRepository: BaseRepository<Student>,IStudentRepository
    {
        public StudentRepository(SchoolDBContext Context):base(Context)
        {            
        }
    }
}   
