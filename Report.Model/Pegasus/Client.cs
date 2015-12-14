using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.Model.Pegasus
{
    public class Client
    {
        public Guid ID { get; set; }
        public string FullName { get; set; }
        public string SiteCode { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public int? DbVersion { get; set; }
        public string DatabaseName { get; set; }
    }
}
