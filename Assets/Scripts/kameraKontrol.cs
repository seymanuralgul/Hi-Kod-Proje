using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraKontrol : MonoBehaviour
{
    public BoxCollider2D cameraBounds; // Kamera hareket sınırlayıcısı
    private Vector3 cameraMin; // Kamera sınırlarının minimum pozisyonu
    private Vector3 cameraMax; // Kamera sınırlarının maksimum pozisyonu

    void Start()
    {
        // Kamera sınırlarını hesapla
        cameraMax = cameraBounds.bounds.max;
        cameraMin = cameraBounds.bounds.min;
    }

    void Update()
    {
        // Kameranın pozisyonunu sınırla
        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Clamp(newPosition.x, cameraMin.x, cameraMax.x);
        newPosition.y = Mathf.Clamp(newPosition.y, cameraMin.y, cameraMax.y);
        transform.position = newPosition;

    }
}
