using MvcWk2App.Shared.ViewModels;
using System.Collections.Generic;

namespace MvcWk2App.Shared.Orchestrators.Interfaces
{
    interface IStudentOrchestrator
    {
        List<StudentViewModel> GetAllStudents();
    }
}
