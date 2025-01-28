using UnityEngine;

public class Collectable : MonoBehaviour
{

    public float rotationSpeed;

    public GameObject onCollectEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0.3f, 0);
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if(other.CompareTag("Player")) 
        {
            // destroy the collectable
            Destroy(gameObject);

            // instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
    }
}
