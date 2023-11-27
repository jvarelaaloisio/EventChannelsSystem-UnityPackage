using System;
using UnityEngine;

namespace Events.Runtime.Channels
{
	[CreateAssetMenu(menuName = "Event Channels/Void Channel", fileName = "VoidChannel")]
	public class VoidChannelSo : ScriptableObject
	{
		[SerializeField] private channelConfig config;
		
		private Action voidEvent;

		public void Subscribe(in Action handler)
		{
			voidEvent += handler;
			if (config.LogSubscriptions)
				Debug.Log($"{name}: A handler subscribed to this channel: {handler}", this);
		}

		public void Unsubscribe(in Action handler)
		{
			voidEvent -= handler;
			if (config.LogSubscriptions)
				Debug.Log($"{name}: A handler unsubscribed from this channel: {handler}", this);
		}

		public void RaiseEvent()
		{
			voidEvent?.Invoke();
			if (config.LogEventRisen)
				Debug.Log($"{name}: Event risen.", this);
		}
	}
}