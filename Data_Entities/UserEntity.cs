using System.ComponentModel.DataAnnotations;

namespace Lamorenita.Data_Entities
{
    public class UserEntity : PersonEntity
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
