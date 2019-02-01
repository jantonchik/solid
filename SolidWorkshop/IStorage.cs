using System.Threading.Tasks;

namespace SolidWorkshop
{
    public interface IStorage
    {
        Task<int> SaveChangesAsync();
    }
}
