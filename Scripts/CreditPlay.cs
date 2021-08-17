using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditPlay : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            anim.SetTrigger("end");
            FindObjectOfType<Transitions>().ChangeScene = true;
            gamemanage.frompausemenu = false;
        }
    }



}
