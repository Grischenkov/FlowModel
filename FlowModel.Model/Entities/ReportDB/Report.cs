using System;

namespace FlowModel.Model
{
    public class Report : IEntity
    {
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        
        public DateTime DateTime { get; set; }
        
        public string Name { get; set; }
        
        public byte[] File { get; set; }
    }
}