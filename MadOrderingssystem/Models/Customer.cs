using System;
using System.ComponentModel.DataAnnotations;

namespace MadOrderingssystem.Models
{
    //Andreas
    public enum Roles
    {
        SalesPerson,
        Management,
        Customer,
        PizzaBaker
    }
    
    public class Customer
    {
        //[Required,MaxLength(50)]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ID { get; set; }
        public Roles Role { get; set; }
        public bool CustomerDiscount {get;set;}
        public int PostNumber { get; set; }
        public DateTime Date { get; set; }

        public Customer() { }
        public Customer(Roles newRole, string newName, string newLastName, string newEmail, int newPostNumber, string newPassward,
            string newAddress, string newPhoneNumber)
        {
            Role = newRole;
            Name = newName;
            LastName = newLastName;
            Email = newEmail;
            PostNumber = newPostNumber;
            Password = newPassward;
            Address = newAddress;
            PhoneNumber = newPhoneNumber;
        }
    }
}
