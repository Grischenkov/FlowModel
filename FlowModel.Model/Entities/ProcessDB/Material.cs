using System.Collections.Generic;

namespace FlowModel.Model
{
    public class Material : IEntity
    {
        public Material()
        {
            MaterialParameters = new HashSet<MaterialParameters>();
        }

        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public virtual ICollection<MaterialParameters> MaterialParameters { get; set; }
    }
}