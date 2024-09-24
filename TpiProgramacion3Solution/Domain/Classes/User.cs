namespace Domain.Classes
{
    public abstract class User
    {
        protected string Name { get; set }
        protected int Id { get; set }
        protected string Email { get; set }
        protected string Password { get; set }
        protected int Dni { get; set }

        protected User(string name, int id, string email, string password, int dni)
        {
            Name = name;
            Id = id;
            Email = email;
            Password = password;
            Dni = dni;
        }
    }
}
