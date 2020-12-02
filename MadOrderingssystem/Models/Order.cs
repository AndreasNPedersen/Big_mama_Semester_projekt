using MadOrderingssystem.Models;
using System;
using System.Collections.Generic;

public class Order
{
	//Skal indeholde
	//Guid id,(List) Products, Customer

	public Order(Customer newCustomer, List<Product> newProducts, Guid newId)
	{
		List<Product> _products;
		Customer _customer;
		Guid _id;

		//Guid id
		_id = newId;

		//Products
		_products = newProducts;

		//Customer
		_customer = newCustomer;
	}	
}
