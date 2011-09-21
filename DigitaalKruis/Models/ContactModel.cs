using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using DigitaalKruisGlobal;
using System.Diagnostics;

namespace DigitaalKruis.Models
{
    [MetadataType(typeof(Contact_Validation))]
    public partial class Contact
    {
        const int SALT_LENGTH = 128;

        public enum GenderType
        {
            [Display(Name = "Male")]
            M,
            [Display(Name = "Female")]
            F,
        }

        partial void OnPasswordHashChanged()
        {
            Debug.Write(DKGlobal.GenerateSalt(SALT_LENGTH));
        }
    }

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
        [DataType(DataType.Password)]
        public string PasswordSalt { get; set; }

        [Required]
        public global::System.String Gender { get; set; }
    }
}