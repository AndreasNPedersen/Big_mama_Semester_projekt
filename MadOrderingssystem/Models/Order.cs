using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Models
{
	public class Order
	{
		//Skal indeholde
		//Guid id,(List) Products, Customer

		List<Product> _products;
		Customer _customer;
		Guid _id;

		public Order(Customer newCustomer, List<Product> newProducts, Guid newId)
		{
			//Guid id
			_id = newId;

			//Products
			_products = newProducts;

			//Customer
			_customer = newCustomer;
		}
	}
}
