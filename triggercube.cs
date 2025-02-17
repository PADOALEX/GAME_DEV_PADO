using Unity.VisualScripting;
using UnityEngine;

public class trigercube : MonoBehaviour
{
    [SerializeField] GameObject projectile;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            projectile.SetActive(true);
            Destroy(gameObject);
        }
    }
}
