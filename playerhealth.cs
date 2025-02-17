using UnityEngine;
using System.Collections;

public class playerhealth : MonoBehaviour
{
    private Vector3 startPosition; // Stores player's starting position
    private Quaternion startRotation;
    private Renderer playerRenderer;
    private Rigidbody rb;
    
    public float respawnDelay = 2f; // Delay before respawn

    private void Start()
    {
        // Save the player's starting position and rotation
        startPosition = transform.position;
        startRotation = transform.rotation;
        playerRenderer = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
    }

    public void Die()
    {
        Debug.Log("Player has died!");
        StartCoroutine(Respawn());
    }

    private IEnumerator Respawn()
    {
        // Disable movement
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.isKinematic = true; // Prevent physics movement
        }

        // Hide player
        playerRenderer.enabled = false;

        // Wait before respawning
        yield return new WaitForSeconds(respawnDelay);

        // Reset position and rotation
        transform.position = startPosition;
        transform.rotation = startRotation;

        // Enable movement again
        if (rb != null)
        {
            rb.isKinematic = false;
        }

        // Show player again
        playerRenderer.enabled = true;
        Debug.Log("Player has respawned!");
    }
}
