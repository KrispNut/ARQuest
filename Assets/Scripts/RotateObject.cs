using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 30.0f; // Adjust the speed of rotation as needed

    void Update()
    {
        // Rotate the object around its Y-axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}