using System.ComponentModel.DataAnnotations;

namespace TinderForCoders.Models
{
    public class RegisterModel 
    {

        [Required(ErrorMessage = "* ������������ ���� ")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "������� ������ e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "������������ ����")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Required(ErrorMessage = "������������ ����")]
        [RegularExpression((@"[A-Za-z�-��-�]+"),ErrorMessage ="������� ���")]
        public string Name { get; set; }
        [Required(ErrorMessage = "������������ ����")]
        [RegularExpression((@"[A-Za-z�-��-�]+"), ErrorMessage = "������� �������")]
        public string SurName { get; set; }
        
        [Required(ErrorMessage = "������������ ����")]
        public string Login { get; set; }

        [Required(ErrorMessage = "������������ ����")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "������ �� ���������")]
        public string ConfirmPassword { get; set; }

        [Url(ErrorMessage ="������ ���������")]
        public string GithubPage { get; set; }

        
    }
}