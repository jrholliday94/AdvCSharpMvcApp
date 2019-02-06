using MvcWk2App.Shared.Enums;

namespace MvcWk2App.Shared.ViewModels
{
    public class StudentViewModel
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public GenderEnum Gender { get; set; }
        
    }
}
