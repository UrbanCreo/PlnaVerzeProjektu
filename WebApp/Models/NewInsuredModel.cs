using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApp.Models;

namespace WebApp.Models
{
    public class NewInsuredModel
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Jméno")]
        public string Jmeno { get; set; } = "";

        [Required]
        [Display(Name = "Příjmení")]
        public string Prijmeni { get; set; } = "";

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } = "";

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefon")]
        public string Telefon { get; set; } = "";

        [Required]
        [Display(Name = "Ulice a číslo popisné")]
        public string Ulice { get; set; } = "";

        [Required]
        [Display(Name = "Město")]
        public string Mesto { get; set; } = "";

        [Required]
        [DataType(DataType.PostalCode)]
        [Display(Name = "PSČ")]
        public string PSC { get; set; } = "";
    }
}