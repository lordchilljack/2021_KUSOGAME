using UnityEngine;

/// <summary>
/// ��v����²����L����C
/// �ϼh�]�w������ Raycast�A�n���M��v�������A��X�h�C
/// </summary>
public class EllynMover : MonoBehaviour
{
    public Camera m_MainCamera;

    private CharacterController controller;

    void Start()
    {
        controller = m_MainCamera.GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            controller.Move(new Vector3(0f, 0f, 1.0f));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            controller.Move(new Vector3(.0f, 0f, -1.0f));
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            controller.Move(new Vector3(-1.0f, .0f));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            controller.Move(new Vector3(1.0f, .0f));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            controller.Move(new Vector3(0f, 1.0f));
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            controller.Move(new Vector3(.0f, -1.0f));
        }
    }
}
