using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechToText : MonoBehaviour
{
    public AudioSource _audio;
    void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
        StartCoroutine(DownloadTheAudio());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DownloadTheAudio()
    {
        string url = "https://translate.google.com/#view=home&op=translate&sl=en&tl=fa&text=hello";
        WWW www = new WWW(url);
        yield return www;

        _audio.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        _audio.Play();

    }
}
