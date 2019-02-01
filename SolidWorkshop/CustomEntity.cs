using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public class CustomEntity : Entity
    {
        public CustomEntity(int id) : base(id)
        {
        }

        public DateTime CreatedDate { get; set; }
    }
}
