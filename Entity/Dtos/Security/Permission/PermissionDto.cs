using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.Global;

namespace Entity.Dtos.Security.Permission
{
    public class PermissionDto : ABaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
