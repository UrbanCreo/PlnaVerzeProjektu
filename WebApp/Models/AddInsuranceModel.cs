using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Models
{
    public class AddInsuranceModel
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Pojištění")]
        public string TypPojisteni { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Částka")]
        public decimal Castka { get; set; }

        [Required]
        [Display(Name = "Předmět pojištění")]
        public string Predmet { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Platnost od")]
        public DateTime PlatnostOd { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Platnost do")]
        public DateTime PlatnostDo { get; set; }
    }
}