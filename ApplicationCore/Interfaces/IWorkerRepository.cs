using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IWorkerRepository : IAsyncRepository<Worker>
    {

        Task<Worker> GetByFirstName(string firstName);

    }
}
