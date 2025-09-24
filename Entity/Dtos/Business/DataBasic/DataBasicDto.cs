﻿using Entity.Dtos.Global;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Entity.Dtos.Business.DataBasic
{
    public class DataBasicDto : ABaseDto
    {

        public int PersonId { get; set; }
        public int? RhId { get; set; }
        public string? Adress { get; set; }
        public DateTime? BrithDate { get; set; }
        public int? StratumStatus { get; set; }

        public int? MaterialStatusId { get; set; }

        public int? EpsId { get; set; }
        public int? DepartamentId { get; set; }
        public int? MunisipalityId { get; set; }
    }
}
