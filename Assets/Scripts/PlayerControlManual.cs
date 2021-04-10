using UnityEngine;

public class PlayerControlManual : MonoBehaviour
{
    public Rigidbody Rigibody;
    public Transform Engine;
    public float SteerPower = 5.0f;
    public float Power = 5.0f;

    public void FixedUpdate()
    {
        var steer = 0;

        if (Input.GetKey(KeyCode.A))
        {
            steer = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            steer = 1;
        }

        Rigibody.AddForceAtPosition(steer * transform.right * SteerPower / 100.0f, Engine.position);
        
        if (Input.GetKey(KeyCode.W))
        {
            Rigibody.AddForceAtPosition(transform.up * Power / 100.0f, Engine.position, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Rigibody.AddForceAtPosition(-transform.up * Power / 100.0f, Engine.position, ForceMode.Impulse);
        }
    }
}
