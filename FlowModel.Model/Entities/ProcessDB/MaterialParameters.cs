namespace FlowModel.Model
{
    public class MaterialParameters
    {
        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }
        
        public int ParameterId { get; set; }
        public virtual Parameter Parameter { get; set; }
        
        public double CoefficientValue { get; set; }
    }
}