using System;

public class Product
{
	//Skal indeholde
	//Guid id, Pris, Product Name

	public Product(Guid newId, double pris, string productName)
	{

		Guid _id;
		double _pris;
		string _productName;

		//Guid id
		_id = newId;

		//Pris
		_pris = pris;

		//ProductName
		_productName = productName;

	}
}
