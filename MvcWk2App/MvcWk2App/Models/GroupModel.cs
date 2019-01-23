using MvcWk2App.Shared.ViewModels;
using System.Collections.Generic;

namespace MvcWk2App.Models
{
    public class GroupModel
    {
        public int GroupNumber { get; set; }
        public string GroupName { get; set; }
        public List<StudentViewModel> Students { get; set; }


    }
}