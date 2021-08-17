using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reachend : MonoBehaviour
{
    public string SceneStr;//public GameObject respectiveGM;
    public GameManager gm;public int CurrentSceneBuildindex;
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
            FindObjectOfType<Transitions>().ChangeScene = true;
            //SceneManager.LoadScene(SceneStr);
            //FindObjectOfType<GameManager>().scene=SceneStr;
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
            gm.LastCheckPointPosition=new Vector2(-7.5f,-1.612342f);
            GameManager.instance.Scene = CurrentSceneBuildindex;
        }
    }
}
