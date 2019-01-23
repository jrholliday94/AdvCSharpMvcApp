using MvcWk2App.Shared.Orchestrators.Interfaces;
using MvcWk2App.Shared.ViewModels;
using System.Collections.Generic;

namespace MvcWk2App.Shared.Orchestrators
{
    public class StudentOrchestrator : IStudentOrchestrator
    {
        public List<StudentViewModel> GetAllStudents()
        {
            var students = new List<StudentViewModel>
            {
                new StudentViewModel
                {
                    Age = 24,
                    FName = "Jared",
                    LName = "Holliday",
                    Major = "Business Information Systems",
                    Gender = Enums.GenderEnum.Male
                },
                new StudentViewModel
                {
                    Age = 27,
                    FName = "Brandon",
                    LName = "Holliday",
                    Major = "Tool & Diemaking",
                    Gender = Enums.GenderEnum.Male
                }
            };

            return students;
        }
    }
}
