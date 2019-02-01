using System.Collections.Generic;

namespace SolidWorkshop.Interfaces
{
    public interface IDbConnector<T> where T: class
    {
        IEnumerable<T> GetAll();
        void Save(T item);  
    }
}