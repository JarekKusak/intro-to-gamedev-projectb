using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionHandler : MonoBehaviour
{
    public GameObject columnParts;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        BulletController bullet = collision.gameObject.GetComponent<BulletController>();
        if (bullet != null)
        {
            columnParts.SetActive(true); // activate the broken column
            gameObject.SetActive(false); // deactivate the whole column

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
