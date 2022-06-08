using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Excitel.Data;

namespace Excitel.Models
{
    public class Lead : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        [Display(Name = "Subarea")]
        public virtual int SubareaId { get; set; }

        [ForeignKey("SubareaId")]
        public virtual Subarea? Subarea { get; set; }
    }
}
