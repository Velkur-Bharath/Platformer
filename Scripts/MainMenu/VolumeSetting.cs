using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSetting : MonoBehaviour
{
    public static VolumeSetting instance;
    public float Volume=0;
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
