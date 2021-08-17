using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Vector2 LastCheckPointPosition;
    public int healthcount, deathcount=0;
    public Text Deathtext,timertext;public GameObject heart1, heart2, heart3;
    public float timer;public Canvas canvi;//that heart thingys
    public bool gametomenu;public int Scene=2;//public float VOLUME=0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
     
    }

    // Start is called before the first frame update
    void Start()
    {       
        Deathtext.text = deathcount.ToString();
        PauseMenu.PauseToMenu = false;
        canvi.gameObject.SetActive(true); gametomenu = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.PauseToMenu == false)
        {
            healthcount = FindObjectOfType<PLayerController>().health;
        }

        if (!gametomenu)
        {
            timer += Time.deltaTime;
            timertext.text = timer.ToString("F1");
            Deathtext.text = deathcount.ToString();
            if (healthcount == 3)
            {
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
            }
            else if (healthcount == 2)
            {
                heart1.SetActive(false);
                heart2.SetActive(true);
                heart3.SetActive(true);
            }
            else if (healthcount == 1)
            {
                heart1.SetActive(false);
                heart2.SetActive(false);
                heart3.SetActive(true);
            }
            else if (healthcount == 0)
            {
                deathcount++;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                FindObjectOfType<PLayerController>().health = 3;
                healthcount = 3;
            }
        }
    }
}
