namespace FlowModel.Model
{
    public class Unit : IEntity
    {
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        
        public string Name { get; set; }
    }
}