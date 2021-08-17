﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTrigger : MonoBehaviour
{
    public Image dialog;public float time;//public bool triggeredalready=false;
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
        if(col.gameObject.tag=="Player")
        StartCoroutine(ShowDialog());
    }

    IEnumerator ShowDialog()
    {
        //triggeredalready = true;
        dialog.gameObject.SetActive(true);
        yield return new WaitForSeconds(time);
        dialog.gameObject.SetActive(false);
        Destroy(gameObject);
        StopCoroutine(ShowDialog());
    }

}
