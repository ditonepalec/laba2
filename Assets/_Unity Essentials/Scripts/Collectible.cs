using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float rotationSpeed;
    public GameObject onCollectEffect;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        

    }

    private void OnTriggerEnter(Collider other) {

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);

            // Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }

    }


    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, rotationSpeed, 0);

    }
}
