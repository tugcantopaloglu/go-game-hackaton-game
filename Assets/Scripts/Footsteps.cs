using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Footsteps : MonoBehaviour
{   
    [SerializeField] AudioClip[] clips;

    private AudioSource stepAudioSource;


    private void Awake() {
        stepAudioSource = GetComponent<AudioSource>();
    }

    private void Step(){
        AudioClip clip = GetRandomClip();
        stepAudioSource.PlayOneShot(clip);
    }

    private AudioClip GetRandomClip(){
        return clips[UnityEngine.Random.Range(0, clips.Length)];
    }
}
