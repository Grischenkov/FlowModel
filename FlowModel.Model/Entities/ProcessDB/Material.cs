using System.Collections.Generic;

namespace FlowModel.Model
{
    public class Material
    {
        public Material()
        {
            MaterialParameters = new HashSet<MaterialParameters>();
            MaterialCoefficients = new HashSet<MaterialCoefficients>();
        }

        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public virtual ICollection<MaterialParameters> MaterialParameters { get; set; }
        public virtual ICollection<MaterialCoefficients> MaterialCoefficients { get; set; }
    }
}