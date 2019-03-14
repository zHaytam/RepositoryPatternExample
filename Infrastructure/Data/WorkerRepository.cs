using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Infrastructure.Data
{
    public class WorkerRepository : EfRepository<Worker>, IWorkerRepository
    {

        public WorkerRepository(DataDbContext context) : base(context) { }

        public Task<Worker> GetByFirstName(string firstName)
            => FirstOrDefault(w => w.FirstName == firstName);

    }
}
