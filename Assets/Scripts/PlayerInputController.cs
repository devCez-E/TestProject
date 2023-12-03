using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownMoveController
{
    Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>().normalized;
        CallMoveEvent(input);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if (newAim.magnitude > 0) CallLookEvent(newAim);
    }

    public void OnFire(InputValue value)
    {
        Debug.Log("OnFire!");
    }
}
