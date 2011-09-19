using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DigitaalKruis.Models
{
    [MetadataType(typeof(Contact_Validation))]
    public partial class Contact
    { }

    public class Contact_Validation
    {
        [Required]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public Nullable<global::System.DateTime> Birthdate { get; set; }

        [DataType(DataType.PhoneNumber)]
        public global::System.String Phone { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }

        [Required]
        public string PasswordSalt { get; set; }
    }
}