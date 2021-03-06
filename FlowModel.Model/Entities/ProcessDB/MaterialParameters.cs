namespace FlowModel.Model
{
    public class MaterialParameters : IEntity
    {
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        
        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }
        
        public int ParameterId { get; set; }
        public virtual Parameter Parameter { get; set; }
        
        public double ParameterValue { get; set; }
    }
}