using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    private bool gameEnded = false;

    private void OnCollisionEnter(Collision other)
    {
        if (gameEnded) return; // Prevent further collisions after game ends

        if (other.gameObject.CompareTag("winspace"))
        {
            gameEnded = true;
            Debug.Log("Congratulations! You won the game!");
            // Add any other win logic here
        }
        else if (!other.gameObject.CompareTag("Hit"))
        {
            // Just handle the death without additional messages
            // Add any death logic here if needed
        }
    }
}