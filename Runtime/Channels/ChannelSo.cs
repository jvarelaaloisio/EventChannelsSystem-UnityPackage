﻿using System;
using Events.Runtime.Channels;
using UnityEngine;

namespace EventChannels.Runtime.Channels
{
	public abstract class ChannelSo<T> : ScriptableObject
	{
		[SerializeField] private channelConfig config;
		
		private Action<T> _dataEvent;

		public void Subscribe(in Action<T> handler)
		{
			_dataEvent += handler;
			if (config.LogSubscriptions)
				Debug.Log($"{name}: A handler subscribed to this channel: {handler}", this);
		}

		public void Unsubscribe(in Action<T> handler)
		{
			_dataEvent -= handler;
			if (config.LogSubscriptions)
				Debug.Log($"{name}: A handler unsubscribed from this channel: {handler}", this);
		}

		public void RaiseEvent(T data)
		{
			_dataEvent?.Invoke(data);
			if (config.LogEventRisen)
				Debug.Log($"{name}: Event risen with data {data}", this);
		}
	}

	public abstract class ChannelSo<T1, T2> : ScriptableObject
	{
		[SerializeField] private channelConfig config;
		private Action<T1, T2> dataEvent;

		public void Subscribe(in Action<T1, T2> handler)
		{
			dataEvent += handler;
			if (config.LogSubscriptions)
				Debug.Log($"{name}: A handler subscribed to this channel: {handler}", this);
		}

		public void Unsubscribe(in Action<T1, T2> handler)
		{
			dataEvent -= handler;
			if (config.LogSubscriptions)
				Debug.Log($"{name}: A handler unsubscribed from this channel: {handler}", this);
		}

		public void RaiseEvent(T1 data1, T2 data2)
		{
			dataEvent?.Invoke(data1, data2);
			if (config.LogEventRisen)
				Debug.Log($"{name}: Event risen with data {data1}, {data2}", this);
		}
	}

	public abstract class ChannelSo<T1, T2, T3> : ScriptableObject
	{
		[SerializeField] private channelConfig config;
		private Action<T1, T2, T3> dataEvent;

		public void Subscribe(in Action<T1, T2, T3> handler)
		{
			dataEvent += handler;
			if (config.LogSubscriptions)
				Debug.Log($"{name}: A handler subscribed to this channel: {handler}", this);
		}

		public void Unsubscribe(in Action<T1, T2, T3> handler)
		{
			dataEvent -= handler;
			if (config.LogSubscriptions)
				Debug.Log($"{name}: A handler unsubscribed from this channel: {handler}", this);
		}

		public void RaiseEvent(T1 data1, T2 data2, T3 data3)
		{
			dataEvent?.Invoke(data1, data2, data3);
			if (config.LogEventRisen)
				Debug.Log($"{name}: Event risen with data {data1}, {data2}, {data3}", this);
		}
	}

	public abstract class ChannelSo<T1, T2, T3, T4> : ScriptableObject
	{
		[SerializeField] private channelConfig config;
		private Action<T1, T2, T3, T4> dataEvent;

		public void Subscribe(in Action<T1, T2, T3, T4> handler)
		{
			dataEvent += handler;
			if (config.LogSubscriptions)
				Debug.Log($"{name}: A handler subscribed to this channel: {handler}", this);
		}

		public void Unsubscribe(in Action<T1, T2, T3, T4> handler)
		{
			dataEvent -= handler;
		}

		public void RaiseEvent(T1 data1, T2 data2, T3 data3, T4 data4)
		{
			dataEvent?.Invoke(data1, data2, data3, data4);
			if (config.LogEventRisen)
				Debug.Log($"{name}: Event risen with data {data1}, {data2}, {data3}, {data4}", this);
		}
	}

	public abstract class ChannelSo<T1, T2, T3, T4, T5> : ScriptableObject
	{
		[SerializeField] private channelConfig config;
		private Action<T1, T2, T3, T4, T5> dataEvent;

		public void Subscribe(in Action<T1, T2, T3, T4, T5> handler)
		{
			dataEvent += handler;
			if (config.LogSubscriptions)
				Debug.Log($"{name}: A handler subscribed to this channel: {handler}", this);
		}

		public void Unsubscribe(in Action<T1, T2, T3, T4, T5> handler)
		{
			dataEvent -= handler;
			if (config.LogSubscriptions)
				Debug.Log($"{name}: A handler unsubscribed from this channel: {handler}", this);
		}

		public void RaiseEvent(T1 data1, T2 data2, T3 data3, T4 data4, T5 data5)
		{
			dataEvent?.Invoke(data1, data2, data3, data4, data5);
			if (config.LogEventRisen)
				Debug.Log($"{name}: Event risen with data {data1}, {data2}, {data3}, {data4}, {data5}", this);
		}
	}
}