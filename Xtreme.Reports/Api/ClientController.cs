using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Web.Http;

namespace Xtreme.Reports.Api
{
    public class ClientController : ApiController
    {
        public ClientController()
        {

        }

        [HttpGet]
        [Route("api/client/AllClients")]
        public List<Report.Model.Pegasus.Client> AllClients()
        {
            List<Report.Model.Pegasus.Client> clients = new List<Report.Model.Pegasus.Client>();

            var context = new Report.Data.PegasusMetadataEntitiesEF();

            clients = (from t in context.ClientTables.Take(100)
                       select new Report.Model.Pegasus.Client()
                       {
                           ID = t.IdClient,
                           FullName = t.FullName,
                           DatabaseName = t.DatabaseName,
                           DbVersion = t.DbVersion,
                           SiteCode = t.SiteCode,
                           Species = t.Species,
                           Status = t.Status
                       }).ToList();

            return clients;
        }

    }
}
