using UnityEngine;

public class CollectiblesManager : MonoBehaviour
{
    public static CollectiblesManager Instance { get; private set; }
    public int CollectiblesCount { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void AddCollectible()
    {
        CollectiblesCount++;
        Debug.Log($"Collectible collected! Total: {CollectiblesCount}");
        // Zde můžete přidat další logiku, například aktualizaci UI
    }
}