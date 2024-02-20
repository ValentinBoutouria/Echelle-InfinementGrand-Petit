using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonsBoutons : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public AudioClip soundClip;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void JoueSon()
    {
        audioSource.PlayOneShot(soundClip);
    }
   
}
