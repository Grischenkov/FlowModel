namespace FlowModel.Model
{
    public class User : IEntity
    {
        public int Id { get; set; }
        
        public string Login { get; set; }
        
        public string Password { get; set; }
        
        public bool IsAdministrator { get; set; }
    }
}