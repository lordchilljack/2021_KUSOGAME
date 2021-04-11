using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CubeDestoryer : MonoBehaviour
{
    public Text Count;
    public AudioSource SE;
    public int Counter = 40;
    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        int randomsound;
        randomsound = UnityEngine.Random.Range(0, 1);
        if (collision.gameObject.tag == "Cube")
        {
            if (randomsound == 0)
            {
                SE.clip = (AudioClip)Resources.Load("HitSound1");
            }
            else
            {
                SE.clip = (AudioClip)Resources.Load("HitSound2");
            }
            Destroy(collision.gameObject);
            SE.Play();
            Counter--;
            Count.text = ""+Counter;
        }
    }
    private void FixedUpdate()
    {
        if (Counter <= 0)
        {

        }
    }
}
