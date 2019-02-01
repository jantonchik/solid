﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public abstract class Entity
    {
        private int id;

        protected Entity(int id)
        {
            this.id = id;
        }

        public int Id { get; }
    }
}
