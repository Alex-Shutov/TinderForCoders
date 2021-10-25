using System.ComponentModel.DataAnnotations;

namespace TinderForCoders.Models
{
    public class RegisterModel 
    {

        [Required(ErrorMessage = "* Обязательное поле ")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Неверно введен e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Required(ErrorMessage = "Обязательное поле")]
        [RegularExpression((@"[A-Za-zА-Яа-я]+"),ErrorMessage ="Введите имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Обязательное поле")]
        [RegularExpression((@"[A-Za-zА-Яа-я]+"), ErrorMessage = "Введите фамилию")]
        public string SurName { get; set; }
        
        [Required(ErrorMessage = "Обязательное поле")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

        [Url(ErrorMessage ="Ссылка невалидна")]
        public string GithubPage { get; set; }

        
    }
}