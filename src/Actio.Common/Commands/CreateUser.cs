/// ---------------------------------------------------------------------------
/// <copyright file="CreateUser.cs" company="Jack Henry &amp; Associates, Inc.">
///     Copyright (c) 1999-2019,, Jack Henry &amp; Associates, Inc. All Rights Reserved.
/// </copyright>
/// <author>Jack Henry &amp; Associates, Inc.</author>
/// <date>Created:  6/17/2019 3:05:10 PM</date>
/// <summary>"CreateUser.cs" is part of "Actio.Common".  
/// </summary>
/// ---------------------------------------------------------------------------

namespace Actio.Common.Commands
{
	using System;
	using System.Collections.Generic;
	using System.Text;


	public class CreateUser
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
	}
}
