using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class attackingcrow : MonoBehaviour
{
    public Transform player;    
    Animator anim;
    public AIPath aiPath;public float positivepos, negativepos;
    

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        FollowPlayer();
        if (aiPath.desiredVelocity.x <= negativepos)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (aiPath.desiredVelocity.x >= positivepos)//make this statement with public float and make more crows
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    void FollowPlayer()
    {
        if (Vector2.Distance(transform.position, player.transform.position) > 0.5f)
        {
            //FindObjectOfType<AudioManager>().Play("crowattacking");
            anim.SetBool("Attack", false);           
            //attack player
        }
        else if(Vector2.Distance(transform.position, player.transform.position) < 1.5f)
        {
            FindObjectOfType<AudioManager>().Play("crowattack");
            FindObjectOfType<PLayerController>().TakeDamage();
            anim.SetBool("Attack", true);

        }                   
    }

}
