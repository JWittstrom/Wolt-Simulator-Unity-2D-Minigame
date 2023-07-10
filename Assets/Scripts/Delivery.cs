using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 _hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 _noPackageColor = new Color32(0, 0, 0, 0);

    [SerializeField] float _destroyDelay = 1.0f;
    bool _hasPackage;

    SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !_hasPackage)
        {
            Debug.Log("Package picked up!");
            _hasPackage = true;
            _spriteRenderer.color = _hasPackageColor;
            Destroy(other.gameObject, _destroyDelay);
        }

        if (other.tag == "Customer" && _hasPackage)
        {
            Debug.Log("Delivery completed!");
            _hasPackage = false;
            _spriteRenderer.color = _noPackageColor;
            Destroy(other.gameObject, _destroyDelay);
        }            
    }
}