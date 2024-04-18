using Gamekit2D;
using UnityEngine;
using UnityEngine.Events;

public class KeyScript : MonoBehaviour
{
    public UnityEvent itemEffect;
    public float rotationSpeed = 100f; // rotation speed
    private CapsuleCollider2D trigger;
    private AudioSource audioSource;
    private string keyName = "Key";

    void Start()
    {
        trigger = GetComponent<CapsuleCollider2D>();
        audioSource = GetComponent<AudioSource>();
        //PlaySound();
    }

    void Update()
    {
        // key rotation
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    private void PlaySound() {
        audioSource.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            itemEffect.Invoke(); // Spustí nastavené události, můžete odstranit, pokud není potřeba
            PlayerScript playerScript = collision.gameObject.GetComponent<PlayerScript>();
            if (playerScript != null)
            {
                playerScript.CollectKey();
                // Add the key to the player's inventory.
                InventoryController playerInventory = collision.gameObject.GetComponent<InventoryController>();
                
                // Check if playerInventory is not null
                if (playerInventory != null)
                {
                    playerInventory.AddItem(keyName); // Add the key to the player's inventory
                    KeyUI.Instance.ChangeKeyUI(playerInventory);
                }

                PlaySound();
                Destroy(gameObject);
            }
        }
    }
}