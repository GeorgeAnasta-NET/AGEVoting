using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGEVoting.Models {
    public class BaseEntity {
        public DateTime Created { get; set; }
        public long CreatedBy { get; set; }

        public DateTime Modified { get; set; }
        public long ModifiedBy { get; set; }

        public DateTime Deleted { get; set; }
        public long DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
