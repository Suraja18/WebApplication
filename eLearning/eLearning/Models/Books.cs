using eLearning.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eLearning.Models
{
    public class Books : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Course { get; set; }
        public DateTime Publishdate { get; set; }
        //Relationships
        public List<Book_Writer> Book_Writer { get; set; }

    }
}
