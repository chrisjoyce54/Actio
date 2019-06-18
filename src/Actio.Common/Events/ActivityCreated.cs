/// ---------------------------------------------------------------------------
/// <copyright file="ActivityCreated.cs" company="Jack Henry &amp; Associates, Inc.">
///     Copyright (c) 1999-2019,, Jack Henry &amp; Associates, Inc. All Rights Reserved.
/// </copyright>
/// <author>Jack Henry &amp; Associates, Inc.</author>
/// <date>Created:  6/17/2019 3:23:57 PM</date>
/// <summary>"ActivityCreated.cs" is part of "Actio.Common.Events".  
/// </summary>
/// ---------------------------------------------------------------------------

namespace Actio.Common.Events
{
	using System;
	using System.Collections.Generic;
	using System.Text;


	public class ActivityCreated : IAuthernticatedEvent
	{
		public Guid UserId { get;  }
		public Guid Id { get;  }
		public string Category { get;  }
		public string Name { get;  }
		public string Description { get;  }
		public DateTime CreatedAt { get;  }

		protected ActivityCreated()
		{
			
		}

		public ActivityCreated(Guid id, Guid userId, string category, string description)
		{
			Id = id;
			UserId = userId;
			Category = category;
			Description = description;
			CreatedAt = DateTime.Now;

		}
	}
}
