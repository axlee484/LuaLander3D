using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private Dictionary<AudioSource, Coroutine> fadeCoroutines = new();
    private void Awake()
    {
        Instance = this;
    }
    public IEnumerator FadeAudioSourceCoRoutine(AudioSource audioSource, float duration)
    {
        
        var elapsedTime = 0f;
        var initVolume = audioSource.volume;
        while (elapsedTime <= duration)
        {
            elapsedTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(initVolume, 0, elapsedTime/duration);
            yield return null;
        }
        audioSource.Stop();
        audioSource.volume = initVolume;
    }
    public void FadeAudioSource(AudioSource audioSource, float duration)
    {
        if(fadeCoroutines.ContainsKey(audioSource)) 
        {
            StopCoroutine(fadeCoroutines[audioSource]);
            fadeCoroutines.Remove(audioSource);
        }
        var coroutine = StartCoroutine(FadeAudioSourceCoRoutine(audioSource, duration));
        fadeCoroutines.Add(audioSource, coroutine);
    }
    
}
