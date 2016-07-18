namespace WebApplication1.Model
{
    public class UserService : IUserService
    {
        public string Name { get; set; }
        public void SetUserStuff(string name)
        {
            this.Name = name;
        }
    }
}