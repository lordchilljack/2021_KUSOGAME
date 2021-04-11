using thokgames;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody rigibody;
    public float RotationFromOriginalAngle;

    public Transform Engine;
    public float SteerPower = 500f;
    public float Power = 5f;
    public float Drag = 0.1f;

    protected Quaternion StartRotation;

    public void Awake()
    {
        StartRotation = Engine.localRotation;
    }

    public void FixedUpdate()
    {
        
        //default direction
        var forceDirection = transform.forward;
        var steer = 0;
        //steer direction [-1,0,1]
        if (Input.GetKey(KeyCode.A))
            steer = -1;
        if (Input.GetKey(KeyCode.D))
            steer = 1;
        //Rotational Force
        rigibody.AddForceAtPosition(steer * transform.right * SteerPower / 100f, Engine.position);
        
        if (Input.GetKey(KeyCode.W))
            rigibody.AddForceAtPosition(transform.up * Power / 100f, Engine.position, ForceMode.Impulse);
        if (Input.GetKey(KeyCode.S))
            rigibody.AddForceAtPosition(-transform.up * Power / 100f, Engine.position, ForceMode.Impulse);
    }
}