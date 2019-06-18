/// ---------------------------------------------------------------------------
/// <copyright file="IAuthenticatedCommand.cs" company="Jack Henry &amp; Associates, Inc.">
///     Copyright (c) 1999-2019,, Jack Henry &amp; Associates, Inc. All Rights Reserved.
/// </copyright>
/// <author>Jack Henry &amp; Associates, Inc.</author>
/// <date>Created:  6/17/2019 3:07:52 PM</date>
/// <summary>"IAuthenticatedCommand.cs" is part of "Actio.Common".  
/// </summary>
/// ---------------------------------------------------------------------------

namespace Actio.Common.Commands
{
	using System;
	using System.Collections.Generic;
	using System.Text;


	public interface IAuthenticatedCommand
	{
		Guid UserId { get; set; }
	}
}
