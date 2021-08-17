using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fromfinalleveltomainmenu : MonoBehaviour
{
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
        if (col.gameObject.tag == "Player")
        {
            gamemanage.frompausemenu = false;
            FindObjectOfType<GameManager>().timer = 0f;
            FindObjectOfType<GameManager>().deathcount = 0;
            FindObjectOfType<GameManager>().gametomenu = true;
            PauseMenu.PauseToMenu = true;
            canvasactive.canvasdecider = false;
        }
    }

}
