using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models.Northwind.Views
{
    [Table("Summary of Sales by Year")]
    public partial class Summary_of_Sales_by_Year
    {
        public DateTime? ShippedDate { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Subtotal { get; set; }
    }
}
