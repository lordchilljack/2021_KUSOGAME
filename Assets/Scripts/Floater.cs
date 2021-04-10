using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    public Rigidbody rigibody;
    public float depthBeforeSubMerged = 1f;
    public float displacementAmount = 3f;
    public float floatercount = 1;
    public float WaterDrag = 0.99f;
    public float WaterAngularDrag = 0.5f;

    private void FixedUpdate()
    {
        rigibody.AddForceAtPosition(Physics.gravity/floatercount, transform.position, ForceMode.Acceleration);

        float wavehirght = Wavemanager.instance.GetWaveHieght(transform.position.x);
        if (transform.position.y < wavehirght)
        {
            float displacementMultiplier = Mathf.Clamp01((wavehirght-transform.position.y) / depthBeforeSubMerged) * displacementAmount;
            rigibody.AddForceAtPosition(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), transform.position,ForceMode.Acceleration);
            rigibody.AddForce(displacementMultiplier * -rigibody.velocity * WaterDrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
            rigibody.AddTorque(displacementMultiplier * -rigibody.velocity * WaterAngularDrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
    }
}
