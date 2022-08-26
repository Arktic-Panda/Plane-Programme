using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopellerMovement : MonoBehaviour
{   
    //INITIALING PROPELLER ROTATION SPEED
    private float turnSpeed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ROTATING PROPELLER IN Z AXIS
        transform.Rotate(Vector3.forward, Time.deltaTime * turnSpeed );
    }
}
