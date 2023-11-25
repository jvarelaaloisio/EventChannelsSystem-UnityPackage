using System;
using UnityEngine;

namespace Events.Runtime.Channels
{
    [Serializable]
    public struct channelConfig
    {
        [field: SerializeField] public bool LogSubscriptions { get; set; }
        [field: SerializeField] public bool LogEventRisen { get; set; }
    }
}