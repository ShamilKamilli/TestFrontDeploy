using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class LoginDto
    {
        //[Required]
        //[DataType(DataType.EmailAddress)]
        //public string Email { get; set; }
        //[Required]
        //public string Password { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
