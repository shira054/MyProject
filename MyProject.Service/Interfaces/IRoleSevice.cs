using MyProject.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Service.Interfaces
{
    interface IRoleSevice
    {
        public List<RoleDTO> GetAll();

        public RoleDTO GetById(int id);

        public RoleDTO Add(int id, string name, string description);

        public RoleDTO Update(RoleDTO r);

        public void Delete(int id);
    }
}
