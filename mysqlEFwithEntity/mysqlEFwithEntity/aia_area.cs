using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysqlEFwithEntity
{
    public class aia_area
    {                                                              
        public int Id { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }

        public Guid UperId { get; set; }
        public DateTime? CreatedTime { get; set; }
    }
}
