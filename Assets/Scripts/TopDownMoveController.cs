using System;
using UnityEngine;

public class TopDownMoveController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 value)
    {
        OnMoveEvent?.Invoke(value);
    }

    public void CallLookEvent(Vector2 value)
    {
        OnLookEvent?.Invoke(value);
    }
}
