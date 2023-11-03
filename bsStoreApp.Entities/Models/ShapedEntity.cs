﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsStoreApp.Entities.Models
{
    public class ShapedEntity
    {
        public int Id { get; set; }
        public Entity Entity { get; set; }

        public ShapedEntity()
        {
            Entity = new Entity();
        }
    }
}
