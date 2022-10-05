using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float speed = 10.0f;


    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(
            target.transform.position,
            target.transform.up,
            speed*Time.deltaTime
            );
        
    }
}
