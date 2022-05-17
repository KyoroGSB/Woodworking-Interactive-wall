using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAudioPack : MonoBehaviour
{
    public AudioSource audi;
    public AudioClip[] sounds;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void ToTo_Sound() {
        audi.PlayOneShot(sounds[1]);
    }
    void Jump_Sound()
    {
        audi.PlayOneShot(sounds[2]);
    }
    void Collect_Sound()
    {
        audi.PlayOneShot(sounds[3]);
    }
    void ItemFly_Sound()
    {
        audi.PlayOneShot(sounds[4]);
    }
    void BGM_Change()
    {
        StartCoroutine(FadeOut(audi, 0.5f));
        audi.clip = sounds[0];
        //audi.Play();
        
    }
    void BGM_fadeIn() {
        StartCoroutine(FadeIn(audi, 0.5f));
    }
    public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
    {
        float startVolume = 0.1f;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

            yield return null;
        }

        //audioSource.Stop();
        //audioSource.volume = startVolume;
    }

    public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime)
    {
        float startVolume = 0.3f;
        
        audioSource.volume = 0;
        audioSource.Play();

        while (audioSource.volume < 1.0f)
        {
            audioSource.volume += startVolume * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.volume = 1f;
    }

}
