using Microsoft.AspNetCore.Mvc;

namespace Erhan_Ana_Maria_Lab1.Controllers
{
    public class FirstController : Controller
    {
        public String Index()
        {
            return "Welcome, user!";
        }

        public String HelloStudent(String studentName)
        {
            return "Hello, " + studentName;
        }

        public String GreetStudent(String studentName, int studentAge)
        {
            return "Student " + studentName + " has " + studentAge + " years old."; 
        }
    }
}
