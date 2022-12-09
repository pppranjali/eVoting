using System;
using System.Collections.Generic;

namespace Coditas.Ecom.DataAccess.Models
{
    public partial class Project
    {
        public int ProjectId { get; set; }
        public string CustomerName { get; set; } = null!;
        public DateTime EndDate { get; set; }
        public string ManagerName { get; set; } = null!;
        public string ProjectName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public int TeamSize { get; set; }
        public string Technology { get; set; } = null!;
    }
}
