using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeringCrowsin3level : MonoBehaviour
{
    public GameObject Crows;
   
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Crows.SetActive(true);
        }
    }
}
