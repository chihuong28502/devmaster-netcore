using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models.DataModels
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DisplayName("Mã Loại")]
        public int CategoryId { get; set; }
        [DisplayName("Tên sách")]
        public string CategoryName { get; set; }

        // tạo quan hệ
        public ICollection<Book> Categories { get; set; }

    }
}
