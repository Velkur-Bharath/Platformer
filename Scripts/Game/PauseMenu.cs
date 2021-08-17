using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false,PauseToMenu=false;
    public GameObject PauseMenuUi;public GameObject Gamemanager;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

    public void Resume()
    {
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ClickMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        PauseToMenu = true;
        gamemanage.frompausemenu = true;
        FindObjectOfType<GameManager>().gametomenu = true;
        canvasactive.canvasdecider = false;
        //FindObjectOfType<Transitions>().ChangeScene = true;
    }

    public void ClickRestart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //FindObjectOfType<Transitions>().ChangeScene = true;
    }

}
