using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cicek : MonoBehaviour
{
    private int texticicek = 0;
    [SerializeField] private Text cicektext;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("cicek"))
        {
            Destroy(collision.gameObject);
            texticicek++;
            cicektext.text="Çiçek: " + texticicek;
        }
    }
}

