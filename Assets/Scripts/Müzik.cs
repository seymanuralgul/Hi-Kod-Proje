using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Müzik : MonoBehaviour
{
    private AudioSource audioSource;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }

    
}
