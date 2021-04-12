﻿using System;

namespace FlowModel.Model
{
    public class Report : IEntity
    {
        public int Id { get; set; }
        
        public DateTime DateTime { get; set; }
        
        public string Name { get; set; }
        
        public byte[] File { get; set; }
    }
}