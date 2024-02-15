using eLearning.Data.Base;
using eLearning.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLearning.Data.Services
{
    public class StudentService : EntityBaseRepository<Student>, IStudentService
    {
        private readonly AppDbContext _context;

        public StudentService(AppDbContext context) : base(context) { }
    }
}
