using System.ComponentModel.DataAnnotations;

namespace TinderForCoders.Models
{
    public abstract class AbstractModel
    {
        [Required(ErrorMessage = "�� ������ Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "�� ������ ������")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}