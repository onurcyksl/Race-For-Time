using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public AudioSource AudioMan;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void ChangeAudiMan(AudioClip music)
    {
        AudioMan.Stop();
        AudioMan.clip = music;
        AudioMan.Play();
    }
}
