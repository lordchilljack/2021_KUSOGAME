using UnityEngine;
using UnityEngine.UI;

public class OnScreenDisplay : MonoBehaviour
{
    public Text infoOsd;
    public Transform target;

    private RawImage image;

    public void Awake()
    {
        image = GetComponent<RawImage>();
    }

    public void FixedUpdate()
    {
        infoOsd.text = target.position.ToString();
    }
}
