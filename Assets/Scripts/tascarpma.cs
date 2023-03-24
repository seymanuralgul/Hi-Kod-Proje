using Microsoft.Unity.VisualStudio.Editor;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tascarpma : MonoBehaviour
{
    // Karakterin ba�lang�� konumu
    Vector2 startPosition = new Vector2(6,4);

    // �arp��malar� saymak i�in saya�
    int collisionCount = 0;

    // �arp��malar� alg�layan fonksiyon
    void OnCollisionEnter2D(Collision2D collision)
    {
        // �arp��ma nesnesi "Tas" tag�na sahip mi?
        if (collision.gameObject.CompareTag("Tas"))
        {
            // �arp��ma say�s�n� art�r
            collisionCount++;

            // 3 tane "Tas" tagl� nesneye �arp�ld���nda, ba�lang�� pozisyonuna d�n
            if (collisionCount == 3)
            {
                ReturnToStartPosition();
            }
        }
    }

    // Karakteri ba�lang�� pozisyonuna d�nd�ren fonksiyon
    void ReturnToStartPosition()
    {
        // �arp��ma sayac�n� s�f�rla
        collisionCount = 0;

        // Karakteri ba�lang�� pozisyonuna ta��
        transform.position = startPosition;

        // Karakterin aktifli�ini kontrol et
      
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
            SpriteRenderer renderer = GetComponent<SpriteRenderer>();
           renderer .enabled = true;

        }
    }
}


















