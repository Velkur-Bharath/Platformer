using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathandRestart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //Destroy(col.gameObject);
            FindObjectOfType<AudioManager>().Play("playerhurt");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            FindObjectOfType<GameManager>().deathcount++;
        }
    }

}
