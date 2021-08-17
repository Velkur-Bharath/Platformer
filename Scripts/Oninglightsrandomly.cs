using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oninglightsrandomly : MonoBehaviour
{
    public GameObject[] lights;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LightGlow());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator LightGlow()
    {
        while (true)
        {
            int x = Random.Range(0, lights.Length) ;
            lights[x].SetActive(true);
            yield return new WaitForSeconds(2f);
            lights[x].SetActive(false);
        }
    }

}
