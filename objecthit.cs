using UnityEngine;

public class objectHit : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Change object color
            meshRenderer.material.color = Color.red;
            gameObject.tag = "Hit";
            
            // Kill and respawn player
            playerhealth playerHealth = other.gameObject.GetComponent<playerhealth>();
            if (playerHealth != null)
            {
                playerHealth.Die();
            }
        }
    }
}