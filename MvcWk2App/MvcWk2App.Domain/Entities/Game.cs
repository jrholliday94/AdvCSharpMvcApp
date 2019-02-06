using System;
using System.ComponentModel.DataAnnotations;

namespace MvcWk2App.Domain.Entities
{
    public class Game
    {
        public Guid GameId { get; set; }
        [StringLength(50)]
        public string GameName { get; set; }



    }
}
