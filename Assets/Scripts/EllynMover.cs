using UnityEngine;

/// <summary>
/// 攝影機的簡單鍵盤控制。
/// 圖層設定為忽略 Raycast，要不然攝影機撞到船，船飛出去。
/// </summary>
public class EllynMover : MonoBehaviour
{
    public bool Enabled;

    private CharacterController controller;

    public void Awake()
    {
        controller = GetComponent<CharacterController>();

        Camera.main.enabled = !Enabled;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
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
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            controller.Move(new Vector3(0f, 1.0f));
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            controller.Move(new Vector3(.0f, -1.0f));
        }
    }
}
