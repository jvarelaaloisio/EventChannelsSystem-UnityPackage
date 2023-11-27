using System;
using UnityEngine;

namespace EventChannels.Runtime.Additions
{
    public class DelegateOnCollision2D : MonoBehaviour
    {
        public event Action<Collision2D> onCollisionEnter2D;
        public event Action<Collision2D> onCollisionExit2D;
        private void OnCollisionEnter2D(Collision2D collision2D)
            => onCollisionEnter2D?.Invoke(collision2D);

        private void OnCollisionExit2D(Collision2D collision2D)
            => onCollisionExit2D?.Invoke(collision2D);
    }
}
