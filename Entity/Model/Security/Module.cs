using Entity.Model.Global;

namespace Entity.Model.Security
{
    public class Module : ABaseEntity
    {
        public string Name { get; set; } 
        public string Description { get; set; } 

        public ICollection<ModuleForm> ModuleForm { get; set; }
    }
}
