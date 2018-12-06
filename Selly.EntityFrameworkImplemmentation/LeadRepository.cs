using Selly.Model;
using Selly.Repository;

namespace Selly.EntityFrameworkImplemmentation
{
    public class LeadRepository : ILeadRepository
    {
        public LeadModel GetLead(string Id)
        {
            LeadModel modelList = new LeadModel();
            return modelList;
        }
    }
}
