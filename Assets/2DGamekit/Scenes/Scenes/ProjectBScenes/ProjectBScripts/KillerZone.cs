using UnityEngine;
using UnityEngine.SceneManagement;
using Gamekit2D;
public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var player = collision.GetComponent<Gamekit2D.PlayerCharacter>();
            if (player != null)
            {
                player.Respawn(false, true);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}