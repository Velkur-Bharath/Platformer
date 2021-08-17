using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCrows : MonoBehaviour
{

    public GameObject[] spawnpoints;public GameObject crows; int x;public int noofcrow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         x = Random.Range(0, spawnpoints.Length);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (noofcrow > 0)
            {
                StartCoroutine(spawncrows());
            }
        }
    }

    IEnumerator spawncrows()
    {
        Instantiate(crows, spawnpoints[x].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(2f);
    }

}
