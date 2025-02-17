using UnityEngine;

public class dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 20f;
    MeshRenderer myRenderer;
    Rigidbody myRigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myRenderer.enabled = false;
        myRigidbody.useGravity = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            myRenderer.enabled = true;
            myRigidbody.useGravity = true;

        }
          
    }
    
}
