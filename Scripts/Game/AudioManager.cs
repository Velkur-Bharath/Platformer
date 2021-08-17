using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager instance;
    //public AudioMixer audiomixer;

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
            return;
        }

        
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.outputAudioMixerGroup = s.audiomixer;
        }
    }

    //theme song here
    /*
     void Start(){
     Play("theme");
        
        }
         */

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        s.source.Play();
    }

    public void PlayOneShotly(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        s.source.PlayOneShot(s.clip);
    }

}
