using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedController : MonoBehaviour
{
    public float speedMultiplier =  1f;
    public float currentSpeed;
    private Rigidbody rb;

    private ScaleController _scaleController;
    void Start() {
        rb = GetComponent<Rigidbody>();
        _scaleController = FindObjectOfType<ScaleController>();
    }

    void FixedUpdate() {
        float newSpeed = 7.1f +_scaleController.multp * speedMultiplier;
        
        //  rb.AddForce(transform.forward * (newSpeed - currentSpeed), ForceMode.VelocityChange); // ileri doğru kuvvet uygula
        transform.position += transform.forward * (newSpeed) * Time.deltaTime;
    }
  

}
