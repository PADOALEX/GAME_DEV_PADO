using UnityEngine;

public class spin : MonoBehaviour
{
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 0.5f;
    [SerializeField] float zAngle = 0f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);        
    }
}
