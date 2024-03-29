using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    [Tooltip("Direction for movement")]
    public Vector3 Direction;
    [Tooltip("Speed in units per second")]
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        var spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red;
        
        RotationScript rotationScript = gameObject.AddComponent<RotationScript>();
        rotationScript.Speed = 30;
        rotationScript.Direction = new Vector3(0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Direction.normalized * Time.deltaTime * Speed;
    }
}
