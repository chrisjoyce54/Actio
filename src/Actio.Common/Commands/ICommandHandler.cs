using System.Threading.Tasks;


namespace Actio.Common.Commands
{
	public interface ICommandHandler<T>
	{
		Task HandleAsync(T command);
	}
}