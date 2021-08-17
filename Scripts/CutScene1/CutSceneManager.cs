using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutSceneManager : MonoBehaviour
{
    public Image sec, third, fourth, fifth, sixth, seventh, eighth, ninth;
    int scenenumber=0;
    // Start is called before the first frame update
    void Start()
    {
        scenenumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl)|| Input.GetKeyDown(KeyCode.RightControl))
        {
            scenenumber++;
        }

        if (scenenumber == 1)
            sec.gameObject.SetActive(true);
        else if (scenenumber == 2)
            third.gameObject.SetActive(true);
        else if (scenenumber == 3)
            fourth.gameObject.SetActive(true);
        else if (scenenumber == 4)
            fifth.gameObject.SetActive(true);
        else if (scenenumber == 5)
            sixth.gameObject.SetActive(true);
        else if (scenenumber == 6)
            seventh.gameObject.SetActive(true);
        else if (scenenumber == 7)
            eighth.gameObject.SetActive(true);
        else if (scenenumber == 8)
            ninth.gameObject.SetActive(true);
        else if (scenenumber == 9)
        {
            canvasactive.canvasdecider = true;
            FindObjectOfType<Transitions>().ChangeScene = true;
            SceneManager.LoadScene("Game0");          
            //FindObjectOfType<GameManager>().canvi.SetActive(true);
        }
    }

}
