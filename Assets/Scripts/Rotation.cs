using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Vector3 rotationAxis = new Vector3(0, 1, 0); // Default Y-axis
    public float rotationSpeed = 20f;

    void Update()
    {
        transform.Rotate(rotationAxis.normalized * rotationSpeed * Time.deltaTime);
    }
}
