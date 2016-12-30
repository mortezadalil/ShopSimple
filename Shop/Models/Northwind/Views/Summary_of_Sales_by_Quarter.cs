using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models.Northwind.Views
{
    [Table("Summary of Sales by Quarter")]
    public partial class Summary_of_Sales_by_Quarter
    {
        public DateTime? ShippedDate { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Subtotal { get; set; }
    }
}
