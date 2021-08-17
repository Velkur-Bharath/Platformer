using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{
    Rigidbody2D rb; bool facingRight = true;public static bool frommenu;
    public float moveSpeed, jumpSpeed; public LayerMask groundmask,Obstaclemask; public BoxCollider2D box;
    Animator anim; public GameManager gm;public bool takedamage = true;public int health = 3;
    public GameObject particles;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        health = 3;
        canvasactive.canvasdecider = true;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();       
            transform.position = gm.LastCheckPointPosition;
        PauseMenu.PauseToMenu = false;
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float Xinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Xinput * moveSpeed, rb.velocity.y);
        if (!facingRight && Xinput > 0 || facingRight && Xinput < 0)
        {
            Flip();
        }
        Jump();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = rb.transform.localScale;
        scaler.x *= -1;
        rb.transform.localScale = scaler;
    }

    void Jump()
    {
        float jumptimerremembertime = 0.2f, jumptimerremember = 0, jumpgroundtimer = 0, jumpgroundtimerremember = 0.2f;
        jumptimerremember -= Time.deltaTime;
        jumpgroundtimer -= Time.deltaTime;
        if (GroundHit()||ObstacleHit())
        {
            jumpgroundtimer = jumpgroundtimerremember;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            jumptimerremember = jumptimerremembertime;
        }
        if ((jumptimerremember > 0) && (jumpgroundtimer > 0))
        {
            jumptimerremember = 0;
            jumpgroundtimer = 0;
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            GameObject particle = Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(particle, 0.5f);
            //FindObjectOfType<CameraShake>().shakeitlow();
            FindObjectOfType<AudioManager>().Play("jump");           
            if (facingRight)
            {
                anim.SetBool("Jumpleft",true);
            }
            else if (!facingRight)
            {
                anim.SetBool("Jump",true);
            }    
        }
        else
        {
            anim.SetBool("Jumpleft", false);
            anim.SetBool("Jump", false);
        }
    }

    bool GroundHit()
    {
        RaycastHit2D raycasthit = Physics2D.BoxCast(box.bounds.center, box.bounds.size, 0f, Vector2.down, 0.09f, groundmask);
        return raycasthit.collider != null;
    }

    bool ObstacleHit()
    {
        RaycastHit2D raycasthit = Physics2D.BoxCast(box.bounds.center, box.bounds.size, 0f, Vector2.down, 0.07f, Obstaclemask);
        return raycasthit.collider != null;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            GameObject particle = Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(particle, 0.2f);
        }
        if (col.gameObject.tag == "Obstacles")
        {
            GameObject particle = Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(particle, 0.2f);
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {

    }

    public void TakeDamage()
    {
        if (takedamage)
        {
            StartCoroutine(damage());
            anim.SetTrigger("Damage");
            FindObjectOfType<AudioManager>().Play("playerhurt");           
        }
    }

    IEnumerator damage()
    {
        health--;
        takedamage = false;
        yield return new WaitForSeconds(1f);
        takedamage = true;
        StopCoroutine(damage());
    }

}
