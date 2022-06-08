using Excitel.Models;

namespace Excitel.Data.FileRepository
{
    public class FileLeadRepository : FileRepository<Lead, FileStream>
    {
        public FileLeadRepository(FileStream fileStream) : base(fileStream)
        {
        }
    }
}
