using UnityEngine;
using UnityEngine.Events;

namespace Events.Runtime.Additions
{
    public class EventOnTrigger : MonoBehaviour
    {
        [SerializeField] private UnityEvent<Collider> onTriggerEnterEvent;
        [SerializeField] private UnityEvent<Collider> onTriggerExitEvent;

        private void OnTriggerEnter(Collider other)
        {
            onTriggerEnterEvent?.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            onTriggerExitEvent?.Invoke(other);
        }
    }
}