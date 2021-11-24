using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGenerator : MonoBehaviour
{
    public AudioSource keyAudio, doorAudio, orcaAudio;
    // Start is called before the first frame update
    private void Awake(){
        /* keyAudio = GetComponent<AudioSource>(); */
    }

    public void makeSound(string audioName) {
        print("make Sound "+ audioName);
        if (audioName == "key")
        {
            keyAudio.Play(0);
            print("play key");
        }

        if (audioName == "door")
        {
            doorAudio.Play(0);
            print("play door");
        }

    }
}
