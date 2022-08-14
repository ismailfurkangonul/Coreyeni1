using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Coreyeni.Data.Entities
{
    public class Product : DbContext
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<SalesHistory>SalesHistory{get;set;}
    }
}
