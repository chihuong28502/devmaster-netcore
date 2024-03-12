using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models.DataModels
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DisplayName("Mã Sách")]
        [StringLength(10)]
        public string BookId { get; set; }

        [DisplayName("Mã Sách")]
        [StringLength(200)]
        public string Title { get; set; }

        [DisplayName("Năm xuất bản")]

        public string Author { get; set; }

        [DisplayName("Giá")]

        public double? Price { get; set; }
        [DisplayName("Mô tả")]
        public string Description { get; set; }
        [DisplayName("Hình Ảnh")]

        public int? Category { get; set; }

    }
}
