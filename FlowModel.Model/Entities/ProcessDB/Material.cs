using System.Collections.Generic;

namespace FlowModel.Model
{
    public class Material : IEntity
    {
        public Material()
        {
            MaterialParameters = new HashSet<MaterialParameters>();
        }

        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public virtual ICollection<MaterialParameters> MaterialParameters { get; set; }
    }
}