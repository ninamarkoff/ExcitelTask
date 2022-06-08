using Excitel.Models;

namespace Excitel.Data.EFCore
{
    public class EFCoreLeadRepository : EfCoreRepository<Lead, ApplicationDbContext>
    {
        public EFCoreLeadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
