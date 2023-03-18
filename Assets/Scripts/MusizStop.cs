using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusizStop : MonoBehaviour
{

    private AudioSource audioSource;
    void OnDestroy()
    {
        audioSource.Stop();
    }
}
