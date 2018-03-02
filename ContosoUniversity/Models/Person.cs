using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public abstract class Person
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        //Composition address object into Person.
        [Display(Name = "Address")]
        public Address address { get; set; }

    }

    public class Address
    {
        [RegularExpression("^[A-Za-z0-9._%+-]+@contoso.edu$", ErrorMessage = "The email must be a contoso.edu email.")]
        public string Email { get; set; }

        public Address()
        {
            this.Email = "No_Email@contoso.edu";
        }

        public Address(string email)
        {
            this.Email = email;
        }

    }
}