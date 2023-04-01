using System;
namespace BaiTapVeNha.Models{
	public class Order{
		public Order(){

        }
        public int Id { get; set; }
        public DateTime OrderPhanced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerId { get; set; }
        public Customer Customers { get; set; } = null!;
        public ICollection<OrderDetail> OrderDetail { get; set; } = null!;
    }
}

