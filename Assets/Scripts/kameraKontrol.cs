using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraKontrol : MonoBehaviour
{
    public BoxCollider2D cameraBounds; // Kamera hareket s�n�rlay�c�s�
    private Vector3 cameraMin; // Kamera s�n�rlar�n�n minimum pozisyonu
    private Vector3 cameraMax; // Kamera s�n�rlar�n�n maksimum pozisyonu

    void Start()
    {
        // Kamera s�n�rlar�n� hesapla
        cameraMax = cameraBounds.bounds.max;
        cameraMin = cameraBounds.bounds.min;
    }

    void Update()
    {
        // Kameran�n pozisyonunu s�n�rla
        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Clamp(newPosition.x, cameraMin.x, cameraMax.x);
        newPosition.y = Mathf.Clamp(newPosition.y, cameraMin.y, cameraMax.y);
        transform.position = newPosition;

    }
}
