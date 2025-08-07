namespace Entity.Dtos.Security.User
{
    public class UserInsertDto
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } 
        public int Status { get; set; }
    }
}
