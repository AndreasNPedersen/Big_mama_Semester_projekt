using System;
using System.ComponentModel.DataAnnotations;

namespace MadOrderingssystem.Models
{
    /*
     * Lavet af:    Andreas
     * Bidraget af: 
    */
    public enum Roles
    {
        SalesPerson,
        Management,
        Customer,
        PizzaBaker
    }
    
    public class Customer
    {
        [Required,MaxLength(50, ErrorMessage = "Du har ikke skrevet noget, eller har for mange tegn")]
        public string Name { get; set; }
        [Required, MaxLength(50, ErrorMessage = "Du har ikke skrevet noget, eller har for mange tegn")]
        public string LastName { get; set; }
        [Required, MaxLength(50, ErrorMessage = "Du har ikke skrevet noget, eller har for mange tegn")]
        public string Email { get; set; }
        [Required, MaxLength(50, ErrorMessage = "Du har ikke skrevet noget, eller har for mange tegn")]
        public string Password { get; set; }
        [Required, MaxLength(50, ErrorMessage = "Du har ikke skrevet noget, eller har for mange tegn")]
        public string Address { get; set; }
        [Required, MaxLength(50, ErrorMessage = "Du har ikke skrevet noget, eller har for mange tegn")]
        public string PhoneNumber { get; set; }
        [Required]
        public int PostNumber { get; set; }

        public string ID { get; set; }
        public Roles Role { get; set; }
        public bool CustomerDiscount {get;set;}
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
