namespace Actio.Common.Events
{
	public class UserCreated
	{
		public string Email { get; }
		public string Name { get; }

		public UserCreated()
		{

		}

		public UserCreated(string email, string name)
		{
			Email = email;
			Name = name;
		}
	}
}