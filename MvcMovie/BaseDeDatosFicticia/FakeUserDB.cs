using MvcMovie.Models;

namespace MvcMovie.BaseDeDatosFicticia
{
    public class FakeUserDB
    {
        public static List<LoginModel> Users = new List<LoginModel> 
        {
            new LoginModel
            {
                Id= 1,
                User= "admin",
                Password= "1234"
            },
            new LoginModel
            {
                Id= 2,
                User= "Nicole",
                Password= "555"
            },
            new LoginModel
            {
                Id= 3,
                User= "Leandro",
                Password="777"
            }
        };
    }
}
