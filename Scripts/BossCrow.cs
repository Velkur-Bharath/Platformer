using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCrow : MonoBehaviour
{
    public Animator anim;
    public GameObject TargetForBoss,crows;public bool Startingcourotine;
    public static bool PlayerReachedornot;
    public float cooldowntime, cooldowntimerremember;public AudioSource flysound;public AudioClip sound;
    bool ifsounplayed = false;
    // Start is called before the first frame update
    void Start()
    {
        flysound = GetComponent<AudioSource>();
        if (PlayerReachedornot)
        {
            
            anim.SetBool("makefly", true);
            transform.position = TargetForBoss.transform.position;
            CooldownSpawner();
        }
        else
        {
            anim.SetBool("makefly", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Startingcourotine)
        {
            StartCoroutine(BossControl());
            CooldownSpawner();
        }
    }

    void GoingPlayerNear()
    {
        transform.position = Vector2.MoveTowards(transform.position, TargetForBoss.transform.position,1f);
        PlayerReachedornot = true;        
    }

    IEnumerator BossControl()
    {       
        anim.SetTrigger("near");
        yield return new WaitForSeconds(0.2f);        
        if (!ifsounplayed)
        {            
            flysound.PlayOneShot(sound);
            ifsounplayed = true;            
        }        
        anim.SetTrigger("fly");
        GoingPlayerNear();
        yield return new WaitForSeconds(2.5f);
        anim.SetTrigger("stand");
        yield return new WaitForSeconds(1.5f);        
        StopCoroutine(BossControl());          
    }
    void CooldownSpawner()
    {
        cooldowntime -= Time.deltaTime;
        if (cooldowntime <= 0)
        {
            GameObject spawnedbullet = Instantiate(crows, transform.position, Quaternion.identity);
            cooldowntime = cooldowntimerremember;
        }
    }
}
