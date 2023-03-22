using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tascarpma : MonoBehaviour
{
    Vector2 start_position = new Vector2(0, 0);
    // �arp��malar� saymak i�in saya�
    int collision_count = 0;

    // �arp��malar� alg�layan fonksiyon
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tas") //  tasa �arp�ld� m�?
        {
            collision_count++;

            // �arp��ma say�s� 3'e ula�t���nda, oyunu durdur
            if (collision_count == 3)
            {
                Time.timeScale = 0; // Oyun zaman�n� durdur
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




