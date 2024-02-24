using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public Transform playerTransform;
    Vector3 dir;
    void Start()
    {
        Input.location.Start();
        Input.compass.enabled = true;
    }
    void Update()
    {
        dir.z = playerTransform.eulerAngles.y;
        transform.localEulerAngles = dir;
    }
}
