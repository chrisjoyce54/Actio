/// ---------------------------------------------------------------------------
/// <copyright file="IRejectedEvent.cs" company="Jack Henry &amp; Associates, Inc.">
///     Copyright (c) 1999-2019,, Jack Henry &amp; Associates, Inc. All Rights Reserved.
/// </copyright>
/// <author>Jack Henry &amp; Associates, Inc.</author>
/// <date>Created:  6/17/2019 3:31:45 PM</date>
/// <summary>"IRejectedEvent.cs" is part of "Actio.Common.Events".  
/// </summary>
/// ---------------------------------------------------------------------------

namespace Actio.Common.Events
{
	using System;
	using System.Collections.Generic;
	using System.Text;


	public interface IRejectedEvent
	{
		string Reason { get; }
		string Code { get; }
	}
}
