using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamekit2D;

public class ShootingHandler : MonoBehaviour
{
    public GameObject bullet;
    public Transform leftPoint;
    public Transform rightPoint;
    public PlayerCharacter playerCharacter;
    public Transform parentTransform;
    public List<BulletVariant> bulletVariants;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.H)) {
            Transform spawnPoint = rightPoint;
            if (playerCharacter.GetFacing() == -1) 
                spawnPoint = leftPoint;
            GameObject bulletSpawned = Instantiate(bullet, spawnPoint.position, Quaternion.identity, parentTransform);
            BulletVariant chosenVariant = bulletVariants[Random.Range(0, bulletVariants.Count)];
            BulletController bulletController = bulletSpawned.GetComponent<BulletController>();
            if (bulletController != null) 
                bulletController.SetBulletVariant(chosenVariant);
            
            if (playerCharacter.GetFacing() == -1) {
                bulletSpawned.GetComponent<BulletController>().speed *= -1;
                bulletSpawned.GetComponent<SpriteRenderer>().flipX = true; // does not affect the collider
            }
        }
    }

}
