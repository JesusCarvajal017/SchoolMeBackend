using Entity.Model.Global;
using Entity.Model.Paramters;

namespace Entity.Model.Business
{
    public class GroupDirector : ABaseEntity
    {

        public int TeacherId { get; set; } // FK hacia Teacher


        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Groups> Group { get; set; }


    }
}
