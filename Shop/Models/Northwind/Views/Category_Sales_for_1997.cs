using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models.Northwind.Views
{
    [Table("Category Sales for 1997")]
    public partial class Category_Sales_for_1997
    {
        [Key]
        [StringLength(15)]
        public string CategoryName { get; set; }

        [Column(TypeName = "money")]
        public decimal? CategorySales { get; set; }
    }
}
