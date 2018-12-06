using Selly.Model;

namespace Selly.Repository
{
    public interface ILeadRepository
    {

        LeadModel GetLead(string Id);

    }
}
