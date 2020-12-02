using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Models
{
	public class Product
	{
		//Skal indeholde
		//Guid id, Pris, Product Name

		Guid _id;
		double _pris;
		string _productName;

		public Product(Guid newId, double pris, string productName)
		{

			//Guid id
			_id = newId;

			//Pris
			_pris = pris;

			//ProductName
			_productName = productName;

		}
	}
}
