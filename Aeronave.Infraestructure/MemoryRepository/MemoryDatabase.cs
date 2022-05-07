using Aeronave.Domain.Model.Aeronaves;

namespace Aeronave.Infraestructure.MemoryRepository
{
    public class MemoryDatabase
    {
        private readonly List<AeronaveModel> _aeronave;

        public List<AeronaveModel> Aeronave
        {
            get { return _aeronave; }
        }

        public MemoryDatabase()
        {
            _aeronave = new List<AeronaveModel>();
        }
    }
}