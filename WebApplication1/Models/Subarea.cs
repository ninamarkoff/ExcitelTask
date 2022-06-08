using Excitel.Data;

namespace Excitel.Models
{
    public class Subarea : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }    

        public int PINCode { get; set; }
    }
}
