using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CollectiblesManager.Instance.AddCollectible();
            // Zde můžete přidat efekty nebo zvuky při sběru
            Destroy(gameObject); // Zničí sběratelný předmět
        }
    }
}
