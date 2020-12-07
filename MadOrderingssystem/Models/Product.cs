using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Models
{
	public class Product
	{
		//Mikkel
		//Skal indeholde
		//Guid id, Price, Product Name

		public string Id { get; set; }
		public double Price { get; set; }
		public string ProductName { get; set; }

		public Product(string newId, double newPrice, string productName)
		{

			//Guid id string
			Id = newId;

			//Price
			Price = newPrice;

			//ProductName
			ProductName = productName;

		}
	}
}
