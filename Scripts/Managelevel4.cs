using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managelevel4 : MonoBehaviour
{
    public GameObject triangle, triggeringcutscene;
    public static bool fromcutscene;
    // Start is called before the first frame update
    void Start()
    {
        if (fromcutscene)
        {
            Destroy(triangle);
            Destroy(triggeringcutscene);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
