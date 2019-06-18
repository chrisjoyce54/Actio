using System;

namespace Actio.Common.Events
{
	public interface IAuthernticatedEvent
	{
		Guid UserId { get; }
	}
}