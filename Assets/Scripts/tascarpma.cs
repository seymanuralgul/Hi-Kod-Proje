using Microsoft.Unity.VisualStudio.Editor;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tascarpma : MonoBehaviour
{
    // Karakterin baþlangýç konumu
    Vector2 startPosition = new Vector2(6,4);

    // Çarpýþmalarý saymak için sayaç
    int collisionCount = 0;

    // Çarpýþmalarý algýlayan fonksiyon
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Çarpýþma nesnesi "Tas" tagýna sahip mi?
        if (collision.gameObject.CompareTag("Tas"))
        {
            // Çarpýþma sayýsýný artýr
            collisionCount++;

            // 3 tane "Tas" taglý nesneye çarpýldýðýnda, baþlangýç pozisyonuna dön
            if (collisionCount == 3)
            {
                ReturnToStartPosition();
            }
        }
    }

    // Karakteri baþlangýç pozisyonuna döndüren fonksiyon
    void ReturnToStartPosition()
    {
        // Çarpýþma sayacýný sýfýrla
        collisionCount = 0;

        // Karakteri baþlangýç pozisyonuna taþý
        transform.position = startPosition;

        // Karakterin aktifliðini kontrol et
      
        void ResetCharacterPosition()
        {
            collisionCount = 0;
            gameObject.SetActive(false);
            transform.position = startPosition;
            gameObject.SetActive(true);

            // Karakterin hýzýný ve momentumunu sýfýrla
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0f;
            SpriteRenderer renderer = GetComponent<SpriteRenderer>();
           renderer .enabled = true;

        }
    }
}


















