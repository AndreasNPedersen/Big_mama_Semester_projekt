using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Models
{
	public class Order
	{
		//Mikkel
		//Skal indeholde
		//Guid id,(List) Products, Customer, TotalPrice
		public string ID { get; set; }
		public List<Product> products { get; set; }
		public Customer customer {get;set;}
		public double TotalPrice { get; set; }

		public bool BuyTakeAway{ get; set; }

		public Order() {
		
		} //default constructor

		public Order(Customer newCustomer, List<Product> newProducts)
		{
			//Products
			products = newProducts;

			//Customer
			customer = newCustomer;
		}
	}
}
