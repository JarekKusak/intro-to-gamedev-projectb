using UnityEngine;

public class UnstableGround : MonoBehaviour
{
    public float collapseDelay = 1f; // Zpoždění před pádem
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic; // Start as Kinematic
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Invoke(nameof(BecomeDynamic), collapseDelay);
        }
    }

    private void BecomeDynamic()
    {
        rb.bodyType = RigidbodyType2D.Dynamic; // Change to Dynamic to fall
    }
}