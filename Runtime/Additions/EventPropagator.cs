using UnityEngine;
using UnityEngine.Events;

public class EventPropagator : MonoBehaviour
{
    public UnityEvent onPropagate;
    [TextArea] [SerializeField] private string description;

    public string Description => description;

    [ContextMenu("Propagate")]
    public void Propagate()
    {
        onPropagate.Invoke();
    }
}
