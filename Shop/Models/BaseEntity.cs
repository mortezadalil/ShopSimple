using System;

namespace Shop.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreateDateTime = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}