using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
       /* if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
       */
    }
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, Sound => Sound.name == name);

        if (s == null)
        {
            
            return;
        }
        else
        {
            
            musicSource.clip = s.clip;
            musicSource.volume = 0.2f;
            musicSource.Play();
        }
    }
    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, Sound => Sound.name == name);

        if (s == null)
        {
           
            return;
        }
        else
        {
           
            sfxSource.PlayOneShot(s.clip);
        }
    }
}