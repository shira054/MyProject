using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Service.DTOs
{
    public enum Epolicy { Allow, Deny, Mandatory }
   public class ClaimDTO
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public Epolicy epolicy { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} RoleId:{RoleId} PermissionId:{PermissionId}";
        }

    }
}
