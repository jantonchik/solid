using System.Collections.Generic;

namespace SolidWorkshop.Interfaces
{
    public interface IService<T> where T: class
    {
        void Save(T item);
        IEnumerable<T> ReadAll();
    }
}