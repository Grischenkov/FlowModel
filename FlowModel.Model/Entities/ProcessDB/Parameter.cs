﻿using System.Collections.Generic;

namespace FlowModel.Model
{
    public class Parameter : IEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public int TypeId { get; set; }
        public virtual Type Type { get; set; }
        
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        
        public virtual ICollection<MaterialParameters> MaterialParameters { get; set; }
    }
}