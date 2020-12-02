using System;

public class Product
{
	public Product()
	{
		//Skal indeholde
		//Guid id, Pris, Product Name

		Guid _id;
		double _pris;
		string _productName;

		public Order(Guid newId, double pris, string productName)
		{
			//Guid id
			_id = newId;

			//Pris
			_pris = pris;

			//ProductName
			_productName = productName

		}
}
