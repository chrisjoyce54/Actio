using System.Threading.Tasks;

namespace Actio.Common.Events
{
	public interface IEventHandler<T>
	{
		Task HandleAsync(T @event);
	}
}