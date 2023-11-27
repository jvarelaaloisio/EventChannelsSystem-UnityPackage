using System.Linq;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EventPropagator))]
public class EventPropagatorInspector : Editor
{
    public override void OnInspectorGUI()
    {
        var descLines = ((EventPropagator)target).Description.Split('\n');
        if (descLines.Any())
        {
            GUILayout.Label(descLines[0], EditorStyles.boldLabel);
        }
        DrawDefaultInspector();
    }
}
