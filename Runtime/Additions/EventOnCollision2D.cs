using UnityEngine;
using UnityEngine.Events;

namespace Events.Runtime.Additions
{
    public class EventOnCollision2D : MonoBehaviour
    {
        [SerializeField] private UnityEvent<Collision2D> onCollisionEnterEvent;
        [SerializeField] private UnityEvent<Collision2D> onCollisionExitEvent;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            onCollisionEnterEvent?.Invoke(collision);
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            onCollisionExitEvent?.Invoke(collision);
        }
    }
}