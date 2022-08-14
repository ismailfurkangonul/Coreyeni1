using System;

namespace Coreyeni.Data.Entities
{
    public class SalesHistory
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime SaleDate { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
