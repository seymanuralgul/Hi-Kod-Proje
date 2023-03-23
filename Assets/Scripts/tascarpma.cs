using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tascarpma : MonoBehaviour
{
    Vector2 startPosition;
    public int canBarý = 3;

    // Çarpýþmalarý saymak için sayaç
    int collisionCount = 0;

    // Baþlangýç konumunu ayarlayan fonksiyon
    void Start()
    {
        startPosition = transform.position;
    }

    // Çarpýþmalarý algýlayan fonksiyon
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Tas")) // Eðer çarpýþma tas objesiyle olduysa
        {
            collisionCount++; // Çarpýþma sayýsýný arttýr
            canBarý--;

            if (collisionCount == 3) // Eðer bir kez çarpýldýysa
            {
                ResetCharacterPosition(); // Karakteri baþlangýç pozisyonuna taþý
               
            }
            if (canBarý <= 0)
            {
                transform.position = startPosition;
                canBarý = 1; // CanBarý deðerini sýfýrlayýn
            }
        }

        // Karakteri baþlangýç konumuna yerleþtiren fonksiyon
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
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = true;
        }
    }
}




