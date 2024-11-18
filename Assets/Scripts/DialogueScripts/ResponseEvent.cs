using UnityEngine.Events;
using UnityEngine;

[System.Serializable]
public class ResponseEvent
{
    [HideInInspector] public string name;
    [SerializeField] public UnityEvent onPickedResponse;

    public UnityEvent OnPickedResponse => onPickedResponse;
}
