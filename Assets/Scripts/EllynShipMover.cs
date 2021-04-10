using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ²îÄ¥ªº¸òÀH¤Î°lÂÜµJÂI¡C
/// </summary>
public class EllynShipMover : MonoBehaviour
{
    public Text infoOsd;
    public Camera shipCamera;
    public GameObject containerShip;
    public bool CameraEnabled, LookupShip, FollowingShip;
    public float FollowingSpeed = 5.0f;

    private Transform target;
    private PlayerControlAuto ctrl;

    public void Awake()
    {
        target = containerShip.transform;
        ctrl = GetComponent<PlayerControlAuto>();

        shipCamera.enabled = !CameraEnabled;
    }

    public void FixedUpdate()
    {
        if (LookupShip)
        {
            Vector3 relativePos = target.position - transform.position;

            if (relativePos != Vector3.zero &&
                Vector3.Distance(transform.position, target.position) > 5.0f)
            {
                Quaternion dir = Quaternion.Euler(relativePos);
                infoOsd.text = dir.ToString();
                ctrl.Rigibody.AddForceAtPosition((dir.y > 0 ? 1 : -1) * transform.right * ctrl.SteerPower / 100.0f, ctrl.Engine.position);

                if (dir.x > 0)
                {
                    ctrl.Rigibody.AddForceAtPosition(-transform.up * ctrl.Power / 100.0f, ctrl.Engine.position, ForceMode.Impulse);
                }
                else
                {
                    ctrl.Rigibody.AddForceAtPosition(transform.up * ctrl.Power / 100.0f, ctrl.Engine.position, ForceMode.Impulse);
                }
            }
        }
    }

    public void Update()
    {
        if (FollowingShip)
        {
            if (Vector3.Distance(transform.position, target.position) > FollowingSpeed)
            {
                /*Quaternion rotation = transform.rotation;
                transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * FollowingSpeed);
                transform.rotation = rotation;*/
            }
        }

        /*if (Input.GetKeyDown(KeyCode.J))
        {
            controller.Move(new Vector3(0f, 0f, 1.0f));
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            controller.Move(new Vector3(.0f, 0f, -1.0f));
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            controller.Move(new Vector3(-1.0f, .0f));
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            controller.Move(new Vector3(1.0f, .0f));
        }*/
    }
}
