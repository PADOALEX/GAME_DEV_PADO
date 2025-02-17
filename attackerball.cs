using Unity.VisualScripting;
using UnityEngine;

public class attackerball : MonoBehaviour
{
    [SerializeField] float speed = 0.5f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        
        playerPosition = player.transform.position;
        
    }
    void Update()
    {
        movetoplayer();
        DestroyWhenReach();
    }
    void movetoplayer()
    {
        transform.position = 
        Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }
    void DestroyWhenReach()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
    
}
