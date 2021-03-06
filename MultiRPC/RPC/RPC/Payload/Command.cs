﻿using DiscordRPC.Converters;

namespace DiscordRPC.RPC.Payload
{
    /// <summary>
    /// The possible commands that can be sent and received by the server.
    /// </summary>
    public enum Command
	{
		/// <summary>
		/// event dispatch
		/// </summary>
		[EnumValue("DISPATCH")]
		Dispatch,

		/// <summary>
		/// Called to set the activity
		/// </summary>
		[EnumValue("SET_ACTIVITY")]
		SetActivity,
	}
}
