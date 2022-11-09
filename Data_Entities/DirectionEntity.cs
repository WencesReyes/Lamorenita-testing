using System.ComponentModel.DataAnnotations;

namespace Lamorenita.Data_Entities
{
    public class DirectionEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Colony { get; set; }
        [Required]
        public string Municipality { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        [Required]
        public bool Active { get; set; } = true;

        public virtual ICollection<ContactDirectionEntity>? ContactDirection { get; set; }
        public virtual ICollection<StoreDirectionEntity>? StoreDirection { get; set; }
    }
}
