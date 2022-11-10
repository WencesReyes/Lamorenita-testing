using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lamorenita.Data_Entities
{
    public class StoreManagerEntity
    {
        [Key]
        public int Id { get; set; }
        public int? StoreId { get; set; }
        [ForeignKey("StoreId")]
        public virtual StoreEntity? Store { get; set; }
        public int? ContactId { get; set; }
        [ForeignKey("ContactId")]
        public virtual ContactEntity? Contact { get; set; }
    }
}
