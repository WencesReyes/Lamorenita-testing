using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lamorenita.Data_Entities
{
    public class StoreDirectionEntity
    {
        [Key]
        public int Id { get; set; }
        public int? StoreId { get; set; }
        [ForeignKey("StoreId")]
        public virtual StoreEntity? Store { get; set; }
        public int? DirectionId { get; set; }
        [ForeignKey("DirectionId")]
        public virtual DirectionEntity? Direction { get; set; }
    }
}
