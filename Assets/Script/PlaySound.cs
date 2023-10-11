using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void ActivateSound()
    {
        audioSource.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "DrumStick")
        {
            // audioSource.volume = other.gameobject.GetComponent<>().speed;
            ActivateSound();
        }
    }
}
