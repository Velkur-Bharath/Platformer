using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasactive : MonoBehaviour
{
    public static bool canvasdecider;
    public Canvas canvi;
    // Start is called before the first frame update
    void Start()
    {     
             
    }
    void Update()
    {
        if (canvasdecider)
        {
            canvi.gameObject.SetActive(true);
            GameManager.instance.gametomenu = false;
        }
        else if (!canvasdecider)
        {
            canvi.gameObject.SetActive(false);
            GameManager.instance.gametomenu = true;
        }
    }
}
