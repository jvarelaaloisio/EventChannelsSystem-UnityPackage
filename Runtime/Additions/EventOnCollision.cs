using UnityEngine;
using UnityEngine.Events;

namespace Events.Runtime.Additions
{
	public class EventOnCollision : MonoBehaviour
	{
		[SerializeField] private UnityEvent<Collision> onCollisionEnterEvent;
		[SerializeField] private UnityEvent<Collision> onCollisionExitEvent;

		private void OnCollisionEnter(Collision collision)
		{
			onCollisionEnterEvent?.Invoke(collision);
		}

		private void OnCollisionExit(Collision collision)
		{
			onCollisionExitEvent?.Invoke(collision);
		}
	}
}