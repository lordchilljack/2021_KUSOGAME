using UnityEngine;

/// <summary>
/// 無人機攝影機。
/// </summary>
public class EllynDroneMover : MonoBehaviour
{
    public Transform target;
    public bool LookupShip;
    public float FollowingSpeed = 5.0f;

    public void Awake()
    {
    }

    public void FixedUpdate()
    {
        if (LookupShip)
        {
            Vector3 relativePos = target.position - transform.position;

            if (relativePos != Vector3.zero)
            {
                relativePos.y += 0.5f;
                transform.rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            }
        }
    }

    public void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            pos.z -= FollowingSpeed;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            pos.z += FollowingSpeed;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pos.x += FollowingSpeed;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pos.x -= FollowingSpeed;
        }

        transform.position = pos;
    }
}
