using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool _hasPackage;

    void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            Debug.Log("Package picked up!");
            _hasPackage = true;
        }

        if (collision.tag == "Customer" && _hasPackage)
        {
            Debug.Log("Delivery completed!");
            _hasPackage = false;
        }            
    }
}