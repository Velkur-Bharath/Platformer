using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transitions : MonoBehaviour
{
    public Animator anim;
    public string SceneName;public bool ChangeScene = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ChangeScene)
        {
            
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene()
    {
        anim.SetTrigger("end");
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(SceneName);
        //ChangeScene = false;
        //StopCoroutine(LoadScene());
    }

}
