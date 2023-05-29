using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour
{
    public AudioSource backgroundAudioSource;
    public AudioSource fx00;
    public AudioSource fxButton;

    private void Start()
    {
        backgroundAudioSource.Play();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            fx00.Play();
        }
    }

}
