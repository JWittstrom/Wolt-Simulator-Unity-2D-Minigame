using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float _destroyDelay = 1.0f;
    bool _hasPackage;

    void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !_hasPackage)
        {
            Debug.Log("Package picked up!");
            _hasPackage = true;
            Destroy(other.gameObject, _destroyDelay);
        }

        if (other.tag == "Customer" && _hasPackage)
        {
            Debug.Log("Delivery completed!");
            _hasPackage = false;
            Destroy(other.gameObject, _destroyDelay);
        }            
    }
}