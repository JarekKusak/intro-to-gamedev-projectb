using UnityEngine;

public class PressurePadController : MonoBehaviour
{
    public GameObject door;
    private PlayerScript playerScript;

    private void Start()
    {
        playerScript = FindObjectOfType<PlayerScript>();
    }

    public void TryActivatePressurePad()
    {
        if (playerScript.hasKey)
        {
            // open the door
            door.GetComponent<Animator>().Play("DoorOpening");
        }
    }
}