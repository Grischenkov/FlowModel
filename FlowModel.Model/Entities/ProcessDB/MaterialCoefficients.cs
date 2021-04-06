namespace FlowModel.Model
{
    public class MaterialCoefficients
    {
        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }
        
        public int CoefficientId { get; set; }
        public virtual Coefficient Coefficient { get; set; }
        
        public double CoefficientValue { get; set; }
    }
}