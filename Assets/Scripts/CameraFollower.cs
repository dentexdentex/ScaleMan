using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private bool canFollow;
    
    
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canFollow)
        {
            transform.position = target.position + offset;
        }
    }
}
