using System.ComponentModel.DataAnnotations;
using Lemonade.Stand.Core.Interfaces.Entities;

namespace Lemonade.Stand.WebUI.Models
{
    public class InputFields
    {
        [Required]
        public int OrderedGlasses { get; set; }
        [Required]
        public int MoneyPaid { get; set; }
        [Required]
        public decimal FruitsAdded { get; set; }
    }
}