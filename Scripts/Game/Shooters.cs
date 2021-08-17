using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooters : MonoBehaviour
{
    public GameObject shooter;public float cooldowntime,cooldowntimerremember;
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldowntime -= Time.deltaTime;
        if (cooldowntime <= 0)
        {
           GameObject spawnedbullet= Instantiate(shooter, transform.position, Quaternion.identity);
            cooldowntime = cooldowntimerremember;     
        }
    }

}
