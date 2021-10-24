using System.ComponentModel.DataAnnotations;

namespace TinderForCoders.Models
{
    public class LoginModel 
    {
        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Неверно введен e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
    }
}