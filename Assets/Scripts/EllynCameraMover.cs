using UnityEngine;

/// <summary>
/// 攝影機的跟隨及追蹤焦點。
/// </summary>
public class EllynCameraMover : MonoBehaviour
{
    public Camera shipCamera;
    public GameObject containerShip;
    public bool CameraEnabled, LookupShip, FollowingShip;
    public float FollowingSpeed = 5.0f;

    private Transform target;

    public void Awake()
    {
        target = containerShip.transform;

        shipCamera.enabled = !CameraEnabled;
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
        if (FollowingShip)
        {
            if (Vector3.Distance(transform.position, target.position) > FollowingSpeed)
            {
                Vector3 pos = target.position;
                pos.y += 2.0f;
                transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * FollowingSpeed);
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.FromToRotation(Vector3.down, transform.forward);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.FromToRotation(Vector3.left, transform.forward);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.FromToRotation(Vector3.right, transform.forward);
        }
    }
}
