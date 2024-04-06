using UnityEngine;
using UnityEngine.SceneManagement;
using Gamekit2D;
public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Zde zavolejte jakoukoliv funkci, která má za úkol "zabít" hráče
            // Můžete také přímo restartovat level nebo zobrazit scénu s konečnými titulky atd.
            var player = collision.GetComponent<Gamekit2D.PlayerCharacter>();
            if (player != null)
            {
                player.Respawn(true, true); // Předpokládáme, že existuje metoda Die ve skriptu hráče
            }
            else
            {
                // Pokud není hráčový skript dostupný, restartujte scénu nebo zavolejte Game Over logiku
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}