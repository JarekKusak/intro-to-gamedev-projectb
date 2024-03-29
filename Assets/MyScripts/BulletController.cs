using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = speed * Vector2.right;
    }
    
    public void SetBulletVariant(BulletVariant bulletVariant) {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        
        spriteRenderer.color = bulletVariant.color;
        rigidbody.velocity = transform.right * speed;
    }


    // Update is called once per frame
    void Update() {
        //transform.Translate(speed * Vector3.right * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject); // destroy the game object the script is attached to
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
