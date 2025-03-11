using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Collectible2D : MonoBehaviour
{

    public float rotationSpeed = 0;
    public GameObject onCollectEffect;

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, rotationSpeed, 0);
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
         // Check if the other object has a PlayerController2D component
        if (other.GetComponent<PlayerController2D>() != null) {
            
            // Destroy the collectible
            Destroy(gameObject);

            // Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }

        
    }
    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {

            // Destroy the collectible
            Destroy(gameObject);

            // Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }

    }

}


