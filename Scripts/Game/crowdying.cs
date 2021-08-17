using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crowdying : MonoBehaviour
{
    //public GameObject crow;
    public GameObject particles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Crow")
        {
            Destroy(col.gameObject);
            GameObject particle = Instantiate(particles, col.gameObject.transform.position, Quaternion.identity);
            Destroy(particle, 1f);
        }
    }

}
