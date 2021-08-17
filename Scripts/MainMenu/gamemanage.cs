using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class gamemanage : MonoBehaviour
{
    public static bool frompausemenu;
    public AudioMixer audiomixer; public GameObject continuebutton,Playbutton;
    // Start is called before the first frame update
    void Start()
    {
        //SetVolume(Volume);
        //frompausemenu = false;
        //DontDestroyOnLoad(gameObject);
        //GameManager.instance.canvi.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!frompausemenu)
        {
            continuebutton.SetActive(false);
            Playbutton.SetActive(true);
            
        }
        else
        {
            continuebutton.SetActive(true);
            Playbutton.SetActive(false);
        }
    }

    public void ClickNewGame()
    {
        SceneManager.LoadScene("CutScene1");
        PLayerController.frommenu = true;
        //canvasactive.canvasdecider = true;
        FindObjectOfType<Transitions>().ChangeScene = true;
        StartCoroutine(PlayContinuebutton());
    }

    public void ClickExit()
    {
        Application.Quit();//make yes or no tab
    }

    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("volume", volume);
        //volume = PlayerPrefs.GetFloat("Sound");
        //PlayerPrefs.SetFloat("Sound", volume);
        //Volume = volume;
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void ClickContinue()
    {
        SceneManager.LoadScene(FindObjectOfType<GameManager>().Scene);
        //FindObjectOfType<Transitions>().ChangeScene = true;
    }

    IEnumerator PlayContinuebutton()
    {
        yield return new WaitForSeconds(2f);
        continuebutton.SetActive(true);
        Playbutton.SetActive(false);
        StopCoroutine(PlayContinuebutton());
    }
}
