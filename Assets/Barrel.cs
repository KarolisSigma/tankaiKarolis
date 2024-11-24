
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public ParticleSystem particles;
    public float radius;
    private int currenthealth = 50;
    
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Bullet")) {
            currenthealth -= 10;
            Destroy(collision.gameObject);
            if (currenthealth <= 0) {
                particles.transform.position = collision.transform.position;
                particles.Play();

                foreach (GameObject g in GameObject.FindGameObjectsWithTag("car"))
                {
                    if (Vector3.Distance(transform.position, g.transform.position) < radius)
                    {
                        g.GetComponent<PlayerScript>().healthbar.TakeDamage(25);
                    }
                }
                Destroy(gameObject);
            }

        }
    }
}
