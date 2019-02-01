using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public interface IConnectionManager
    {
        void CreateConnection();
        Task OpenAsync();
        void Close();
    }
}
