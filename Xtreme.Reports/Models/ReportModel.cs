using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xtreme.Reports.Models
{
    public class ReportModel
    {
        public string ReportName { get; set; }

        public XtraReport Report { get; set; }
    }
}
