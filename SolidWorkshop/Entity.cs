using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    /// <summary>
    /// Basic model class.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// The Identical parameter of an Entity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The date of creating the entity.
        /// </summary>
        public DateTime CreadedDate { get; set; }
    }
}
