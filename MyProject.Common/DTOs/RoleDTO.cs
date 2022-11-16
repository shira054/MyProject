using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Service.DTOs
{
   public class RoleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Descreption:{Description}";
        }
    }
}
