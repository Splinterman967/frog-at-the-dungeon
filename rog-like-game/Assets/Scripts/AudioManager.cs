using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;
    public Slider musicSlider, sfxSlider;
    private void Awake()
    {
        //Making single instance of audioManager 
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.soundName == name);
        if (s == null)
        {
            Debug.Log("Music not found");
        }
        else
        {
            musicSource.clip = s.audioClip;
            musicSource.Play();
        }
    }
    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.soundName == name);
        if (s == null)
        {
            Debug.Log("SFX not found");
        }
        else
        {
            sfxSource.PlayOneShot(s.audioClip);
            //sfxSource.clip = s.audioClip;
            //sfxSource.Play();
        }
    }
    public void StopMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.soundName == name);
        if (s == null)
        {
            Debug.Log("Music not found");
        }
        else
        {
            musicSource.clip = s.audioClip;
            musicSource.Stop();
        }
    }
    public void StopSFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.soundName == name);
        if (s == null)
        {
            Debug.Log("Music not found");
        }
        else
        {
            sfxSource.clip = s.audioClip;
            sfxSource.Stop();
        }
    }
    public void adjustMusic(float volume)
    {
        musicSource.volume = musicSlider.value;
    }
    public void adjustSound(float volume)
    {
        sfxSource.volume = sfxSlider.value;
    }
}
