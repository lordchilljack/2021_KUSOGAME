using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wavemanager : MonoBehaviour
{
    public static Wavemanager instance;

    public float amplitude = 1f;
    public float length = 2f;
    public float speed = 1f;
    public float offset = 0f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("Wave Instance already exist, destroy this Obj!");
            Destroy(this);
        }
    }

    private void Update()
    {
        offset += Time.deltaTime * speed;
    }

    public float GetWaveHieght(float _x)
    {
        return amplitude * Mathf.Sin(_x / length + offset);
    }
}
