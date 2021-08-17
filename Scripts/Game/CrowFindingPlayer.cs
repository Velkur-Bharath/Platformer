using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowFindingPlayer : MonoBehaviour
{
    public GameObject crow;
    public float speed;
    Vector2 dirofcrow;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        dirofcrow = new Vector2(speed, speed);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            crow.GetComponent<Rigidbody2D>().AddForce(dirofcrow, ForceMode2D.Impulse);
            anim.SetTrigger("Detect");
            Destroy(gameObject, 5f);
            FindObjectOfType<AudioManager>().Play("findingcrows");
        }
    }
}
