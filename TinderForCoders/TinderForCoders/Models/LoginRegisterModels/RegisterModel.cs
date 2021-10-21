using System.ComponentModel.DataAnnotations;

namespace TinderForCoders.Models
{
    public class RegisterModel : AbstractModel
    {
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }
    }
}