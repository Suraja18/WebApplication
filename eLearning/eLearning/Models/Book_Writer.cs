using System.ComponentModel.DataAnnotations.Schema;

namespace eLearning.Models
{
    public class Book_Writer
    {
        public int books_Id { get; set; }
       // [ForeignKey("Book_ID")]
        public Books Books { get; set; }
        public int writer_Id { get; set; }
       // [ForeignKey("Writer_ID")]
        public Writer Writer { get; set; }

    }
}
