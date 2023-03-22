using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tascarpma : MonoBehaviour
{
    Vector2 start_position = new Vector2(0, 0);
    // Çarpýþmalarý saymak için sayaç
    int collision_count = 0;

    // Çarpýþmalarý algýlayan fonksiyon
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tas") //  tasa çarpýldý mý?
        {
            collision_count++;

            // Çarpýþma sayýsý 3'e ulaþtýðýnda, oyunu durdur
            if (collision_count == 3)
            {
                Time.timeScale = 0; // Oyun zamanýný durdur
                Debug.Log("Oyun bitti!");
            }
        }
    }
    void ResetCharacterPosition()
    {
        collision_count = 0;
        transform.position = start_position;
    }
}




