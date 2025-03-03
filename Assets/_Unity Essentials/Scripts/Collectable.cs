using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float rotationSpeed;
    public AudioSource soundEffect;


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
            // instantiate the pickup 
            soundEffect.Play();

            // instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);

            // destroy the collectable
            Destroy(gameObject);
        }
    }
}
