﻿using System;
using EventChannels.Runtime.Channels;
using UnityEngine;

namespace Events.Runtime.Channels
{
	[CreateAssetMenu(menuName = "Event Channels/Data Channels/Func<String>", fileName = "FuncStringChannel")]
	public class FuncStringChannel : ChannelSo<Func<string>>
	{
	}
}
