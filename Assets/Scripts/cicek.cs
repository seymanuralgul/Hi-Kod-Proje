using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cicek : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("cicek"))
        {
            Destroy(collision.gameObject);
        }
    }
}

