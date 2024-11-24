using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed=15f;
    public float lifeTime=2f;
    private int damage = 20;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, lifeTime);
        Invoke("selfdestruct", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    void OnCollisionEnter(Collision collision)
    {
        selfdestruct();
    }
    void selfdestruct()
    {
        Instantiate(explosion, transform.position, Quaternion.identity).GetComponent<ParticleSystem>().Play() ;
        Destroy(gameObject);

    }
}
