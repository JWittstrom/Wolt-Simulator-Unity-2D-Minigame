using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float _turnSpeed = 0.1f;
    [SerializeField] float _moveSpeed = 0.01f;
    
    void Start()
    {

    }

    void Update()
    {
        CarControls();   
    }

    void CarControls()
    {
        float turnAmount = Input.GetAxis("Horizontal") * _turnSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, moveAmount, 0);
    }        
}