using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
        public Roles Role { get; set; }
        public bool CustomerDiscount {get;set;}
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="Dit navn er ikke udflydt eller har for mange tegn i sig")]
        public string Name { get; set; }
        [Required]
        [StringLength(50,ErrorMessage = "Dit efternavn er ikke udflydt eller har for mange tegn i sig")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Dit email er ikke udflydt eller har for mange tegn i sig")]
        public string Email { get; set; }
        [Required]
        [Range(4,4, ErrorMessage = "Dit postnummer er ikke udflydt eller har for mange tegn i sig")]
        public int PostNumber { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Dit password er ikke udflydt eller har for mange tegn i sig")]
        public string Password { get; set; }
        public string ID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Din adresse er ikke udflydt eller har for mange tegn i sig")]
        public string Address { get; set; }
        [Required]
        [StringLength(9, ErrorMessage = "Dit telefonnummer er ikke udflydt eller har for mange tegn i sig")]
        public string PhoneNumber { get; set; }

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
