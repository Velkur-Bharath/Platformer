using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shootermove : MonoBehaviour
{
    Vector2 mover;public float speedX,speedY,timeforparticles;
    Rigidbody2D rb;public GameObject Particles;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        mover = new Vector2(speedX, speedY);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(mover);
        Destroy(gameObject,5f);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Destroy(gameObject);
        if (col.gameObject.tag == "Player")
        {
            GameObject particle = Instantiate(Particles, transform.position, Quaternion.identity);
            Destroy(gameObject);
            FindObjectOfType<PLayerController>().TakeDamage();
            Destroy(particle, timeforparticles);
        }
        if (col.gameObject.tag == "Box")
        {
            GameObject particle = Instantiate(Particles, transform.position, Quaternion.identity);
            Destroy(gameObject); 
            Destroy(particle, timeforparticles);
        }
        if (col.gameObject.tag == "Ground")
        {
            GameObject particle = Instantiate(Particles, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(particle, timeforparticles);
        }
        if (col.gameObject.tag == "Crow")
        {
            GameObject particle = Instantiate(Particles, transform.position, Quaternion.identity);
            //Destroy(col.gameObject);
            Destroy(gameObject);
            Destroy(particle,timeforparticles);
        }
    }

}
