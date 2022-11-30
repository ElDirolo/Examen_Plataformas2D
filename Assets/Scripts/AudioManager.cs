using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private AudioSource audioManager;
    public AudioClip saltoFX;
    public AudioClip recoleccionFX;


    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
        
        audioManager = GetComponent<AudioSource>();
    }

    public void saltoSound()
    {
        audioManager.PlayOneShot(saltoFX);
    }

    public void monedaSound()
    {
        audioManager.PlayOneShot(recoleccionFX);
    }
}
