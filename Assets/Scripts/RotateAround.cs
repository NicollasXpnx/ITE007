using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(transform.position, new Vector3(0, 1, 0), 10);
    }
}
