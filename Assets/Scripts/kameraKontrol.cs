using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraKontrol : MonoBehaviour
{
    public BoxCollider2D cameraBounds; // Kamera hareket sýnýrlayýcýsý
    private Vector3 cameraMin; // Kamera sýnýrlarýnýn minimum pozisyonu
    private Vector3 cameraMax; // Kamera sýnýrlarýnýn maksimum pozisyonu

    void Start()
    {
        // Kamera sýnýrlarýný hesapla
        cameraMax = cameraBounds.bounds.max;
        cameraMin = cameraBounds.bounds.min;
    }

    void Update()
    {
        // Kameranýn pozisyonunu sýnýrla
        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Clamp(newPosition.x, cameraMin.x, cameraMax.x);
        newPosition.y = Mathf.Clamp(newPosition.y, cameraMin.y, cameraMax.y);
        transform.position = newPosition;

    }
}
