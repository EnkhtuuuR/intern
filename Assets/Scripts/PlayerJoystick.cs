using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystick : MonoBehaviour
{
    public FixedJoystick moveJoyStick;
    public FixedJoystick lookJoyStick;
    // Update is called once per frame
    void Update()
    {
        UpdateMoveJoystick();
        //UpdateLookJoystick();
    }

    void UpdateMoveJoystick()
    {
        float hoz = moveJoyStick.Horizontal;
        float vec = moveJoyStick.Vertical;
        Vector3 direction = new Vector3(hoz, 0, vec).normalized;
        transform.Translate(direction * 0.02f, Space.World);
    }
    /*
    void UpdateLookJoystick()
    {
        float hoz = lookJoyStick.Horizontal;
        float vec = lookJoyStick.Vertical;
        Vector3 direction = new Vector3(hoz, 0, vec).normalized;
        Vector3 lookAtPosition = transform.position + direction;
        transform.LookAt(lookAtPosition);
    }
    */
}
