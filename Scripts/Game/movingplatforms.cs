using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatforms : MonoBehaviour
{
    public float speed,dirxn,dirxp,diryn,diryp;
    bool right = true, up = true;
    public bool verticalplatform, horizontalplatform;
    public Vector3 movingvec,playervec;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (horizontalplatform)
        {
            if (transform.position.x > dirxp)
                right = false;
            if (transform.position.x < dirxn)
                right = true;
            if (right)
            {
                movingvec = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
                transform.position = movingvec;
                    playervec = new Vector3(speed *50*Time.fixedDeltaTime, 0f, 0f);
            }
            else
            {
                movingvec= new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
                transform.position = movingvec;
                    playervec = new Vector3(-speed*50*Time.fixedDeltaTime, 0f, 0f);
            }
        }
        if (verticalplatform)
        {
            if (transform.position.y > diryp)
                up = false;
            if (transform.position.y < diryn)
                up = true;
            if (up)
            {
                movingvec= new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
                transform.position = movingvec;
                    playervec = new Vector3(0, speed *50*Time.fixedDeltaTime, 0f);
            }
            else
            {
                movingvec= new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
                transform.position = movingvec;
                    playervec = new Vector3(0, -speed *50* Time.fixedDeltaTime, 0f);
            }
        }
    }

    
}
