using System;

namespace Events.Runtime.Channels.Helpers
{
	public static class SimpleDataChannelHelper
	{
		public static bool TrySubscribe<T>(
			this ChannelSo<T> channel,
			in Action<T> handler)
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
		public static bool TryUnsubscribe<T>(
			this ChannelSo<T> channel,
			in Action<T> handler)
		{
			if (channel) channel.Unsubscribe(handler);
			return channel;
		}

		public static bool TryRaiseEvent<T>(
			this ChannelSo<T> channel,
			in T data)
		{
			if (channel) channel.RaiseEvent(data);
			return channel;
		}
	}
}