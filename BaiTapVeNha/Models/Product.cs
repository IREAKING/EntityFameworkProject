using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapVeNha.Models{
	public class Product{
		public Product(){

		}
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
    }
}

