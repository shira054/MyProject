using MyProject.Service.DTOs;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Service.Interfaces
{
   public interface IClaimService
    {
         List<ClaimDTO> GetAll();

        ClaimDTO GetById(int id);

         ClaimDTO Add(int id, int RoleId, int PermissionId);

         ClaimDTO Update(ClaimDTO c);

        public void Delete(int id);
    }
}
