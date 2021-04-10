using UnityEngine;

/// <summary>
/// 攝影機的簡單鍵盤控制。
/// 圖層設定為忽略 Raycast，要不然攝影機撞到船，船飛出去。
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
