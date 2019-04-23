using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FluentApiLesson
{
    //[Table("_users")]
    public class User
    {
        //[Column("ID")]
        //[Key] //IDENTITY
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Id по порядку
        public int Id { get; set; }


        //[Column("log")]
        //[Required]//ОБЯЗАТЕЛЬНО К ЗАПОЛНЕНИЮ
        //[StringLength(50,MinimumLength =6)]
        public string Login { get; set; }


        //[Column("_pass")]
        //[Required]
        //[MinLength(6)]
        public string Password { get; set; }
    }
}
