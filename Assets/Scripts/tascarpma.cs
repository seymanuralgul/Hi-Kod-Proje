using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tascarpma : MonoBehaviour
{
    Vector2 startPosition;
    public int canBar� = 3;

    // �arp��malar� saymak i�in saya�
    int collisionCount = 0;

    // Ba�lang�� konumunu ayarlayan fonksiyon
    void Start()
    {
        startPosition = transform.position;
    }

    // �arp��malar� alg�layan fonksiyon
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Tas")) // E�er �arp��ma tas objesiyle olduysa
        {
            collisionCount++; // �arp��ma say�s�n� artt�r
            canBar�--;

            if (collisionCount == 3) // E�er bir kez �arp�ld�ysa
            {
                ResetCharacterPosition(); // Karakteri ba�lang�� pozisyonuna ta��
               
            }
            if (canBar� <= 0)
            {
                transform.position = startPosition;
                canBar� = 1; // CanBar� de�erini s�f�rlay�n
            }
        }

        // Karakteri ba�lang�� konumuna yerle�tiren fonksiyon
        void ResetCharacterPosition()
        {
            collisionCount = 0;
            gameObject.SetActive(false);
            transform.position = startPosition;
            gameObject.SetActive(true);
            
            // Karakterin h�z�n� ve momentumunu s�f�rla
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0f;
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = true;
        }
    }
}




