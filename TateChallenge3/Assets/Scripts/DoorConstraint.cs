using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorConstraint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position.z = Mathf.Clamp(transform.position.z, 54.0f, 60.0f);
    }
}
