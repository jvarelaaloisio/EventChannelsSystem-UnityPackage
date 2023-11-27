using System;
using UnityEngine;

namespace EventChannels.Runtime.Additions
{
    public class DelegateOnCollision : MonoBehaviour
    {
        public event Action<Collision> onCollisionEnter;
        public event Action<Collision> onCollisionExit;
        private void OnCollisionEnter(Collision collision)
            => onCollisionEnter?.Invoke(collision);

        private void OnCollisionExit(Collision collision)
            => onCollisionExit?.Invoke(collision);
    }
}