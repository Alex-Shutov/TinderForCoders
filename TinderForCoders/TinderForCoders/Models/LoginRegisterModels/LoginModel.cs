using System.ComponentModel.DataAnnotations;

namespace TinderForCoders.Models
{
    public class LoginModel 
    {
        [Required(ErrorMessage = "������������ ����")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "������� ������ e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "������������ ����")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
    }
}