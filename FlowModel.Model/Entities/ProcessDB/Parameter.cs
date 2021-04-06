using System.Collections.Generic;

namespace FlowModel.Model
{
    public class Parameter
    {
        public int Id { get; set; }
        
        public string Type { get; set; }
        
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        
        public virtual ICollection<MaterialParameters> MaterialParameters { get; set; }
    }
}