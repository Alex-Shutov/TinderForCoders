using System.ComponentModel.DataAnnotations;

namespace TinderForCoders.Models
{
    public class RegisterModel : AbstractModel
    {
        [Required(ErrorMessage = "�� ������ ������")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "������ ������ �������")]
        public string ConfirmPassword { get; set; }
    }
}