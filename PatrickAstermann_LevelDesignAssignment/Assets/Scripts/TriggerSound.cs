using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    private AudioSource _audio;

    void OnTriggerEnter(Collider other)
    {
        _audio.Play();
    }
}
