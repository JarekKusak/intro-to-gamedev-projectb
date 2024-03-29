using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    [Tooltip("Direction for movement")]
    public Vector3 Direction;
    [Tooltip("Speed in units per second")]
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localEulerAngles += Direction * Speed * Time.deltaTime;
    }
}
