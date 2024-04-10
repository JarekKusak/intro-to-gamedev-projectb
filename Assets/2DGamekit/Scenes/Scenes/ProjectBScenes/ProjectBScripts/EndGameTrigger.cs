using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        Debug.Log("Game Over! Thanks for playing.");
        Application.Quit(); // This will close the game application.

        // If running this in the editor, stop the play mode.
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}