using UnityEngine;
using UnityEngine.Events;

namespace Events.Runtime.Additions
{
    public class EventOnTrigger2D : MonoBehaviour
    {
        [SerializeField] private UnityEvent<Collider2D> onTriggerEnterEvent;
        [SerializeField] private UnityEvent<Collider2D> onTriggerExitEvent;

        private void OnTriggerEnter2D(Collider2D other)
        {
            onTriggerEnterEvent?.Invoke(other);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            onTriggerExitEvent?.Invoke(other);
        }
    }
}