using eLearning.Data.Base;
using eLearning.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLearning.Data.Services
{
    public class WriterService : EntityBaseRepository<Writer>, IWriterService
    {
        private readonly AppDbContext _context;

        public WriterService(AppDbContext context) : base(context) { }
    }
}
