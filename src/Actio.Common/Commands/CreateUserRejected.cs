/// ---------------------------------------------------------------------------
/// <copyright file="CreateUserRejected.cs" company="Jack Henry &amp; Associates, Inc.">
///     Copyright (c) 1999-2019,, Jack Henry &amp; Associates, Inc. All Rights Reserved.
/// </copyright>
/// <author>Jack Henry &amp; Associates, Inc.</author>
/// <date>Created:  6/17/2019 3:33:16 PM</date>
/// <summary>"CreateUserRejected.cs" is part of "Actio.Common.Commands".  
/// </summary>
/// ---------------------------------------------------------------------------

using Actio.Common.Events;

namespace Actio.Common.Commands
{
	using System;
	using System.Collections.Generic;
	using System.Text;


	public class CreateUserRejected : IRejectedEvent
	{
		public string Email { get; set; }
		public string Reason { get; }
		public string Code {get;}

		protected CreateUserRejected()
		{
		
		}

		public CreateUserRejected(string email, string reason, string code)
		{
			Email = email;
			Reason = reason;
			Code = code;
		}
	}
}
