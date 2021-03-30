using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunrotation : MonoBehaviour
{

    public Transform eyes;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(eyes.rotation.x * Time.deltaTime, eyes.rotation.y * Time.deltaTime,  eyes.rotation.z * Time.deltaTime);
    }
}
