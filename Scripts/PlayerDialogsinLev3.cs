using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDialogsinLev3 : MonoBehaviour
{
    public Image First, second, third, fourth;
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
            StartCoroutine(ShowDialogs());
        }
    }

    IEnumerator ShowDialogs()
    {
        FindObjectOfType<PLayerController>().moveSpeed = 0f;
        First.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        First.gameObject.SetActive(false);
        second.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        second.gameObject.SetActive(false);
        third.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        third.gameObject.SetActive(false);
        fourth.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        fourth.gameObject.SetActive(false);
        FindObjectOfType<PLayerController>().moveSpeed = 4f;
        Destroy(gameObject);
        StopCoroutine(ShowDialogs());
    }

}
