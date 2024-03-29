using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEffects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GetSuperpowers(float duration) {
        StartCoroutine(ScaleUpAndDown(duration));
    }
    private IEnumerator ScaleUpAndDown(float duration) {
        transform.localScale = 1.5f * Vector3.one; // apply the effect
        yield return new WaitForSeconds(duration);
        transform.localScale = Vector3.one; // remove the effect
    }
}
