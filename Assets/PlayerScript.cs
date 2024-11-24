using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float speed = 5f;
    public float rotspeed = 50f;
    private float x;
    private float z;
    private Transform tf;
    Vector3 input;

    public GameObject bullet;
    public Vector3 bulletoffset;

    public float fireRate = 0.5f;
    public bool player1 = true;
    public Healthbar healthbar;
    public AudioSource engine;
    public AudioSource shot;
    public ParticleSystem shotef;



    void Start()
    {
        tf = transform;
        InvokeRepeating("Shoot", 0, fireRate);
        engine.Play();
    }


    void Update()
    {
        var input = new Vector3();
        if (player1)
        {
            input.z = Input.GetAxis("Vertical1");
            input.x = Input.GetAxis("Horizontal1");
        }
        else {
            input.z = Input.GetAxis("Vertical2");
            input.x = Input.GetAxis("Horizontal2");
        }

        //input.y = transform.position.y;


        transform.position += input * speed * Time.deltaTime;

        if (input != Vector3.zero)
        {
            transform.forward = input;
        }
        engine.volume = input.magnitude;

    }
    void Shoot()
    {
        //todo:play sound
        //todo:play animation
        Instantiate(bullet, tf.position, tf.rotation);
        shot.pitch = Random.Range(0.8f, 1.2f);
        shot.Play();
        shotef.Play();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) {
            healthbar.TakeDamage(10);
        }
        else if (collision.gameObject.CompareTag("Health"))
        {
            healthbar.TakeDamage(-10);
            Destroy(collision.gameObject);
        }
    }

}
