using System;

namespace Events.Runtime.Channels.Helpers
{
	public static class VoidChannelHelper
	{
		/// <summary>
		/// Null-checks the channel before subscribing
		/// </summary>
		/// <param name="channel"></param>
		/// <param name="handler"></param>
		/// <returns></returns>
		public static bool TrySubscribe(
			this VoidChannelSo channel,
			in Action handler)
		{
			if (channel) channel.Subscribe(handler);
			return channel;
		}
		
		/// <summary>
		/// Null-checks the channel before unsubscribing
		/// </summary>
		/// <param name="channel"></param>
		/// <param name="handler"></param>
		/// <returns></returns>
		public static bool TryUnsubscribe(
			this VoidChannelSo channel,
			in Action handler)
		{
			if (channel) channel.Unsubscribe(handler);
			return channel;
		}

		/// <summary>
		/// Null-checks the channel before raising it's event
		/// </summary>
		/// <param name="channel"></param>
		/// <returns></returns>
		public static bool TryRaiseEvent(this VoidChannelSo channel)
		{
			if (channel) channel.RaiseEvent();
			return channel;
		}
	}
}