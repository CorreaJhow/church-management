using System.ComponentModel.DataAnnotations;

namespace church_management_system.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Senha { get; set; }
    }
}
