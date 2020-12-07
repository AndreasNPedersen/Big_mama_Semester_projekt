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
		//Guid id, Pris, Product Name

		string _id;
		double _pris;
		string _productName;

		public Product(string newId, double pris, string productName)
		{

			//Guid id string
			_id = newId;

			//Pris
			_pris = pris;

			//ProductName
			_productName = productName;

		}
	}
}
