using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    Camera kamera;
    GameObject[] golgeler;
    Vector2 baslangic_pozisyon;
    void Start()
    {
        kamera = GameObject.Find("camera").GetComponent<Camera>();
        golgeler = GameObject.FindGameObjectsWithTag("golge");
        baslangic_pozisyon = transform.position;
        
    }
    void onMouseDrag()
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;

    }

    void Update()
    {
        
    }
}
